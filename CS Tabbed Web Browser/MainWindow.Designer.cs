namespace CS_Tabbed_Web_Browser
{
    partial class MainWindow
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
            System.Windows.Forms.ToolStripSeparator toolbarSeparator1;
            System.Windows.Forms.ToolStripSeparator toolbarSeparator2;
            System.Windows.Forms.ToolStripLabel addressLabel;
            System.Windows.Forms.ToolStripMenuItem openMenuItem;
            System.Windows.Forms.ToolStripButton homeButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.ToolStripButton newTabButton;
            System.Windows.Forms.ToolStripMenuItem exitMenuItem;
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            this.forwardButton = new System.Windows.Forms.ToolStripButton();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.stopButton = new System.Windows.Forms.ToolStripButton();
            this.closeTabButton = new System.Windows.Forms.ToolStripButton();
            this.addressCombo = new System.Windows.Forms.ToolStripComboBox();
            this.goButton = new System.Windows.Forms.ToolStripButton();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.browserStatusTextLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pageLoadProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tabs = new CS_Tabbed_Web_Browser.WebBrowserTabControl();
            toolbarSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolbarSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            addressLabel = new System.Windows.Forms.ToolStripLabel();
            openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            homeButton = new System.Windows.Forms.ToolStripButton();
            newTabButton = new System.Windows.Forms.ToolStripButton();
            exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.statusbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbarSeparator1
            // 
            toolbarSeparator1.Name = "toolbarSeparator1";
            toolbarSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolbarSeparator2
            // 
            toolbarSeparator2.Name = "toolbarSeparator2";
            toolbarSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // addressLabel
            // 
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(52, 22);
            addressLabel.Text = "Address:";
            // 
            // openMenuItem
            // 
            openMenuItem.Enabled = false;
            openMenuItem.Name = "openMenuItem";
            openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openMenuItem.Size = new System.Drawing.Size(164, 22);
            openMenuItem.Text = "&Open...";
            openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // homeButton
            // 
            homeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            homeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            homeButton.Name = "homeButton";
            homeButton.Size = new System.Drawing.Size(23, 22);
            homeButton.Text = "Home";
            homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // newTabButton
            // 
            newTabButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            newTabButton.Image = ((System.Drawing.Image)(resources.GetObject("newTabButton.Image")));
            newTabButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            newTabButton.Name = "newTabButton";
            newTabButton.Size = new System.Drawing.Size(23, 22);
            newTabButton.Text = "New Tab";
            newTabButton.ToolTipText = "New Tab";
            newTabButton.Click += new System.EventHandler(this.newTabButton_Click);
            // 
            // exitMenuItem
            // 
            exitMenuItem.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.exitMenuItem_Image;
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new System.Drawing.Size(164, 22);
            exitMenuItem.Text = "E&xit";
            exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.viewMenuItem,
            this.historyMenuItem,
            this.toolsMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(896, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabMenuItem,
            openMenuItem,
            this.closeTabMenuItem,
            this.fileMenuSeparator1,
            exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "&File";
            // 
            // newTabMenuItem
            // 
            this.newTabMenuItem.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.newTabMenuItem_Image;
            this.newTabMenuItem.Name = "newTabMenuItem";
            this.newTabMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newTabMenuItem.Size = new System.Drawing.Size(164, 22);
            this.newTabMenuItem.Text = "&New Tab";
            this.newTabMenuItem.Click += new System.EventHandler(this.newTabMenuItem_Click);
            // 
            // closeTabMenuItem
            // 
            this.closeTabMenuItem.Enabled = false;
            this.closeTabMenuItem.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.closeTabMenuItem_Image;
            this.closeTabMenuItem.Name = "closeTabMenuItem";
            this.closeTabMenuItem.Size = new System.Drawing.Size(164, 22);
            this.closeTabMenuItem.Text = "&Close Tab";
            this.closeTabMenuItem.Click += new System.EventHandler(this.closeTabMenuItem_Click);
            // 
            // fileMenuSeparator1
            // 
            this.fileMenuSeparator1.Name = "fileMenuSeparator1";
            this.fileMenuSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshMenuItem,
            this.stopMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewMenuItem.Text = "&View";
            // 
            // refreshMenuItem
            // 
            this.refreshMenuItem.Enabled = false;
            this.refreshMenuItem.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.refreshMenuItem_Image;
            this.refreshMenuItem.Name = "refreshMenuItem";
            this.refreshMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.refreshMenuItem.Size = new System.Drawing.Size(154, 22);
            this.refreshMenuItem.Text = "&Refresh";
            this.refreshMenuItem.Click += new System.EventHandler(this.refreshMenuItem_Click);
            // 
            // stopMenuItem
            // 
            this.stopMenuItem.Enabled = false;
            this.stopMenuItem.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.stopMenuItem_Image;
            this.stopMenuItem.Name = "stopMenuItem";
            this.stopMenuItem.Size = new System.Drawing.Size(154, 22);
            this.stopMenuItem.Text = "&Stop";
            this.stopMenuItem.Click += new System.EventHandler(this.stopMenuItem_Click);
            // 
            // historyMenuItem
            // 
            this.historyMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backMenuItem,
            this.forwardMenuItem,
            this.homeMenuItem});
            this.historyMenuItem.Name = "historyMenuItem";
            this.historyMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyMenuItem.Text = "Hi&story";
            // 
            // backMenuItem
            // 
            this.backMenuItem.Enabled = false;
            this.backMenuItem.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.backMenuItem_Image;
            this.backMenuItem.Name = "backMenuItem";
            this.backMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.backMenuItem.Size = new System.Drawing.Size(179, 22);
            this.backMenuItem.Text = "&Back";
            this.backMenuItem.Click += new System.EventHandler(this.backMenuItem_Click);
            // 
            // forwardMenuItem
            // 
            this.forwardMenuItem.Enabled = false;
            this.forwardMenuItem.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.forwardMenuItem_Image;
            this.forwardMenuItem.Name = "forwardMenuItem";
            this.forwardMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.forwardMenuItem.Size = new System.Drawing.Size(179, 22);
            this.forwardMenuItem.Text = "For&ward";
            this.forwardMenuItem.Click += new System.EventHandler(this.forwardMenuItem_Click);
            // 
            // homeMenuItem
            // 
            this.homeMenuItem.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.homeMenuItem_Image;
            this.homeMenuItem.Name = "homeMenuItem";
            this.homeMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.homeMenuItem.Size = new System.Drawing.Size(179, 22);
            this.homeMenuItem.Text = "H&ome";
            this.homeMenuItem.Click += new System.EventHandler(this.homeMenuItem_Click);
            // 
            // toolsMenuItem
            // 
            this.toolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsMenuItem});
            this.toolsMenuItem.Name = "toolsMenuItem";
            this.toolsMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsMenuItem.Text = "&Tools";
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.optionsMenuItem_Image;
            this.optionsMenuItem.Name = "optionsMenuItem";
            this.optionsMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsMenuItem.Text = "&Options...";
            this.optionsMenuItem.Click += new System.EventHandler(this.optionsMenuItem_Click);
            // 
            // toolbar
            // 
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backButton,
            this.forwardButton,
            this.refreshButton,
            this.stopButton,
            homeButton,
            toolbarSeparator1,
            newTabButton,
            this.closeTabButton,
            toolbarSeparator2,
            addressLabel,
            this.addressCombo,
            this.goButton});
            this.toolbar.Location = new System.Drawing.Point(0, 24);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(896, 25);
            this.toolbar.TabIndex = 1;
            this.toolbar.Text = "toolStrip1";
            // 
            // backButton
            // 
            this.backButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backButton.Enabled = false;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(23, 22);
            this.backButton.Text = "Back";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardButton.Enabled = false;
            this.forwardButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardButton.Image")));
            this.forwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(23, 22);
            this.forwardButton.Text = "Forward";
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshButton.Enabled = false;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(23, 22);
            this.refreshButton.Text = "Refresh";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopButton.Enabled = false;
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(23, 22);
            this.stopButton.Text = "Text";
            this.stopButton.ToolTipText = "Stop";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // closeTabButton
            // 
            this.closeTabButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeTabButton.Enabled = false;
            this.closeTabButton.Image = ((System.Drawing.Image)(resources.GetObject("closeTabButton.Image")));
            this.closeTabButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeTabButton.Name = "closeTabButton";
            this.closeTabButton.Size = new System.Drawing.Size(23, 22);
            this.closeTabButton.Text = "Close Tab";
            this.closeTabButton.ToolTipText = "Close Tab";
            this.closeTabButton.Click += new System.EventHandler(this.closeTabButton_Click);
            // 
            // addressCombo
            // 
            this.addressCombo.AutoSize = false;
            this.addressCombo.Name = "addressCombo";
            this.addressCombo.Size = new System.Drawing.Size(510, 23);
            this.addressCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressCombo_KeyDown);
            // 
            // goButton
            // 
            this.goButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goButton.Image = ((System.Drawing.Image)(resources.GetObject("goButton.Image")));
            this.goButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(23, 22);
            this.goButton.Text = "Go";
            this.goButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.goButton.ToolTipText = "Go";
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // statusbar
            // 
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browserStatusTextLabel,
            this.pageLoadProgress});
            this.statusbar.Location = new System.Drawing.Point(0, 544);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(896, 22);
            this.statusbar.TabIndex = 2;
            this.statusbar.Text = "statusStrip1";
            // 
            // browserStatusTextLabel
            // 
            this.browserStatusTextLabel.Name = "browserStatusTextLabel";
            this.browserStatusTextLabel.Size = new System.Drawing.Size(881, 17);
            this.browserStatusTextLabel.Spring = true;
            this.browserStatusTextLabel.Text = "toolStripStatusLabel1";
            this.browserStatusTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pageLoadProgress
            // 
            this.pageLoadProgress.Name = "pageLoadProgress";
            this.pageLoadProgress.Size = new System.Drawing.Size(100, 16);
            this.pageLoadProgress.Visible = false;
            this.pageLoadProgress.VisibleChanged += new System.EventHandler(this.pageLoadProgress_VisibleChanged);
            // 
            // tabs
            // 
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 49);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(896, 495);
            this.tabs.TabIndex = 3;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 566);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainWindow";
            this.Text = "Tabbed Web Browser";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenuItem;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton backButton;
        private System.Windows.Forms.ToolStripButton forwardButton;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ToolStripButton stopButton;
        private System.Windows.Forms.ToolStripButton closeTabButton;
        private System.Windows.Forms.ToolStripComboBox addressCombo;
        private System.Windows.Forms.ToolStripButton goButton;
        private System.Windows.Forms.StatusStrip statusbar;
        private WebBrowserTabControl tabs;
        private System.Windows.Forms.ToolStripMenuItem newTabMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTabMenuItem;
        private System.Windows.Forms.ToolStripSeparator fileMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem refreshMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forwardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel browserStatusTextLabel;
        private System.Windows.Forms.ToolStripProgressBar pageLoadProgress;
    }
}