using System;
using System.Collections.Generic;
using System.Text;
//using Microsoft.Build.BuildEngine;
using Microsoft.Build;
using Microsoft.Build.Evaluation;
using System.IO;
using System.Reflection;

namespace RSharp.Compiler
{
  /// <summary>
  /// Класс предназначен для урпощения работы с MSBuild (утилитой сборки
  /// проектов).
  /// </summary>
  /// <remarks>
  /// <para>Для загрузки проекта воспользуйтесь специальным конструктором или
  /// методом LoadProjectFromFile.</para>
  /// <para>
  /// Далее можно воспользоваться свойством Project (для доступа к
  /// свойствам и содержимому проекта) или получить список файлов
  /// входящих в проект с помощью метода GetProjectFiles.</para>
  /// <para>Чтобы получить нужный список файлов и правильные значения
  /// свойств нужно сначала задать значения глобальных свойств проекта
  /// это можно сделать с помощью метода Project.SetProperty.</para>
  /// <para>Узнать список и значения доступных глобальных свойств можно
  /// с помощью Project.GlobalProperties (перебором или по имени свойства).
  /// </para>
  /// <para>Например, чтобы задать Release-конфигурацию нужно
  /// выполнить следующий код:
  /// <code>
  /// MsBuildProjectHelper msbuild = new MsBuildProjectHelper(prjPath);
  /// msbuild.Project.SetProperty("Configuration", "Release", "");
  /// </code>
  /// </para>
  /// <para>Чтобы узнать значения свойств зависящих от конфигурации можно
  /// воспользоваться свойством Project.EvaluatedProperties:
  /// <code>
  /// string defineConstants =
  ///		msbuild.Project.EvaluatedProperties["DefineConstants"].Value;
  /// </code></para>
  /// </remarks>
  public class MsBuildProjectHelper
  {
    /// <param name="prjPath">
    /// Путь к проекту или Solution MSBuild.
    /// </param>
    public MsBuildProjectHelper(string prjPath)
    {
      LoadProjectFromFile(prjPath);
    }

    /// <summary>
    /// Позволяет получить путь к сборке.
    /// </summary>
    /// <param name="assembly">
    /// Сборка пукть к которой требуется получить.
    /// </param>
    /// <returns>Пут к сборке.</returns>
    public static string GetPath(Assembly assembly)
    {
      string result = new Uri(assembly.CodeBase).LocalPath;
      return result;
    }

    /// <summary>
    /// Позволяет получить путь к каталогу .Net Framework.
    /// </summary>
    public static string GetDotNetRoot()
    {
      return Path.GetDirectoryName(GetPath(typeof(int).Assembly));
    }

    /// <summary>
    /// Загружает проект или Solutin MSBuild.
    /// </summary>
    /// <param name="prjPath">Путь к проекту</param>
    public void LoadProjectFromFile(string prjPath)
    {
      if (prjPath == null)
        throw new ArgumentNullException("prjPath");

      // Получаем путь к катлаогу где лежат dll-и с "целями" компиляции.
      string msBuildPath = GetDotNetRoot();

      // Создаем хэлпер позволющий считывать проекты.
      _project = new Project(prjPath);
    }

    private Project _project;

    /// <summary>
    /// Возвращает ссылку на загруженный проект.
    /// </summary>
    public Project Project
    {
      get { return _project; }
    }

    /// <summary>
    /// Возвращает список путей к файлам проекта заданного типа.
    /// Можно задать ноль, один или несколько типов.
    /// Если не задать тип вообще, то будут возвращены все входящие
    /// в проект элементы.
    /// При выборке осущуществляются все провекрки условий и преобразований.
    /// </summary>
    /// <param name="itemTypes">Список типов</param>
    /// <returns>Список путей к файлам.</returns>
    public IEnumerable<string> GetProjectFiles(params string[] itemTypes)
    {
      // Копируем элементы из перечисленных в itemTypes групп в массив.
      List<string> files = new List<string>(200);

      if (itemTypes == null || itemTypes.Length == 0)
        foreach (ProjectItem item in Project.AllEvaluatedItems)
          yield return item.EvaluatedInclude;
      else
        foreach (string itemType in itemTypes)
          foreach (ProjectItem item in Project.GetItemsByEvaluatedInclude(itemType))
            yield return item.EvaluatedInclude;
    }

    /// <summary>
    /// Возвращает список елементов проекта заданного типа.
    /// Можно задать ноль, один или несколько типов.
    /// Если не задать тип вообще, то будут возвращены все входящие
    /// в проект элементы.
    /// При выборке осущуществляются все провекрки условий и преобразований.
    /// <param name="itemTypes"></param>
    /// <returns></returns>
    public IEnumerable<ProjectItem> GetProjectItems(params string[] itemTypes)
    {
      // Копируем элементы из перечисленных в itemTypes групп в массив.
      List<string> files = new List<string>(200);

      if (itemTypes == null || itemTypes.Length == 0)
        foreach (ProjectItem item in Project.AllEvaluatedItems)
          yield return item;
      else
        foreach (string itemType in itemTypes)
          foreach (ProjectItem item in Project.GetItemsByEvaluatedInclude(itemType))
            yield return item;
    }
  }
}
