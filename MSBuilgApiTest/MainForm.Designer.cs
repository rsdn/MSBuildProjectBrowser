namespace MSBuilgApiTest
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this._projectTreeView = new System.Windows.Forms.TreeView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this._leftTabControl = new System.Windows.Forms.TabControl();
			this._itemsTabPage = new System.Windows.Forms.TabPage();
			this._propertiesTabPage = new System.Windows.Forms.TabPage();
			this._propertiesListView = new System.Windows.Forms.ListView();
			this._nameColumnHeader = new System.Windows.Forms.ColumnHeader("");
			this._valueColumnHeader = new System.Windows.Forms.ColumnHeader("");
			this._finalValueColumnHeader = new System.Windows.Forms.ColumnHeader("");
			this._rightTabControl = new System.Windows.Forms.TabControl();
			this._propertyTabPage = new System.Windows.Forms.TabPage();
			this._propertyGrid = new System.Windows.Forms.PropertyGrid();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this._mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._openProjectDialog = new System.Windows.Forms.OpenFileDialog();
			this._toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this._mainToolStrip = new System.Windows.Forms.ToolStrip();
			this._openProjectToolStripButton = new System.Windows.Forms.ToolStripButton();
			this._projectConfigurationToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this._leftTabControl.SuspendLayout();
			this._itemsTabPage.SuspendLayout();
			this._propertiesTabPage.SuspendLayout();
			this._rightTabControl.SuspendLayout();
			this._propertyTabPage.SuspendLayout();
			this._mainMenuStrip.SuspendLayout();
			this._toolStripContainer.ContentPanel.SuspendLayout();
			this._toolStripContainer.TopToolStripPanel.SuspendLayout();
			this._toolStripContainer.SuspendLayout();
			this._mainToolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// _projectTreeView
			// 
			this._projectTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._projectTreeView.HideSelection = false;
			this._projectTreeView.ImageIndex = 0;
			this._projectTreeView.ImageList = this.imageList1;
			this._projectTreeView.Location = new System.Drawing.Point(3, 3);
			this._projectTreeView.Name = "_projectTreeView";
			this._projectTreeView.SelectedImageIndex = 0;
			this._projectTreeView.Size = new System.Drawing.Size(292, 433);
			this._projectTreeView.TabIndex = 0;
			this._projectTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this._projectTreeView_AfterSelect);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.Images.SetKeyName(0, "folder_vs_24.bmp");
			this.imageList1.Images.SetKeyName(1, "class_vs_24.bmp");
			this.imageList1.Images.SetKeyName(2, "property_vs_24.bmp");
			this.imageList1.Images.SetKeyName(3, "open_project_vs_24.bmp");
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this._leftTabControl);
			// 
			// Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this._rightTabControl);
			this.splitContainer1.Size = new System.Drawing.Size(630, 465);
			this.splitContainer1.SplitterDistance = 306;
			this.splitContainer1.TabIndex = 1;
			this.splitContainer1.Text = "splitContainer1";
			// 
			// _leftTabControl
			// 
			this._leftTabControl.Controls.Add(this._itemsTabPage);
			this._leftTabControl.Controls.Add(this._propertiesTabPage);
			this._leftTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this._leftTabControl.Location = new System.Drawing.Point(0, 0);
			this._leftTabControl.Name = "_leftTabControl";
			this._leftTabControl.SelectedIndex = 0;
			this._leftTabControl.Size = new System.Drawing.Size(306, 465);
			this._leftTabControl.TabIndex = 1;
			// 
			// _itemsTabPage
			// 
			this._itemsTabPage.Controls.Add(this._projectTreeView);
			this._itemsTabPage.Location = new System.Drawing.Point(4, 22);
			this._itemsTabPage.Name = "_itemsTabPage";
			this._itemsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this._itemsTabPage.Size = new System.Drawing.Size(298, 439);
			this._itemsTabPage.TabIndex = 0;
			this._itemsTabPage.Text = "Items";
			// 
			// _propertiesTabPage
			// 
			this._propertiesTabPage.Controls.Add(this._propertiesListView);
			this._propertiesTabPage.Location = new System.Drawing.Point(4, 22);
			this._propertiesTabPage.Name = "_propertiesTabPage";
			this._propertiesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this._propertiesTabPage.Size = new System.Drawing.Size(298, 439);
			this._propertiesTabPage.TabIndex = 1;
			this._propertiesTabPage.Text = "Properties";
			// 
			// _propertiesListView
			// 
			this._propertiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._nameColumnHeader,
            this._valueColumnHeader,
            this._finalValueColumnHeader});
			this._propertiesListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._propertiesListView.FullRowSelect = true;
			this._propertiesListView.HideSelection = false;
			this._propertiesListView.LargeImageList = this.imageList1;
			this._propertiesListView.Location = new System.Drawing.Point(3, 3);
			this._propertiesListView.Name = "_propertiesListView";
			this._propertiesListView.ShowItemToolTips = true;
			this._propertiesListView.Size = new System.Drawing.Size(292, 433);
			this._propertiesListView.SmallImageList = this.imageList1;
			this._propertiesListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this._propertiesListView.TabIndex = 0;
			this._propertiesListView.View = System.Windows.Forms.View.Details;
			this._propertiesListView.SelectedIndexChanged += new System.EventHandler(this._propertiesListView_SelectedIndexChanged);
			// 
			// _nameColumnHeader
			// 
			this._nameColumnHeader.Text = "Name";
			this._nameColumnHeader.Width = 203;
			// 
			// _valueColumnHeader
			// 
			this._valueColumnHeader.Text = "Value";
			// 
			// _finalValueColumnHeader
			// 
			this._finalValueColumnHeader.Text = "Final Value";
			// 
			// _rightTabControl
			// 
			this._rightTabControl.Controls.Add(this._propertyTabPage);
			this._rightTabControl.Controls.Add(this.tabPage2);
			this._rightTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this._rightTabControl.Location = new System.Drawing.Point(0, 0);
			this._rightTabControl.Name = "_rightTabControl";
			this._rightTabControl.SelectedIndex = 0;
			this._rightTabControl.Size = new System.Drawing.Size(320, 465);
			this._rightTabControl.TabIndex = 0;
			// 
			// _propertyTabPage
			// 
			this._propertyTabPage.Controls.Add(this._propertyGrid);
			this._propertyTabPage.Location = new System.Drawing.Point(4, 22);
			this._propertyTabPage.Name = "_propertyTabPage";
			this._propertyTabPage.Padding = new System.Windows.Forms.Padding(3);
			this._propertyTabPage.Size = new System.Drawing.Size(312, 439);
			this._propertyTabPage.TabIndex = 0;
			this._propertyTabPage.Text = "Property";
			// 
			// _propertyGrid
			// 
			this._propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this._propertyGrid.Location = new System.Drawing.Point(3, 3);
			this._propertyGrid.Name = "_propertyGrid";
			this._propertyGrid.Size = new System.Drawing.Size(306, 433);
			this._propertyGrid.TabIndex = 1;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(312, 439);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "...";
			// 
			// _mainMenuStrip
			// 
			this._mainMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this._mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem});
			this._mainMenuStrip.Location = new System.Drawing.Point(-1, 0);
			this._mainMenuStrip.Name = "_mainMenuStrip";
			this._mainMenuStrip.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
			this._mainMenuStrip.TabIndex = 1;
			this._mainMenuStrip.Text = "menuStrip1";
			// 
			// _fileToolStripMenuItem
			// 
			this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._openProjectToolStripMenuItem});
			this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
			this._fileToolStripMenuItem.Text = "&File";
			// 
			// _openProjectToolStripMenuItem
			// 
			this._openProjectToolStripMenuItem.Image = MSBuilgApiTest.Configuration.Resources.open_project_vs_24;
			this._openProjectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._openProjectToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
			this._openProjectToolStripMenuItem.Name = "_openProjectToolStripMenuItem";
			this._openProjectToolStripMenuItem.Text = "&Open project...";
			this._openProjectToolStripMenuItem.Click += new System.EventHandler(this._openProjectToolStripMenuItem_Click);
			// 
			// _openProjectDialog
			// 
			this._openProjectDialog.DefaultExt = "*.proj";
			this._openProjectDialog.Filter = "Project files|*.*proj";
			this._openProjectDialog.Title = "Open project";
			// 
			// _toolStripContainer
			// 
			// 
			// ContentPanel
			// 
			this._toolStripContainer.ContentPanel.Controls.Add(this.splitContainer1);
			this._toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this._toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this._toolStripContainer.Name = "_toolStripContainer";
			this._toolStripContainer.Size = new System.Drawing.Size(630, 511);
			this._toolStripContainer.TabIndex = 2;
			this._toolStripContainer.Text = "toolStripContainer1";
			// 
			// TopToolStripPanel
			// 
			this._toolStripContainer.TopToolStripPanel.Controls.Add(this._mainMenuStrip);
			this._toolStripContainer.TopToolStripPanel.Controls.Add(this._mainToolStrip);
			// 
			// _mainToolStrip
			// 
			this._mainToolStrip.AllowItemReorder = true;
			this._mainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this._mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._openProjectToolStripButton,
            this._projectConfigurationToolStripComboBox});
			this._mainToolStrip.Location = new System.Drawing.Point(1, 21);
			this._mainToolStrip.Name = "_mainToolStrip";
			this._mainToolStrip.TabIndex = 0;
			this._mainToolStrip.Text = "toolStrip1";
			// 
			// _openProjectToolStripButton
			// 
			this._openProjectToolStripButton.Image = MSBuilgApiTest.Configuration.Resources.open_project_vs_24;
			this._openProjectToolStripButton.ImageTransparentColor = System.Drawing.Color.White;
			this._openProjectToolStripButton.Name = "_openProjectToolStripButton";
			this._openProjectToolStripButton.Text = "toolStripButton1";
			this._openProjectToolStripButton.Click += new System.EventHandler(this._openProjectToolStripButton_Click);
			// 
			// _projectConfigurationToolStripComboBox
			// 
			this._projectConfigurationToolStripComboBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
			this._projectConfigurationToolStripComboBox.Name = "_projectConfigurationToolStripComboBox";
			this._projectConfigurationToolStripComboBox.Size = new System.Drawing.Size(100, 25);
			this._projectConfigurationToolStripComboBox.ToolTipText = "Project Configuration";
			this._projectConfigurationToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this._projectConfigurationToolStripComboBox_SelectedIndexChanged);
			// 
			// MainForm
			// 
			this.ClientSize = new System.Drawing.Size(630, 511);
			this.Controls.Add(this._toolStripContainer);
			this.Name = "MainForm";
			this.Text = "MSBuild Profect Viewer";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this._leftTabControl.ResumeLayout(false);
			this._itemsTabPage.ResumeLayout(false);
			this._propertiesTabPage.ResumeLayout(false);
			this._rightTabControl.ResumeLayout(false);
			this._propertyTabPage.ResumeLayout(false);
			this._mainMenuStrip.ResumeLayout(false);
			this._toolStripContainer.ContentPanel.ResumeLayout(false);
			this._toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this._toolStripContainer.TopToolStripPanel.PerformLayout();
			this._toolStripContainer.ResumeLayout(false);
			this._toolStripContainer.PerformLayout();
			this._mainToolStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView _projectTreeView;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.MenuStrip _mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem _fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _openProjectToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog _openProjectDialog;
		private System.Windows.Forms.TabControl _rightTabControl;
		private System.Windows.Forms.TabPage _propertyTabPage;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.PropertyGrid _propertyGrid;
		private System.Windows.Forms.TabControl _leftTabControl;
		private System.Windows.Forms.TabPage _itemsTabPage;
		private System.Windows.Forms.TabPage _propertiesTabPage;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ListView _propertiesListView;
		private System.Windows.Forms.ColumnHeader _nameColumnHeader;
		private System.Windows.Forms.ColumnHeader _valueColumnHeader;
		private System.Windows.Forms.ColumnHeader _finalValueColumnHeader;
		private System.Windows.Forms.ToolStripContainer _toolStripContainer;
		private System.Windows.Forms.ToolStrip _mainToolStrip;
		private System.Windows.Forms.ToolStripButton _openProjectToolStripButton;
		private System.Windows.Forms.ToolStripComboBox _projectConfigurationToolStripComboBox;
	}
}

