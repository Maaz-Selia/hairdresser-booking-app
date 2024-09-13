namespace SnippitsFormUI
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
            this.customersButton = new System.Windows.Forms.Button();
            this.stylistsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customersButton
            // 
            this.customersButton.Location = new System.Drawing.Point(14, 5);
            this.customersButton.Margin = new System.Windows.Forms.Padding(5);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(353, 110);
            this.customersButton.TabIndex = 0;
            this.customersButton.Text = "Customers";
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // stylistsButton
            // 
            this.stylistsButton.Location = new System.Drawing.Point(14, 125);
            this.stylistsButton.Margin = new System.Windows.Forms.Padding(5);
            this.stylistsButton.Name = "stylistsButton";
            this.stylistsButton.Size = new System.Drawing.Size(353, 111);
            this.stylistsButton.TabIndex = 1;
            this.stylistsButton.Text = "Stylists";
            this.stylistsButton.UseVisualStyleBackColor = true;
            this.stylistsButton.Click += new System.EventHandler(this.stylistsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(381, 250);
            this.Controls.Add(this.stylistsButton);
            this.Controls.Add(this.customersButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Snippits";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button stylistsButton;
    }
}

