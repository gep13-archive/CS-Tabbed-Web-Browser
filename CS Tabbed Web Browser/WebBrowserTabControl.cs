using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS_Tabbed_Web_Browser
{
    /// <summary>
    /// A <b>TabControl</b> designed to display <see cref="WebBrowserTabPage" /> objects.
    /// </summary>
    public class WebBrowserTabControl : TabControl
    {
        #region Properties

        /// <summary>
        /// Gets the currently selected tab page.
        /// </summary>
        /// <value>
        /// The <see cref="WebBrowserTabPage" /> that is currently selected.
        /// </value>
        public WebBrowserTabPage SelectedWebBrowserTagPage
        {
            get
            {
                return (WebBrowserTabPage)this.SelectedTab;
            }
        }

        /// <summary>
        /// Gets the currently selected web browser.
        /// </summary>
        /// <value>
        /// The <b>WebBrowser</b> control on the currently selected tab page.
        /// </value>
        public WebBrowser SelectedWebBrowser
        {
            get
            {
                return this.SelectedWebBrowserTagPage.Browser;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds a new, empty page to the tab control.
        /// </summary>
        /// <returns> 
        /// The <see cref="WebBrowserTabPage" /> that was added.
        /// </returns>
        public WebBrowserTabPage AddTab()
        {
            WebBrowserTabPage tab = new WebBrowserTabPage();
            this.TabPages.Add(tab);
            this.SelectedTab = tab;
            return tab;
        }

        /// <summary>
        /// Adds a new page to the tab control and navigates to the specified address.
        /// </summary>
        /// <param name="address">
        /// The address of the page to display in the new tab.
        /// </param>
        /// <returns>
        /// The <see cref="WebBrowserTabPage" /> that was added.
        /// </returns>
        public WebBrowserTabPage AddTab(string address)
        {
            WebBrowserTabPage tab = this.AddTab();
            tab.Browser.Navigate(address);
            return tab;
        }

        /// <summary>
        /// Removes the currently selected tab from the tab control.
        /// </summary>
        /// <returns>
        /// <b>True</b> if the current tab was removed; otherwise, <b>False</b>.
        /// </returns>
        /// <remarks>
        /// There must always be at least one tab so the last tab cannot be removed.
        /// </remarks>
        public bool RemoveCurrentTab()
        {
            bool canRemove = this.TabCount > 1;

            if (canRemove)
            {
                WebBrowserTabPage tab = this.SelectedWebBrowserTagPage;
                this.TabPages.Remove(tab);
                tab.Dispose();
            }

            return canRemove;
        }

        #endregion
    }
}