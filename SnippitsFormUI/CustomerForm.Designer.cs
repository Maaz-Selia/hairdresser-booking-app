namespace SnippitsFormUI
{
    partial class CustomerForm
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
            this.CustomerFirstName = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.CustomerSurname = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.CustomerEmail = new System.Windows.Forms.TextBox();
            this.CustomerNumber = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.appointmentsLabel = new System.Windows.Forms.Label();
            this.appointmentsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CustomerFirstName
            // 
            this.CustomerFirstName.Location = new System.Drawing.Point(96, 12);
            this.CustomerFirstName.Name = "CustomerFirstName";
            this.CustomerFirstName.Size = new System.Drawing.Size(114, 20);
            this.CustomerFirstName.TabIndex = 0;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(33, 15);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(216, 15);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(49, 13);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Surname";
            // 
            // CustomerSurname
            // 
            this.CustomerSurname.Location = new System.Drawing.Point(271, 12);
            this.CustomerSurname.Name = "CustomerSurname";
            this.CustomerSurname.Size = new System.Drawing.Size(124, 20);
            this.CustomerSurname.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.cancelButton.Location = new System.Drawing.Point(319, 210);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(238, 210);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 5;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(58, 41);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.Location = new System.Drawing.Point(96, 38);
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.Size = new System.Drawing.Size(299, 20);
            this.CustomerEmail.TabIndex = 7;
            // 
            // CustomerNumber
            // 
            this.CustomerNumber.Location = new System.Drawing.Point(96, 63);
            this.CustomerNumber.Name = "CustomerNumber";
            this.CustomerNumber.Size = new System.Drawing.Size(299, 20);
            this.CustomerNumber.TabIndex = 8;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(12, 66);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneNumberLabel.TabIndex = 9;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // appointmentsLabel
            // 
            this.appointmentsLabel.AutoSize = true;
            this.appointmentsLabel.Location = new System.Drawing.Point(19, 89);
            this.appointmentsLabel.Name = "appointmentsLabel";
            this.appointmentsLabel.Size = new System.Drawing.Size(71, 13);
            this.appointmentsLabel.TabIndex = 10;
            this.appointmentsLabel.Text = "Appointments";
            // 
            // appointmentsListBox
            // 
            this.appointmentsListBox.FormattingEnabled = true;
            this.appointmentsListBox.Location = new System.Drawing.Point(14, 107);
            this.appointmentsListBox.Margin = new System.Windows.Forms.Padding(5);
            this.appointmentsListBox.Name = "appointmentsListBox";
            this.appointmentsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.appointmentsListBox.Size = new System.Drawing.Size(380, 95);
            this.appointmentsListBox.TabIndex = 11;
            // 
            // CustomerForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(409, 247);
            this.Controls.Add(this.appointmentsListBox);
            this.Controls.Add(this.appointmentsLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.CustomerNumber);
            this.Controls.Add(this.CustomerEmail);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.CustomerSurname);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.CustomerFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerForm";
            this.Text = "Customer Details Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustomerFirstName;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox CustomerSurname;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox CustomerEmail;
        private System.Windows.Forms.TextBox CustomerNumber;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label appointmentsLabel;
        private System.Windows.Forms.ListBox appointmentsListBox;
    }
}