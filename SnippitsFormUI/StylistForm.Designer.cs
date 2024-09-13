namespace SnippitsFormUI
{
    partial class StylistForm
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
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.StylistNumber = new System.Windows.Forms.TextBox();
            this.StylistEmail = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.StylistSurname = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.StylistFirstName = new System.Windows.Forms.TextBox();
            this.hourlyRateLabel = new System.Windows.Forms.Label();
            this.StylistHourlyRate = new System.Windows.Forms.TextBox();
            this.transactionsLabel = new System.Windows.Forms.Label();
            this.transactionsListBox = new System.Windows.Forms.ListBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(10, 63);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneNumberLabel.TabIndex = 19;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // StylistNumber
            // 
            this.StylistNumber.Location = new System.Drawing.Point(94, 63);
            this.StylistNumber.Name = "StylistNumber";
            this.StylistNumber.Size = new System.Drawing.Size(386, 20);
            this.StylistNumber.TabIndex = 18;
            // 
            // StylistEmail
            // 
            this.StylistEmail.Location = new System.Drawing.Point(94, 37);
            this.StylistEmail.Name = "StylistEmail";
            this.StylistEmail.Size = new System.Drawing.Size(386, 20);
            this.StylistEmail.TabIndex = 17;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(56, 40);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 16;
            this.emailLabel.Text = "Email";
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(324, 310);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 15;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.cancelButton.Location = new System.Drawing.Point(405, 310);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // StylistSurname
            // 
            this.StylistSurname.Location = new System.Drawing.Point(324, 12);
            this.StylistSurname.Name = "StylistSurname";
            this.StylistSurname.Size = new System.Drawing.Size(156, 20);
            this.StylistSurname.TabIndex = 13;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(269, 15);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(49, 13);
            this.surnameLabel.TabIndex = 12;
            this.surnameLabel.Text = "Surname";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(31, 15);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 11;
            this.firstNameLabel.Text = "First Name";
            // 
            // StylistFirstName
            // 
            this.StylistFirstName.Location = new System.Drawing.Point(94, 12);
            this.StylistFirstName.Name = "StylistFirstName";
            this.StylistFirstName.Size = new System.Drawing.Size(169, 20);
            this.StylistFirstName.TabIndex = 10;
            // 
            // hourlyRateLabel
            // 
            this.hourlyRateLabel.AutoSize = true;
            this.hourlyRateLabel.Location = new System.Drawing.Point(348, 100);
            this.hourlyRateLabel.Name = "hourlyRateLabel";
            this.hourlyRateLabel.Size = new System.Drawing.Size(63, 13);
            this.hourlyRateLabel.TabIndex = 20;
            this.hourlyRateLabel.Text = "Hourly Rate";
            // 
            // StylistHourlyRate
            // 
            this.StylistHourlyRate.Location = new System.Drawing.Point(417, 97);
            this.StylistHourlyRate.Name = "StylistHourlyRate";
            this.StylistHourlyRate.Size = new System.Drawing.Size(63, 20);
            this.StylistHourlyRate.TabIndex = 21;
            // 
            // transactionsLabel
            // 
            this.transactionsLabel.AutoSize = true;
            this.transactionsLabel.Location = new System.Drawing.Point(13, 124);
            this.transactionsLabel.Name = "transactionsLabel";
            this.transactionsLabel.Size = new System.Drawing.Size(68, 13);
            this.transactionsLabel.TabIndex = 22;
            this.transactionsLabel.Text = "Transactions";
            // 
            // transactionsListBox
            // 
            this.transactionsListBox.FormattingEnabled = true;
            this.transactionsListBox.Location = new System.Drawing.Point(16, 142);
            this.transactionsListBox.Margin = new System.Windows.Forms.Padding(5);
            this.transactionsListBox.Name = "transactionsListBox";
            this.transactionsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.transactionsListBox.Size = new System.Drawing.Size(464, 160);
            this.transactionsListBox.TabIndex = 23;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(16, 309);
            this.balanceLabel.Margin = new System.Windows.Forms.Padding(5);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(52, 13);
            this.balanceLabel.TabIndex = 24;
            this.balanceLabel.Text = "Balance :";
            // 
            // StylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(505, 355);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.transactionsListBox);
            this.Controls.Add(this.transactionsLabel);
            this.Controls.Add(this.StylistHourlyRate);
            this.Controls.Add(this.hourlyRateLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.StylistNumber);
            this.Controls.Add(this.StylistEmail);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.StylistSurname);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.StylistFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StylistForm";
            this.Text = "Stylist Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox StylistNumber;
        private System.Windows.Forms.TextBox StylistEmail;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox StylistSurname;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox StylistFirstName;
        private System.Windows.Forms.Label hourlyRateLabel;
        private System.Windows.Forms.TextBox StylistHourlyRate;
        private System.Windows.Forms.Label transactionsLabel;
        private System.Windows.Forms.ListBox transactionsListBox;
        private System.Windows.Forms.Label balanceLabel;
    }
}