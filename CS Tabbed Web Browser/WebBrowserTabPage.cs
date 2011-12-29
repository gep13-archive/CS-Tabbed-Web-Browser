using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS_Tabbed_Web_Browser
{
    /// <summary>
    /// A <b>TagPage</b> that displays a <b>WebBrowser</b> control.
    /// </summary>
    public class WebBrowserTabPage : TabPage
    {
        #region Constants

        private const string BLANK_PAGE_TITLE = "(Blank)";

        #endregion

        #region Variables

        /// <summary>
        /// The <b>WebBrowser</b> control displayed on the page.
        /// </summary>
        private WebBrowser _browser;

        /// <summary>
        /// The current progress at the last <b>ProgressChanged</b> event.
        /// </summary>
        private long _lastCurrentProgress;

        /// <summary>
        /// The maximum progress at the last <b>ProgressChanged</b> event.
        /// </summary>
        private long _lastMaximumProgress;

        #endregion

        #region Properties

        /// <summary>
        /// Get the <b>WebBrowser</b> control displayed on the page.
        /// </summary>
        /// <value>
        /// A <b>WebBrowser</b> object.
        /// </value>
        public WebBrowser Browser
        {
            get
            {
                return this._browser;
            }
        }

        /// <summary>
        /// Gets the current progress at the last <b>ProgressChanged</b> event.
        /// </summary>
        /// <value>
        /// A <b>Long</b> containing the last current load progress.
        /// </value>
        public long LastCurrentProgress
        {
            get
            {
                return this._lastCurrentProgress;
            }
        }

        /// <summary>
        /// Gets the maximum progress at the last <b>ProgressChanged</b> event.
        /// </summary>
        /// <value>
        /// A <b>Long</b> containing the last maximum load progress.
        /// </value>
        public long LastMaximumProgress
        {
            get
            {
                return this._lastMaximumProgress;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new instance of the <see cref="WebBrowserTabPage" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor creates and displays a new <b>WebBrowser</b> control.
        /// </remarks>
        public WebBrowserTabPage() :
            this(new WebBrowser())
        {
            this.Browser.Navigate(string.Empty);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="WebBrowserTabPage" /> class and displays the specified <b>WebBrowser</b> control.
        /// </summary>
        /// <param name="browser">
        /// The <b>WebBrowser</b> control to display on the page.
        /// </param>
        public WebBrowserTabPage(WebBrowser browser)
        {
            browser.Dock = DockStyle.Fill;
            this.Controls.Add(browser);
            this._browser = browser;
            this.DisplayPageTitle();

            this._browser.DocumentTitleChanged += new EventHandler(_browser_DocumentTitleChanged);
            this._browser.ProgressChanged += new WebBrowserProgressChangedEventHandler(_browser_ProgressChanged);
        }

        #endregion

        #region Event Handlers

        private void _browser_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.DisplayPageTitle();
        }

        private void _browser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            // Remember the last progress values for the page
            this._lastCurrentProgress = e.CurrentProgress;
            this._lastMaximumProgress = e.MaximumProgress;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Displays the current page title on the tab.
        /// </summary>
        /// <remarks>
        /// Place-holder text is used if no document is loaded.
        /// </remarks>
        private void DisplayPageTitle()
        {
            string documentTitle = this.Browser.DocumentTitle;

            if (string.IsNullOrEmpty(documentTitle))
            {
                this.Text = BLANK_PAGE_TITLE;
            }
            else
            {
                this.Text = documentTitle;
            }
        }

        #endregion
    }
}