using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using RSharp.Compiler;
//using Microsoft.Build.BuildEngine;
using Microsoft.Build;
using Microsoft.Build.Evaluation;

namespace MSBuilgApiTest
{
	using StrTreeNodePair = KeyValuePair<string, List<TreeNode>>;
	using ItemTypesMap = Dictionary<string, List<TreeNode>>;
	using TreeMap = Dictionary<string, TreeNode>;

	partial class MainForm : Form
	{
		const string ConfigPropName = "Configuration";

		public MainForm()
		{
			InitializeComponent();
		}

		#region Рабочие поля.

		/// <summary>
		/// Путь к последнему загруженному проекту.
		/// </summary>
		private string _lastOpenedProject;

		/// <summary>
		/// Флаг загрузки информации о конфигурации.
		/// </summary>
		private bool _isConfigurationLoading; 

		#endregion

		#region Загрузка проекта.

		/// <summary>
		/// Считываес (с помощью API MSBuild) содержимое файла проекта
		/// и заполняет GUI-элементы соотвествующими значениями.
		/// </summary>
		/// <param name="configuration">
		/// Имя конфигурации которую нужно считать. Если пустая строка или null
		/// </param>
		private void OpenProject(string prjPath, string configuration)
		{
			if (string.IsNullOrEmpty(prjPath) || !File.Exists(prjPath))
			{
				MessageBox.Show(this, "Error",
					"Wrong project path '" + prjPath + "'");
				return;
			}

			_propertyGrid.SelectedObject = null;

			MsBuildProjectHelper msBuildHelper = new MsBuildProjectHelper(
				prjPath);

			// Если configuration не пуста устанавливаем значение свойства
			// Configuration. Это позволит считать соотвествующую конфигурацию
			// проекта.
			if (!string.IsNullOrEmpty(configuration))
				msBuildHelper.Project.SetProperty(ConfigPropName, configuration);

			this.Text = "MSBuild Profect Viewer - " + Path.GetFullPath(prjPath);

			FillItemsView(msBuildHelper);
			FillPropertiesView(msBuildHelper);
			FillConfiguration(msBuildHelper);

			_lastOpenedProject = prjPath;
		}

		/// <summary>
		/// Выводит диалог открытия прокта и считываес 
		/// (с помощью API MSBuild) содержимое файла проекта
		/// и заполняет GUI-элементы соотвествующими значениями.
		/// </summary>
		private void OpenProject()
		{
			if (_openProjectDialog.ShowDialog(this) == DialogResult.OK)
				OpenProject(_openProjectDialog.FileName, "");
		} 

		#endregion

		#region Обработчики событий GUI.

		private void _projectConfigurationToolStripComboBox_SelectedIndexChanged(
			object sender,
			EventArgs e)
		{
			if (_isConfigurationLoading
				|| _projectConfigurationToolStripComboBox.SelectedItem == null)
				return;

			if (string.IsNullOrEmpty(_lastOpenedProject))
				MessageBox.Show(this, "Error", "Open a project first!");
			else
				OpenProject(
					_lastOpenedProject,
					_projectConfigurationToolStripComboBox.SelectedItem.ToString());
		}

		private void _openProjectToolStripMenuItem_Click(
			object sender,
			EventArgs e)
		{
			OpenProject();
		}

		private void _openProjectToolStripButton_Click(object sender, EventArgs e)
		{
			OpenProject();
		}

		private void _projectTreeView_AfterSelect(
			object sender,
			TreeViewEventArgs e)
		{
			// При выделении ветки в дереве элементов проекта отображаем
			// выбранный элемент в PropertyGrid.
			if (e.Node != null)
				_propertyGrid.SelectedObject = e.Node.Tag;
		}

		private void _propertiesListView_SelectedIndexChanged(
			object sender,
			EventArgs e)
		{
			// При выделении строки в списке свойств проекта отображаем
			// выбранное свойство в PropertyGrid.
			if (_propertiesListView.FocusedItem != null)
				_propertyGrid.SelectedObject = _propertiesListView.FocusedItem.Tag;
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			// Этот код замазывает баг фрэймворка. Если процесс не убивать,
			// то при выходе происходит ужасная загрузка процессора и процесс
			// замерзает на довольно продолжительное время.
			System.Diagnostics.Process.GetCurrentProcess().Kill();
		}

		#endregion

		#region Загузка списка конфигуркций.

		/// <summary>
		/// Считывет список конфигураций и заполняет ими выпадающий список
		/// в панеле инструментов.
		/// </summary>
		/// <param name="msBuildHelper"></param>
		private void FillConfiguration(MsBuildProjectHelper msBuildHelper)
		{
			try
			{
				_isConfigurationLoading = true;

				Project prj = msBuildHelper.Project;

				var sonfigurations = prj.ConditionedProperties[ConfigPropName];

				_projectConfigurationToolStripComboBox.Items.Clear();
				_projectConfigurationToolStripComboBox.Items.AddRange(sonfigurations.ToArray());


				var property = msBuildHelper.Project.GetProperty(ConfigPropName);


				if (property != null)
					_projectConfigurationToolStripComboBox.Text = property.EvaluatedValue;
			}
			finally
			{
				_isConfigurationLoading = false;
			}
		} 

		#endregion

		#region Заполнение списка свойств.

		/// <summary>
		/// Считывает описание свойств MSBuild и заполняет ими ListView.
		/// </summary>
		/// <param name="msBuildHelper">MsBuildProjectHelper</param>
		/// <summary>
		private void FillPropertiesView(MsBuildProjectHelper msBuildHelper)
		{
			// EvaluatedProperties содержит список свойств получаемый 
			// после всех подстановок и проверок.

			foreach (ProjectProperty prop in msBuildHelper.Project.AllEvaluatedProperties)
			{
				ListViewItem lvItem = new ListViewItem(prop.Name);
				lvItem.SubItems.Add(prop.UnevaluatedValue);
				lvItem.SubItems.Add(prop.EvaluatedValue);

				lvItem.Tag = prop;
				lvItem.ImageIndex = 2;
				_propertiesListView.Items.Add(lvItem);
			}
		}

		#endregion

		#region Заполнение делева элементов

		/// <summary>
		/// Считывает описание элеметов MSBuild и заполняет ими TreeView.
		/// </summary>
		/// <param name="msBuildHelper">MsBuildProjectHelper</param>
		private void FillItemsView(MsBuildProjectHelper msBuildHelper)
		{
			_projectTreeView.BeginUpdate();
			try
			{
				// Первый проходом считываем элементы группируя их по типам.
				// itemTypesMap содержит ассоциативный массив имен типов элементов 
				// и списков элементов.
				ItemTypesMap itemTypesMap = InitItemTypesMap(msBuildHelper);

				// Сортировка в TreeView делается очень медленно. По этому запрещаем
				// ее и выполняем ее потом вручную.
				_projectTreeView.TreeViewNodeSorter = null;
				_projectTreeView.Sorted = false;
				// Очищаем TreeView.
				_projectTreeView.Nodes.Clear();

				// Эта переменная будет содержать список корневых веток TreeView.
				TreeNodeCollection rootNodes = _projectTreeView.Nodes;

				// Для каждого типа элементов...
				foreach (StrTreeNodePair elem in itemTypesMap)
				{
					// ... создаем корневую TreeView-ветку...
					TreeNode typeNode = new TreeNode(elem.Key);
					rootNodes.Add(typeNode);

					// Эта переменная будет содержать мап путь/TreeView-веток 
					// для этого пути.
					TreeMap treeMap = new TreeMap();

					// Для каждого элемента данного типа...
					foreach (TreeNode node in elem.Value)
					{
						// ... получаем путь к фалу.
						string dir = Path.GetDirectoryName(node.Text);
						// Находим соотвествующий фолдер (TreeView-ветку его описывающую).
						TreeNode folder = GetParentFolder(typeNode, treeMap, dir);
						// Получаем имя файла...
						string file = Path.GetFileName(node.Text);
						// ... которое используем в качестве имени элемента.
						node.Text = file;
						// Назначаем иконки файлов и добавляем ветку.
						const int FileImageIndex = 1;
						node.ImageIndex = FileImageIndex;
						node.SelectedImageIndex = FileImageIndex;
						folder.Nodes.Add(node);
					}
				}

				// Закат солнца вручную. :) Ручная сортировка требуется в виду
				// диких тормозов встроенной в TreeView сортировки.
				// Возможно к релизу эту проблему стронят, но пока...
				SortTreeNodes(rootNodes, new MSBuildTreeViewNodeSorter());
			}
			finally
			{
				// Что бы не случилось нужно разрешить отрисовку. Иначе любой глюк
				// приведет к непотребному виду TreeView.
				_projectTreeView.EndUpdate();
			}
		}

		#endregion

		#region Utilits

		/// <summary>
		/// Считывает список MSBuild-элементов и группирует их п типам
		/// (помещая в мап (имя типа/список элеметов этого типа)).
		/// </summary>
		/// <param name="msBuildHelper">MsBuildProjectHelper</param>
		/// <returns>мап (имя типа/список элеметов этого типа)</returns>
		private static ItemTypesMap InitItemTypesMap(MsBuildProjectHelper msBuildHelper)
		{
			ItemTypesMap itemTypesMap = new ItemTypesMap();

      foreach (ProjectItem item in msBuildHelper.GetProjectItems())
			{
				string itemType = item.ItemType;
				List<TreeNode> items = GetItemsByType(itemTypesMap, itemType);

				string nodeName = item.GetMetadataValue("Link");

				// Если у элемента нет атрибута "Link", то используем для 
				// имени ветки путь к элементу.
				if (string.IsNullOrEmpty(nodeName))
					nodeName = item.EvaluatedInclude;

				TreeNode node = new TreeNode(nodeName);
				node.Tag = item;

				items.Add(node);

				if (items.Count == 1)
					itemTypesMap[itemType] = items;
			}
			return itemTypesMap;
		}

		/// <summary>
		/// Возвращает список элементов для заданного типа. 
		/// Если список отсуствует создает новый список.
		/// </summary>
		/// <param name="itemTypesMap">
		/// Мап (имя типа/список элеметов этого типа)
		/// </param>
		/// <param name="itemType">Тип требуемых элементов</param>
		/// <returns>Список элементов заданного типа</returns>
		private static List<TreeNode> GetItemsByType(
			ItemTypesMap itemTypesMap,
			string itemType)
		{
			List<TreeNode> items;
			if (itemTypesMap.ContainsKey(itemType))
				items = itemTypesMap[itemType];
			else
				items = new List<TreeNode>();
			return items;
		}

		/// <summary>
		/// Возвращает родительскую TreeView-ветку для заданного пути.
		/// Фолдер или берется из кэша, или создается (и добавляется в кэш).
		/// </summary>
		/// <param name="typeNode">Ветка типа (корневая ветка иерархии)</param>
		/// <param name="treeMap">Кэш (мап путей/веток)</param>
		/// <param name="dir">Путь для которого нужно найти ветку</param>
		/// <returns></returns>
		private static TreeNode GetParentFolder(
			TreeNode typeNode,
			TreeMap treeMap,
			string dir)
		{
			TreeNode folder;
			if (treeMap.ContainsKey(dir))
				folder = treeMap[dir];
			else
			{
				if (dir.Length == 0)
					folder = typeNode;
				else
				{
					string[] dirs = dir.Split('\\', '/');
					if (dirs.Length == 0)
						folder = typeNode;
					else
						folder = GetFolderNode(typeNode, treeMap,
							dirs, dirs.Length);
				}
			}
			return folder;
		}

		private static TreeNode GetFolderNode(
			TreeNode parent,
			TreeMap treeMap,
			string[] dirs,
			int dirCount)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < dirCount; i++)
			{
				sb.Append(dirs[i]);
				sb.Append('\\');
			}

			string currDirName = sb.ToString();

			if (treeMap.ContainsKey(currDirName))
				return treeMap[currDirName];
			else
			{
				if (dirCount == 0)
					return parent;
				else
				{
					TreeNode ret = GetFolderNode(
						parent,
						treeMap,
						dirs,
						dirCount - 1);

					TreeNode newNode = new TreeNode(dirs[dirCount - 1]);
					treeMap.Add(currDirName, newNode);
					ret.Nodes.Add(newNode);
					return newNode;
				}
			}
		}

		/// <summary>
		/// Рекурсивная сортировка веток TreeView.
		/// </summary>
		/// <param name="rootNodes">Коллекция веток подлежащая сортировке</param>
		private static void SortTreeNodes(
			TreeNodeCollection rootNodes,
			IComparer<TreeNode> comparer)
		{
			int count = rootNodes.Count;
			if (count == 0)
				return;

			// Копируем содержимое коллекции подветок в массив,
			// сортируем этот массв, очищаем коллекцию и копируем 
			// подвекти обратно в коллекцию.
			TreeNode[] nodeArray = new TreeNode[count];
			rootNodes.CopyTo(nodeArray, 0);
			Array.Sort<TreeNode>(nodeArray, comparer);
			rootNodes.Clear();
			rootNodes.AddRange(nodeArray);

			// Сортируем все подветки
			foreach (TreeNode node in nodeArray)
				SortTreeNodes(node.Nodes, comparer);
		}


		/// <summary>
		/// Чтение свойств MSBuild.
		/// </summary>
		/// <param name="msbuild">MsBuildProjectHelper</param>
		/// <param name="propertyName">Имя свойства</param>
		/// <returns></returns>
		private static string GetMSBuildPropertyValue(MsBuildProjectHelper msbuild, string propertyName)
		{
      ProjectProperty prop = msbuild.Project.GetProperty(propertyName);
			if (prop == null)
				return "";

			return prop.UnevaluatedValue;
		}

		#endregion
	}
}