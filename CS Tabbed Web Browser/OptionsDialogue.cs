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
    public partial class OptionsDialogue : Form
    {
        #region Variables

        /// <summary>
        /// The addressed currently displayed in the browser.
        /// </summary>
        private string currentAddress;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new instance of the <see cref="OptionsDialogue" /> class.
        /// </summary>
        /// <param name="currentAddress">
        /// A <b>String</b> containing the address of the page currently displayed in the browser.
        /// </param>
        public OptionsDialogue(string currentAddress)
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call.

            this.currentAddress = currentAddress;
        }

        #endregion

        private void OptionsDialogue_Load(object sender, EventArgs e)
        {
            // Load the current options
            this.homePageText.Text = Properties.Settings.Default.HomePage;
            this.startupWithHomePageToggle.Checked = Properties.Settings.Default.StartWithHomePage;
        }

        private void useCurrentAsHomePageButton_Click(object sender, EventArgs e)
        {
            this.homePageText.Text = this.currentAddress;
        }

        private void useBlankAsHomePageButton_Click(object sender, EventArgs e)
        {
            this.homePageText.Clear();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Save the new settings
            Properties.Settings.Default.HomePage = this.homePageText.Text;
            Properties.Settings.Default.StartWithHomePage = this.startupWithHomePageToggle.Checked;
            Properties.Settings.Default.Save();
        }

        #region Event Handlers



        #endregion
    }
}
