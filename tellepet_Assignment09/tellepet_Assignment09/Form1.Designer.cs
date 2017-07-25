namespace tellepet_Assignment09
{
    partial class SpamChecker
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.diaBrowseFile = new System.Windows.Forms.OpenFileDialog();
            this.txtSpamFound = new System.Windows.Forms.TextBox();
            this.webMsg = new System.Windows.Forms.WebBrowser();
            this.btnSpam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrowse.Location = new System.Drawing.Point(13, 311);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseMnemonic = false;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtSpamFound
            // 
            this.txtSpamFound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpamFound.Location = new System.Drawing.Point(13, 13);
            this.txtSpamFound.Multiline = true;
            this.txtSpamFound.Name = "txtSpamFound";
            this.txtSpamFound.Size = new System.Drawing.Size(550, 23);
            this.txtSpamFound.TabIndex = 1;
            // 
            // webMsg
            // 
            this.webMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webMsg.Location = new System.Drawing.Point(13, 42);
            this.webMsg.MinimumSize = new System.Drawing.Size(20, 20);
            this.webMsg.Name = "webMsg";
            this.webMsg.Size = new System.Drawing.Size(550, 263);
            this.webMsg.TabIndex = 2;
            // 
            // btnSpam
            // 
            this.btnSpam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSpam.Location = new System.Drawing.Point(94, 311);
            this.btnSpam.Name = "btnSpam";
            this.btnSpam.Size = new System.Drawing.Size(75, 23);
            this.btnSpam.TabIndex = 3;
            this.btnSpam.Text = "SpamCheck";
            this.btnSpam.UseVisualStyleBackColor = true;
            this.btnSpam.Click += new System.EventHandler(this.btnSpam_Click);
            // 
            // SpamChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 346);
            this.Controls.Add(this.btnSpam);
            this.Controls.Add(this.webMsg);
            this.Controls.Add(this.txtSpamFound);
            this.Controls.Add(this.btnBrowse);
            this.Name = "SpamChecker";
            this.Text = "Spam Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog diaBrowseFile;
        private System.Windows.Forms.TextBox txtSpamFound;
        private System.Windows.Forms.WebBrowser webMsg;
        private System.Windows.Forms.Button btnSpam;
    }
}

