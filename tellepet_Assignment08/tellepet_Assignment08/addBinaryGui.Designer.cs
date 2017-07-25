namespace tellepet_Assignment08
{
    partial class Binary_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Binary_Calculator));
            this.txtBinaryNum1 = new System.Windows.Forms.TextBox();
            this.txtBinaryNum2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBinaryNum1
            // 
            this.txtBinaryNum1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBinaryNum1.Location = new System.Drawing.Point(13, 13);
            this.txtBinaryNum1.Name = "txtBinaryNum1";
            this.txtBinaryNum1.Size = new System.Drawing.Size(607, 20);
            this.txtBinaryNum1.TabIndex = 0;
            this.txtBinaryNum1.Text = "Enter your first binary number";
            this.txtBinaryNum1.Enter += new System.EventHandler(this.txtBinaryNum1_Enter);
            this.txtBinaryNum1.Leave += new System.EventHandler(this.txtBinaryNum1_Leave);
            // 
            // txtBinaryNum2
            // 
            this.txtBinaryNum2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBinaryNum2.Location = new System.Drawing.Point(13, 40);
            this.txtBinaryNum2.Name = "txtBinaryNum2";
            this.txtBinaryNum2.Size = new System.Drawing.Size(607, 20);
            this.txtBinaryNum2.TabIndex = 1;
            this.txtBinaryNum2.Text = "Enter your second binary number";
            this.txtBinaryNum2.Enter += new System.EventHandler(this.txtBinaryNum2_Enter);
            this.txtBinaryNum2.Leave += new System.EventHandler(this.txtBinaryNum2_Leave);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(13, 67);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BackColor = System.Drawing.SystemColors.Menu;
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(13, 97);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(607, 20);
            this.txtResult.TabIndex = 3;
            this.txtResult.Text = "Your result here!";
            // 
            // Binary_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 146);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBinaryNum2);
            this.Controls.Add(this.txtBinaryNum1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Binary_Calculator";
            this.Text = "Binary Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBinaryNum1;
        private System.Windows.Forms.TextBox txtBinaryNum2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtResult;
    }
}

