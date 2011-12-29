namespace CS_Tabbed_Web_Browser
{
    partial class OptionsDialogue
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
            System.Windows.Forms.Button cancelOperationButton;
            System.Windows.Forms.Button okButton;
            System.Windows.Forms.Button useBlankAsHomePageButton;
            System.Windows.Forms.Button useCurrentAsHomePageButton;
            System.Windows.Forms.Label homePageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsDialogue));
            this.startupWithHomePageToggle = new System.Windows.Forms.CheckBox();
            this.homePageText = new System.Windows.Forms.TextBox();
            cancelOperationButton = new System.Windows.Forms.Button();
            okButton = new System.Windows.Forms.Button();
            useBlankAsHomePageButton = new System.Windows.Forms.Button();
            useCurrentAsHomePageButton = new System.Windows.Forms.Button();
            homePageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelOperationButton
            // 
            cancelOperationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            cancelOperationButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelOperationButton.Location = new System.Drawing.Point(254, 85);
            cancelOperationButton.Name = "cancelOperationButton";
            cancelOperationButton.Size = new System.Drawing.Size(75, 23);
            cancelOperationButton.TabIndex = 14;
            cancelOperationButton.Text = "Cancel";
            cancelOperationButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Location = new System.Drawing.Point(173, 85);
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.TabIndex = 13;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // startupWithHomePageToggle
            // 
            this.startupWithHomePageToggle.AutoSize = true;
            this.startupWithHomePageToggle.Location = new System.Drawing.Point(79, 62);
            this.startupWithHomePageToggle.Name = "startupWithHomePageToggle";
            this.startupWithHomePageToggle.Size = new System.Drawing.Size(153, 17);
            this.startupWithHomePageToggle.TabIndex = 12;
            this.startupWithHomePageToggle.Text = "&Load home page at startup";
            this.startupWithHomePageToggle.UseVisualStyleBackColor = true;
            // 
            // useBlankAsHomePageButton
            // 
            useBlankAsHomePageButton.Location = new System.Drawing.Point(163, 33);
            useBlankAsHomePageButton.Name = "useBlankAsHomePageButton";
            useBlankAsHomePageButton.Size = new System.Drawing.Size(75, 23);
            useBlankAsHomePageButton.TabIndex = 11;
            useBlankAsHomePageButton.Text = "Use &Blank";
            useBlankAsHomePageButton.UseVisualStyleBackColor = true;
            useBlankAsHomePageButton.Click += new System.EventHandler(this.useBlankAsHomePageButton_Click);
            // 
            // useCurrentAsHomePageButton
            // 
            useCurrentAsHomePageButton.Location = new System.Drawing.Point(79, 33);
            useCurrentAsHomePageButton.Name = "useCurrentAsHomePageButton";
            useCurrentAsHomePageButton.Size = new System.Drawing.Size(75, 23);
            useCurrentAsHomePageButton.TabIndex = 10;
            useCurrentAsHomePageButton.Text = "Use &Current";
            useCurrentAsHomePageButton.UseVisualStyleBackColor = true;
            useCurrentAsHomePageButton.Click += new System.EventHandler(this.useCurrentAsHomePageButton_Click);
            // 
            // homePageText
            // 
            this.homePageText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.homePageText.Location = new System.Drawing.Point(79, 7);
            this.homePageText.Name = "homePageText";
            this.homePageText.Size = new System.Drawing.Size(250, 20);
            this.homePageText.TabIndex = 9;
            // 
            // homePageLabel
            // 
            homePageLabel.AutoSize = true;
            homePageLabel.Location = new System.Drawing.Point(7, 10);
            homePageLabel.Name = "homePageLabel";
            homePageLabel.Size = new System.Drawing.Size(66, 13);
            homePageLabel.TabIndex = 8;
            homePageLabel.Text = "&Home Page:";
            // 
            // OptionsDialogue
            // 
            this.AcceptButton = okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = cancelOperationButton;
            this.ClientSize = new System.Drawing.Size(336, 115);
            this.Controls.Add(cancelOperationButton);
            this.Controls.Add(okButton);
            this.Controls.Add(this.startupWithHomePageToggle);
            this.Controls.Add(useBlankAsHomePageButton);
            this.Controls.Add(useCurrentAsHomePageButton);
            this.Controls.Add(this.homePageText);
            this.Controls.Add(homePageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDialogue";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsDialogue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox startupWithHomePageToggle;
        private System.Windows.Forms.TextBox homePageText;

    }
}