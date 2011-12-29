using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS_Tabbed_Web_Browser
{
    /// <summary>
    /// The main window for the tabbed web browser application.
    /// </summary>
    public partial class MainWindow : Form
    {
        #region Variables

        /// <summary>
        /// The difference in width between the window and the address field in the tool bar.
        /// </summary>
        private readonly int addressFieldSizeOffset;

        /// <summary>
        /// The <b>WebBrowser</b> control on the current tab.
        /// </summary>
        private WebBrowser currentBrowser;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new instance of the <see cref="MainWindow" /> class.
        /// </summary>
        public MainWindow()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call.

            // Get the initial difference between the form width and address field width.
            // This value will be maintained as the window width changes.
            this.addressFieldSizeOffset = this.Width - this.addressCombo.Width;
        }

        #endregion

        #region Event Handlers

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Add the default Tab
            this.tabs.AddTab();
            this.currentBrowser = this.tabs.SelectedWebBrowser;

            if (Properties.Settings.Default.StartWithHomePage && !string.IsNullOrEmpty(Properties.Settings.Default.HomePage))
            {
                // Load the home page.
                this.currentBrowser.Navigate(Properties.Settings.Default.HomePage);
            }

            this.currentBrowser.StatusTextChanged += new EventHandler(currentBrowser_StatusTextChanged);
            this.currentBrowser.Navigated += new WebBrowserNavigatedEventHandler(currentBrowser_Navigated);
            this.currentBrowser.CanGoBackChanged += new EventHandler(currentBrowser_CanGoBackChanged);
            this.currentBrowser.CanGoForwardChanged += new EventHandler(currentBrowser_CanGoForwardChanged);
            this.currentBrowser.ProgressChanged += new WebBrowserProgressChangedEventHandler(currentBrowser_ProgressChanged);
            this.currentBrowser.DocumentTitleChanged += new EventHandler(currentBrowser_DocumentTitleChanged);
            this.currentBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(currentBrowser_DocumentCompleted);
        }

        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            if (this.addressFieldSizeOffset > 0)
            {
                // Maintain the original width difference between the form and the address
                // without allowing the address field to become less than 100 pixels wide.
                this.addressCombo.Width = Math.Max(50, this.Width - this.addressFieldSizeOffset);
            }
        }

        private void addressCombo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Navigate to the current address.
                this.currentBrowser.Navigate(this.addressCombo.Text);

                // Prevent the sound that indicates an invalid key press.
                e.SuppressKeyPress = true;
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // Navigate to the current address.
            this.currentBrowser.Navigate(this.addressCombo.Text);
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the current browser.
            this.currentBrowser = this.tabs.SelectedWebBrowser;

            this.DisplayPageTitle();

            // Enable the Close Tab command if and only if there is more than one tab.
            if (this.tabs.TabCount == 1)
            {
                this.closeTabMenuItem.Enabled = false;
                this.closeTabButton.Enabled = false;
            }
            else
            {
                this.closeTabMenuItem.Enabled = true;
                this.closeTabButton.Enabled = true;
            }

            Uri url = this.currentBrowser.Url;

            if (url == null)
            {
                // There is no current address.
                this.addressCombo.Text = string.Empty;

                // The user cannot refresh a page that doesn't exist.
                this.refreshMenuItem.Enabled = false;
                this.refreshButton.Enabled = false;
            }
            else
            {
                // Display the current page address in the address bar.
                this.addressCombo.Text = url.ToString();

                // Allow the user to refresh the current page.
                this.refreshMenuItem.Enabled = true;
                this.refreshButton.Enabled = true;
            }

            // Display the current page's status text in the status bar.
            this.browserStatusTextLabel.Text = this.currentBrowser.StatusText;

            WebBrowserTabPage tab = this.tabs.SelectedWebBrowserTagPage;
            long lastCurrentProgress = tab.LastCurrentProgress;
            long lastMaximumProgress = tab.LastMaximumProgress;

            if (lastMaximumProgress > 0L && lastCurrentProgress > 0L)
            {
                // Display the current progress.
                this.pageLoadProgress.Visible = true;
                this.pageLoadProgress.Value = (int)Math.Round(((double)(100 * lastCurrentProgress / lastMaximumProgress)));
            }
            else
            {
                // Hide and reset the progress bar
                this.pageLoadProgress.Visible = false;
                this.pageLoadProgress.Value = 0;
            }
        }

        private void pageLoadProgress_VisibleChanged(object sender, EventArgs e)
        {
            bool canStop = this.pageLoadProgress.Visible;

            // The loading can only be stopped when a page is loading.
            this.stopMenuItem.Enabled = canStop;
            this.stopButton.Enabled = canStop;
        }

        #region Main Menu Event Handlers

        #region File Menu Event Handler

        private void newTabMenuItem_Click(object sender, EventArgs e)
        {
            this.tabs.AddTab();
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Prompt to open an address in the current tab.
        }

        private void closeTabMenuItem_Click(object sender, EventArgs e)
        {
            this.tabs.RemoveCurrentTab();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region View Menu Event Handler

        private void refreshMenuItem_Click(object sender, EventArgs e)
        {
            this.currentBrowser.Refresh();

            this.pageLoadProgress.Visible = true;
        }

        private void stopMenuItem_Click(object sender, EventArgs e)
        {
            this.currentBrowser.Stop();
        }

        #endregion

        #region History Menu Event Handler

        private void backMenuItem_Click(object sender, EventArgs e)
        {
            this.currentBrowser.GoBack();
        }

        private void forwardMenuItem_Click(object sender, EventArgs e)
        {
            this.currentBrowser.GoForward();
        }

        private void homeMenuItem_Click(object sender, EventArgs e)
        {
            this.currentBrowser.Navigate(Properties.Settings.Default.HomePage);
        }

        #endregion

        #region Tools Menu Event Handler

        private void optionsMenuItem_Click(object sender, EventArgs e)
        {
            using(OptionsDialogue dialogue = new OptionsDialogue(this.currentBrowser.Url.ToString()))
            {
                dialogue.ShowDialog();
            }
        }

        #endregion

        #endregion

        #region Toolbar Event Handlers

        private void backButton_Click(object sender, EventArgs e)
        {
            this.backMenuItem.PerformClick();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            this.forwardMenuItem.PerformClick();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.refreshMenuItem.PerformClick();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.stopMenuItem.PerformClick();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.homeMenuItem.PerformClick();
        }

        private void newTabButton_Click(object sender, EventArgs e)
        {
            this.newTabMenuItem.PerformClick();
        }

        private void closeTabButton_Click(object sender, EventArgs e)
        {
            this.closeTabMenuItem.PerformClick();
        }

        #endregion

        #region Web Browser Event Handlers

        private void currentBrowser_StatusTextChanged(object sender, EventArgs e)
        {
            // Display the current page's status text in the status bar.
            this.browserStatusTextLabel.Text = this.currentBrowser.StatusText;
        }

        private void currentBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            // Display the progress bar.
            this.pageLoadProgress.Visible = true;

            // Display the current page address in the address bar.
            this.addressCombo.Text = this.currentBrowser.Url.ToString();
        }

        private void currentBrowser_CanGoBackChanged(object sender, EventArgs e)
        {
            bool canGoBack = this.currentBrowser.CanGoBack;

            this.backButton.Enabled = canGoBack;
            this.backMenuItem.Enabled = canGoBack;
        }

        private void currentBrowser_CanGoForwardChanged(object sender, EventArgs e)
        {
            bool canGoForward = this.currentBrowser.CanGoForward;

            this.forwardButton.Enabled = canGoForward;
            this.forwardMenuItem.Enabled = canGoForward;
        }

        private void currentBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            this.pageLoadProgress.Visible = true;

            if (e.MaximumProgress > 0L && e.CurrentProgress > 0L)
            {
                // Display the current progress.
                this.pageLoadProgress.Value = (int)Math.Round(((double)(100 * e.CurrentProgress / e.MaximumProgress)));
            }
            else if(e.MaximumProgress == 0L && e.CurrentProgress == 0L)
            {
                // Hide and reset the progress bar.
                this.pageLoadProgress.Visible = false;
                this.pageLoadProgress.Value = 0;
            }
        }

        private void currentBrowser_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.DisplayPageTitle();
        }

        private void currentBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.refreshMenuItem.Enabled = true;
            this.refreshButton.Enabled = true;
        }

        #endregion

        #endregion

        #region Methods

        /// <summary>
        /// Displays the current page title in the title bar.
        /// </summary>
        /// <remarks>
        /// Only the application name is displayed if no document is loaded.
        /// </remarks>
        private void DisplayPageTitle()
        {
            string documentTitle = this.currentBrowser.DocumentTitle;

            if (string.IsNullOrEmpty(documentTitle))
            {
                this.Text = Application.ProductName;
            }
            else
            {
                // Display the current page title in the window's title bar.
                this.Text = String.Format("{0} - {1}", documentTitle, Application.ProductName);
            }
        }

        #endregion
    }
}
