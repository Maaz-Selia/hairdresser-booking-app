namespace SnippitsFormUI
{
    partial class CustomerSelectionForm
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
            this.CustomerListBox = new System.Windows.Forms.ListBox();
            this.editCustomerButton = new System.Windows.Forms.Button();
            this.addNewCustomerButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.CustomerSearch = new System.Windows.Forms.TextBox();
            this.bookAppointmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerListBox
            // 
            this.CustomerListBox.FormattingEnabled = true;
            this.CustomerListBox.Location = new System.Drawing.Point(5, 32);
            this.CustomerListBox.Margin = new System.Windows.Forms.Padding(5);
            this.CustomerListBox.Name = "CustomerListBox";
            this.CustomerListBox.Size = new System.Drawing.Size(440, 212);
            this.CustomerListBox.TabIndex = 0;
            // 
            // editCustomerButton
            // 
            this.editCustomerButton.Location = new System.Drawing.Point(5, 252);
            this.editCustomerButton.Name = "editCustomerButton";
            this.editCustomerButton.Size = new System.Drawing.Size(128, 23);
            this.editCustomerButton.TabIndex = 1;
            this.editCustomerButton.Text = "Edit Selected Customer";
            this.editCustomerButton.UseVisualStyleBackColor = true;
            this.editCustomerButton.Click += new System.EventHandler(this.editCustomerButton_Click_1);
            // 
            // addNewCustomerButton
            // 
            this.addNewCustomerButton.Location = new System.Drawing.Point(139, 252);
            this.addNewCustomerButton.Name = "addNewCustomerButton";
            this.addNewCustomerButton.Size = new System.Drawing.Size(128, 23);
            this.addNewCustomerButton.TabIndex = 2;
            this.addNewCustomerButton.Text = "Add New Customer";
            this.addNewCustomerButton.UseVisualStyleBackColor = true;
            this.addNewCustomerButton.Click += new System.EventHandler(this.addNewCustomerButton_Click_1);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(5, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // CustomerSearch
            // 
            this.CustomerSearch.Location = new System.Drawing.Point(86, 6);
            this.CustomerSearch.Name = "CustomerSearch";
            this.CustomerSearch.Size = new System.Drawing.Size(358, 20);
            this.CustomerSearch.TabIndex = 4;
            // 
            // bookAppointmentButton
            // 
            this.bookAppointmentButton.Location = new System.Drawing.Point(274, 253);
            this.bookAppointmentButton.Name = "bookAppointmentButton";
            this.bookAppointmentButton.Size = new System.Drawing.Size(170, 23);
            this.bookAppointmentButton.TabIndex = 5;
            this.bookAppointmentButton.Text = " Book Appointment";
            this.bookAppointmentButton.UseVisualStyleBackColor = true;
            this.bookAppointmentButton.Click += new System.EventHandler(this.bookAppointmentButton_Click);
            // 
            // CustomerSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(461, 290);
            this.Controls.Add(this.bookAppointmentButton);
            this.Controls.Add(this.CustomerSearch);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addNewCustomerButton);
            this.Controls.Add(this.editCustomerButton);
            this.Controls.Add(this.CustomerListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerSelectionForm";
            this.Text = "CustomerSelectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CustomerListBox;
        private System.Windows.Forms.Button editCustomerButton;
        private System.Windows.Forms.Button addNewCustomerButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox CustomerSearch;
        private System.Windows.Forms.Button bookAppointmentButton;
    }
}