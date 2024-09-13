namespace SnippitsFormUI
{
    partial class StylistSelectionForm
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
            this.StylistSearch = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.addNewStylistButton = new System.Windows.Forms.Button();
            this.editStylistButton = new System.Windows.Forms.Button();
            this.StylistListBox = new System.Windows.Forms.ListBox();
            this.bookChairButton = new System.Windows.Forms.Button();
            this.StylistDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // StylistSearch
            // 
            this.StylistSearch.Location = new System.Drawing.Point(93, 12);
            this.StylistSearch.Name = "StylistSearch";
            this.StylistSearch.Size = new System.Drawing.Size(376, 20);
            this.StylistSearch.TabIndex = 9;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(12, 9);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addNewStylistButton
            // 
            this.addNewStylistButton.AutoSize = true;
            this.addNewStylistButton.Location = new System.Drawing.Point(128, 257);
            this.addNewStylistButton.Name = "addNewStylistButton";
            this.addNewStylistButton.Size = new System.Drawing.Size(97, 23);
            this.addNewStylistButton.TabIndex = 7;
            this.addNewStylistButton.Text = "Add New Stylist";
            this.addNewStylistButton.UseVisualStyleBackColor = true;
            this.addNewStylistButton.Click += new System.EventHandler(this.addNewStylistButton_Click);
            // 
            // editStylistButton
            // 
            this.editStylistButton.Location = new System.Drawing.Point(12, 257);
            this.editStylistButton.Name = "editStylistButton";
            this.editStylistButton.Size = new System.Drawing.Size(110, 23);
            this.editStylistButton.TabIndex = 6;
            this.editStylistButton.Text = "Edit Selected Stylist";
            this.editStylistButton.UseVisualStyleBackColor = true;
            this.editStylistButton.Click += new System.EventHandler(this.editStylistButton_Click);
            // 
            // StylistListBox
            // 
            this.StylistListBox.FormattingEnabled = true;
            this.StylistListBox.Location = new System.Drawing.Point(12, 37);
            this.StylistListBox.Margin = new System.Windows.Forms.Padding(5);
            this.StylistListBox.Name = "StylistListBox";
            this.StylistListBox.Size = new System.Drawing.Size(457, 212);
            this.StylistListBox.TabIndex = 5;
            // 
            // bookChairButton
            // 
            this.bookChairButton.Location = new System.Drawing.Point(380, 257);
            this.bookChairButton.Margin = new System.Windows.Forms.Padding(5);
            this.bookChairButton.Name = "bookChairButton";
            this.bookChairButton.Size = new System.Drawing.Size(89, 23);
            this.bookChairButton.TabIndex = 10;
            this.bookChairButton.Text = "Book Chair";
            this.bookChairButton.UseVisualStyleBackColor = true;
            this.bookChairButton.Click += new System.EventHandler(this.bookChairButton_Click);
            // 
            // StylistDateTime
            // 
            this.StylistDateTime.Location = new System.Drawing.Point(231, 257);
            this.StylistDateTime.MinDate = new System.DateTime(2018, 4, 25, 0, 0, 0, 0);
            this.StylistDateTime.Name = "StylistDateTime";
            this.StylistDateTime.Size = new System.Drawing.Size(143, 20);
            this.StylistDateTime.TabIndex = 11;
            this.StylistDateTime.Value = new System.DateTime(2018, 4, 25, 20, 58, 54, 0);
            // 
            // StylistSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(470, 280);
            this.Controls.Add(this.StylistDateTime);
            this.Controls.Add(this.bookChairButton);
            this.Controls.Add(this.StylistSearch);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addNewStylistButton);
            this.Controls.Add(this.editStylistButton);
            this.Controls.Add(this.StylistListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StylistSelectionForm";
            this.Text = "StylistSelectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StylistSearch;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addNewStylistButton;
        private System.Windows.Forms.Button editStylistButton;
        private System.Windows.Forms.ListBox StylistListBox;
        private System.Windows.Forms.Button bookChairButton;
        private System.Windows.Forms.DateTimePicker StylistDateTime;
    }
}