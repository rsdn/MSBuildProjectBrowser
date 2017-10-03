namespace MSBuildProjectBrowser
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
      this._nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this._valueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this._finalValueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.panel1 = new System.Windows.Forms.Panel();
      this._expansionResultTextBox = new System.Windows.Forms.TextBox();
      this._stringToExpandTextBox = new System.Windows.Forms.TextBox();
      this._clearAllButton = new System.Windows.Forms.Button();
      this._clearPropertyNamePrefixFilterTextButton = new System.Windows.Forms.Button();
      this._clearValueContentFilterButton = new System.Windows.Forms.Button();
      this._valueContentFilterTextBox = new System.Windows.Forms.TextBox();
      this._propertyNamePrefixFilterTextBox = new System.Windows.Forms.TextBox();
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
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this._leftTabControl.SuspendLayout();
      this._itemsTabPage.SuspendLayout();
      this._propertiesTabPage.SuspendLayout();
      this.panel1.SuspendLayout();
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
      this._projectTreeView.LabelEdit = true;
      this._projectTreeView.Location = new System.Drawing.Point(3, 3);
      this._projectTreeView.Name = "_projectTreeView";
      this._projectTreeView.SelectedImageIndex = 0;
      this._projectTreeView.Size = new System.Drawing.Size(913, 497);
      this._projectTreeView.TabIndex = 0;
      this._projectTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this._projectTreeView_AfterSelect);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "folder_vs_24.bmp");
      this.imageList1.Images.SetKeyName(1, "class_vs_24.bmp");
      this.imageList1.Images.SetKeyName(2, "property_vs_24.bmp");
      this.imageList1.Images.SetKeyName(3, "open_project_vs_24.bmp");
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this._leftTabControl);
      this.splitContainer1.Panel1.Controls.Add(this.panel1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this._rightTabControl);
      this.splitContainer1.Size = new System.Drawing.Size(1358, 611);
      this.splitContainer1.SplitterDistance = 927;
      this.splitContainer1.TabIndex = 1;
      this.splitContainer1.Text = "splitContainer1";
      // 
      // _leftTabControl
      // 
      this._leftTabControl.Controls.Add(this._itemsTabPage);
      this._leftTabControl.Controls.Add(this._propertiesTabPage);
      this._leftTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this._leftTabControl.Location = new System.Drawing.Point(0, 82);
      this._leftTabControl.Name = "_leftTabControl";
      this._leftTabControl.SelectedIndex = 0;
      this._leftTabControl.Size = new System.Drawing.Size(927, 529);
      this._leftTabControl.TabIndex = 1;
      // 
      // _itemsTabPage
      // 
      this._itemsTabPage.Controls.Add(this._projectTreeView);
      this._itemsTabPage.Location = new System.Drawing.Point(4, 22);
      this._itemsTabPage.Name = "_itemsTabPage";
      this._itemsTabPage.Padding = new System.Windows.Forms.Padding(3);
      this._itemsTabPage.Size = new System.Drawing.Size(919, 503);
      this._itemsTabPage.TabIndex = 0;
      this._itemsTabPage.Text = "Items";
      // 
      // _propertiesTabPage
      // 
      this._propertiesTabPage.Controls.Add(this._propertiesListView);
      this._propertiesTabPage.Location = new System.Drawing.Point(4, 22);
      this._propertiesTabPage.Name = "_propertiesTabPage";
      this._propertiesTabPage.Padding = new System.Windows.Forms.Padding(3);
      this._propertiesTabPage.Size = new System.Drawing.Size(919, 503);
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
      this._propertiesListView.Size = new System.Drawing.Size(913, 497);
      this._propertiesListView.SmallImageList = this.imageList1;
      this._propertiesListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
      this._propertiesListView.TabIndex = 0;
      this._propertiesListView.UseCompatibleStateImageBehavior = false;
      this._propertiesListView.View = System.Windows.Forms.View.Details;
      this._propertiesListView.SelectedIndexChanged += new System.EventHandler(this._propertiesListView_SelectedIndexChanged);
      // 
      // _nameColumnHeader
      // 
      this._nameColumnHeader.Text = "Name";
      this._nameColumnHeader.Width = 374;
      // 
      // _valueColumnHeader
      // 
      this._valueColumnHeader.Text = "UnevaluatedValue";
      this._valueColumnHeader.Width = 182;
      // 
      // _finalValueColumnHeader
      // 
      this._finalValueColumnHeader.Text = "EvaluatedValue";
      this._finalValueColumnHeader.Width = 319;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this._expansionResultTextBox);
      this.panel1.Controls.Add(this._stringToExpandTextBox);
      this.panel1.Controls.Add(this._clearAllButton);
      this.panel1.Controls.Add(this._clearPropertyNamePrefixFilterTextButton);
      this.panel1.Controls.Add(this._clearValueContentFilterButton);
      this.panel1.Controls.Add(this._valueContentFilterTextBox);
      this.panel1.Controls.Add(this._propertyNamePrefixFilterTextBox);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(927, 82);
      this.panel1.TabIndex = 2;
      // 
      // _expansionResultTextBox
      // 
      this._expansionResultTextBox.Location = new System.Drawing.Point(340, 44);
      this._expansionResultTextBox.Name = "_expansionResultTextBox";
      this._expansionResultTextBox.ReadOnly = true;
      this._expansionResultTextBox.Size = new System.Drawing.Size(580, 20);
      this._expansionResultTextBox.TabIndex = 6;
      // 
      // _stringToExpandTextBox
      // 
      this._stringToExpandTextBox.Location = new System.Drawing.Point(50, 44);
      this._stringToExpandTextBox.Name = "_stringToExpandTextBox";
      this._stringToExpandTextBox.Size = new System.Drawing.Size(284, 20);
      this._stringToExpandTextBox.TabIndex = 5;
      this._stringToExpandTextBox.TextChanged += new System.EventHandler(this._stringToExpandTextBox_TextChanged);
      // 
      // _clearAllButton
      // 
      this._clearAllButton.Location = new System.Drawing.Point(837, 0);
      this._clearAllButton.Name = "_clearAllButton";
      this._clearAllButton.Size = new System.Drawing.Size(83, 23);
      this._clearAllButton.TabIndex = 4;
      this._clearAllButton.Text = "Clear all";
      this._clearAllButton.UseVisualStyleBackColor = true;
      this._clearAllButton.Click += new System.EventHandler(this._clearAllButton_Click);
      // 
      // _clearPropertyNamePrefixFilterTextButton
      // 
      this._clearPropertyNamePrefixFilterTextButton.Location = new System.Drawing.Point(340, 0);
      this._clearPropertyNamePrefixFilterTextButton.Name = "_clearPropertyNamePrefixFilterTextButton";
      this._clearPropertyNamePrefixFilterTextButton.Size = new System.Drawing.Size(55, 23);
      this._clearPropertyNamePrefixFilterTextButton.TabIndex = 3;
      this._clearPropertyNamePrefixFilterTextButton.Text = "Clear";
      this._clearPropertyNamePrefixFilterTextButton.UseVisualStyleBackColor = true;
      this._clearPropertyNamePrefixFilterTextButton.Click += new System.EventHandler(this._clearPropertyNamePrefixFilterTextButton_Click);
      // 
      // _clearValueContentFilterButton
      // 
      this._clearValueContentFilterButton.Location = new System.Drawing.Point(767, 0);
      this._clearValueContentFilterButton.Name = "_clearValueContentFilterButton";
      this._clearValueContentFilterButton.Size = new System.Drawing.Size(55, 23);
      this._clearValueContentFilterButton.TabIndex = 2;
      this._clearValueContentFilterButton.Text = "Clear";
      this._clearValueContentFilterButton.UseVisualStyleBackColor = true;
      this._clearValueContentFilterButton.Click += new System.EventHandler(this._clearValueContentFilterButton_Click);
      // 
      // _valueContentFilterTextBox
      // 
      this._valueContentFilterTextBox.Location = new System.Drawing.Point(401, 3);
      this._valueContentFilterTextBox.Name = "_valueContentFilterTextBox";
      this._valueContentFilterTextBox.Size = new System.Drawing.Size(360, 20);
      this._valueContentFilterTextBox.TabIndex = 1;
      this._valueContentFilterTextBox.TextChanged += new System.EventHandler(this._valueContentFilterTextBox_TextChanged);
      // 
      // _propertyNamePrefixFilterTextBox
      // 
      this._propertyNamePrefixFilterTextBox.Location = new System.Drawing.Point(50, 3);
      this._propertyNamePrefixFilterTextBox.Name = "_propertyNamePrefixFilterTextBox";
      this._propertyNamePrefixFilterTextBox.Size = new System.Drawing.Size(284, 20);
      this._propertyNamePrefixFilterTextBox.TabIndex = 0;
      this._propertyNamePrefixFilterTextBox.TextChanged += new System.EventHandler(this._filterTextBox_TextChanged);
      // 
      // _rightTabControl
      // 
      this._rightTabControl.Controls.Add(this._propertyTabPage);
      this._rightTabControl.Controls.Add(this.tabPage2);
      this._rightTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this._rightTabControl.Location = new System.Drawing.Point(0, 0);
      this._rightTabControl.Name = "_rightTabControl";
      this._rightTabControl.SelectedIndex = 0;
      this._rightTabControl.Size = new System.Drawing.Size(427, 611);
      this._rightTabControl.TabIndex = 0;
      // 
      // _propertyTabPage
      // 
      this._propertyTabPage.Controls.Add(this._propertyGrid);
      this._propertyTabPage.Location = new System.Drawing.Point(4, 22);
      this._propertyTabPage.Name = "_propertyTabPage";
      this._propertyTabPage.Padding = new System.Windows.Forms.Padding(3);
      this._propertyTabPage.Size = new System.Drawing.Size(419, 585);
      this._propertyTabPage.TabIndex = 0;
      this._propertyTabPage.Text = "Property";
      // 
      // _propertyGrid
      // 
      this._propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this._propertyGrid.LineColor = System.Drawing.SystemColors.ControlDark;
      this._propertyGrid.Location = new System.Drawing.Point(3, 3);
      this._propertyGrid.Name = "_propertyGrid";
      this._propertyGrid.Size = new System.Drawing.Size(413, 579);
      this._propertyGrid.TabIndex = 1;
      // 
      // tabPage2
      // 
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(419, 585);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "...";
      // 
      // _mainMenuStrip
      // 
      this._mainMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
      this._mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem});
      this._mainMenuStrip.Location = new System.Drawing.Point(0, 0);
      this._mainMenuStrip.Name = "_mainMenuStrip";
      this._mainMenuStrip.Size = new System.Drawing.Size(1358, 24);
      this._mainMenuStrip.TabIndex = 1;
      this._mainMenuStrip.Text = "menuStrip1";
      // 
      // _fileToolStripMenuItem
      // 
      this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._openProjectToolStripMenuItem});
      this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
      this._fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this._fileToolStripMenuItem.Text = "&File";
      // 
      // _openProjectToolStripMenuItem
      // 
      this._openProjectToolStripMenuItem.Image = global::MSBuildProjectBrowser.Configuration.Resources.open_project_vs_24;
      this._openProjectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this._openProjectToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
      this._openProjectToolStripMenuItem.Name = "_openProjectToolStripMenuItem";
      this._openProjectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
      // _toolStripContainer.ContentPanel
      // 
      this._toolStripContainer.ContentPanel.Controls.Add(this.splitContainer1);
      this._toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1358, 611);
      this._toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this._toolStripContainer.Location = new System.Drawing.Point(0, 0);
      this._toolStripContainer.Name = "_toolStripContainer";
      this._toolStripContainer.Size = new System.Drawing.Size(1358, 660);
      this._toolStripContainer.TabIndex = 2;
      this._toolStripContainer.Text = "toolStripContainer1";
      // 
      // _toolStripContainer.TopToolStripPanel
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
      this._mainToolStrip.Location = new System.Drawing.Point(3, 24);
      this._mainToolStrip.Name = "_mainToolStrip";
      this._mainToolStrip.Size = new System.Drawing.Size(252, 25);
      this._mainToolStrip.TabIndex = 0;
      this._mainToolStrip.Text = "toolStrip1";
      // 
      // _openProjectToolStripButton
      // 
      this._openProjectToolStripButton.Image = global::MSBuildProjectBrowser.Configuration.Resources.open_project_vs_24;
      this._openProjectToolStripButton.ImageTransparentColor = System.Drawing.Color.White;
      this._openProjectToolStripButton.Name = "_openProjectToolStripButton";
      this._openProjectToolStripButton.Size = new System.Drawing.Size(105, 22);
      this._openProjectToolStripButton.Text = "Open project...";
      this._openProjectToolStripButton.Click += new System.EventHandler(this._openProjectToolStripButton_Click);
      // 
      // _projectConfigurationToolStripComboBox
      // 
      this._projectConfigurationToolStripComboBox.Name = "_projectConfigurationToolStripComboBox";
      this._projectConfigurationToolStripComboBox.Size = new System.Drawing.Size(100, 25);
      this._projectConfigurationToolStripComboBox.ToolTipText = "Project Configuration";
      this._projectConfigurationToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this._projectConfigurationToolStripComboBox_SelectedIndexChanged);
      // 
      // MainForm
      // 
      this.ClientSize = new System.Drawing.Size(1358, 660);
      this.Controls.Add(this._toolStripContainer);
      this.Name = "MainForm";
      this.Text = "MSBuild Profect Viewer";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this._leftTabControl.ResumeLayout(false);
      this._itemsTabPage.ResumeLayout(false);
      this._propertiesTabPage.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this._rightTabControl.ResumeLayout(false);
      this._propertyTabPage.ResumeLayout(false);
      this._mainMenuStrip.ResumeLayout(false);
      this._mainMenuStrip.PerformLayout();
      this._toolStripContainer.ContentPanel.ResumeLayout(false);
      this._toolStripContainer.TopToolStripPanel.ResumeLayout(false);
      this._toolStripContainer.TopToolStripPanel.PerformLayout();
      this._toolStripContainer.ResumeLayout(false);
      this._toolStripContainer.PerformLayout();
      this._mainToolStrip.ResumeLayout(false);
      this._mainToolStrip.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox _propertyNamePrefixFilterTextBox;
    private System.Windows.Forms.TextBox _valueContentFilterTextBox;
    private System.Windows.Forms.Button _clearValueContentFilterButton;
    private System.Windows.Forms.Button _clearPropertyNamePrefixFilterTextButton;
    private System.Windows.Forms.Button _clearAllButton;
    private System.Windows.Forms.TextBox _expansionResultTextBox;
    private System.Windows.Forms.TextBox _stringToExpandTextBox;
  }
}

