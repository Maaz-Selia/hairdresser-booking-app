namespace SnippitsFormUI
{
    partial class BookAppointmentForm
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stylistComboBox = new System.Windows.Forms.ComboBox();
            this.availableAppointmentsListBox = new System.Windows.Forms.ListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.bookAppointmentButton = new System.Windows.Forms.Button();
            this.appointmentLengthComboBox = new System.Windows.Forms.ComboBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(13, 13);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // stylistComboBox
            // 
            this.stylistComboBox.FormattingEnabled = true;
            this.stylistComboBox.Location = new System.Drawing.Point(220, 13);
            this.stylistComboBox.Name = "stylistComboBox";
            this.stylistComboBox.Size = new System.Drawing.Size(164, 21);
            this.stylistComboBox.TabIndex = 1;
            // 
            // availableAppointmentsListBox
            // 
            this.availableAppointmentsListBox.FormattingEnabled = true;
            this.availableAppointmentsListBox.Location = new System.Drawing.Point(13, 40);
            this.availableAppointmentsListBox.Name = "availableAppointmentsListBox";
            this.availableAppointmentsListBox.Size = new System.Drawing.Size(371, 238);
            this.availableAppointmentsListBox.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(308, 285);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // bookAppointmentButton
            // 
            this.bookAppointmentButton.Location = new System.Drawing.Point(188, 284);
            this.bookAppointmentButton.Name = "bookAppointmentButton";
            this.bookAppointmentButton.Size = new System.Drawing.Size(114, 23);
            this.bookAppointmentButton.TabIndex = 4;
            this.bookAppointmentButton.Text = "Book Appointment";
            this.bookAppointmentButton.UseVisualStyleBackColor = true;
            this.bookAppointmentButton.Click += new System.EventHandler(this.bookAppointmentButton_Click);
            // 
            // appointmentLengthComboBox
            // 
            this.appointmentLengthComboBox.FormattingEnabled = true;
            this.appointmentLengthComboBox.Items.AddRange(new object[] {
            "30 Minutes",
            "60 Minutes"});
            this.appointmentLengthComboBox.Location = new System.Drawing.Point(65, 285);
            this.appointmentLengthComboBox.Name = "appointmentLengthComboBox";
            this.appointmentLengthComboBox.Size = new System.Drawing.Size(117, 21);
            this.appointmentLengthComboBox.TabIndex = 5;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(12, 289);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(47, 13);
            this.durationLabel.TabIndex = 6;
            this.durationLabel.Text = "Duration";
            // 
            // BookAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(399, 320);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.appointmentLengthComboBox);
            this.Controls.Add(this.bookAppointmentButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.availableAppointmentsListBox);
            this.Controls.Add(this.stylistComboBox);
            this.Controls.Add(this.dateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookAppointmentForm";
            this.Text = "Appointment Bookings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox stylistComboBox;
        private System.Windows.Forms.ListBox availableAppointmentsListBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button bookAppointmentButton;
        private System.Windows.Forms.ComboBox appointmentLengthComboBox;
        private System.Windows.Forms.Label durationLabel;
    }
}