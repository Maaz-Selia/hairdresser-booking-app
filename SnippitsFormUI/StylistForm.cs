using SnippitsBusinessLogic;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;


namespace SnippitsFormUI
{
    public partial class StylistForm : Form
    {
        #region Methods to pass Stylist objects to Selection form
        public Stylist GetStylist()
        {
            return Stylist;
        } // Takes Stylist object to Parent Form
        public Stylist GetExistingStylist()
        {
            return existingStylist;
        } // Takes Stylist object to Parent Form
        #endregion

        #region Methods for validation of Inputs
        public static bool AllDigits(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }  // Bool Method - True if AllNumber
        public static bool mFirstname(string pName, out string pError) // Checking First Name
        {
            pError = "";
            if (!string.IsNullOrWhiteSpace(pName) && pName.All(Char.IsLetter))
            {
                return true;
            }
            else { pError = "Please enter a First Name, you may not have any spaces in First Name. You cannot have a number in your name."; return false; }
        }
        public static bool mSurname(string pName, out string pError) // Checking Surname
        {
            pError = "";
            if (!string.IsNullOrWhiteSpace(pName) && pName.All(Char.IsLetter))
            {
                return true;
            }
            else { pError = "Please enter a Surname, you may not have any spaces in First Name. You cannot have a number in your name."; return false; }
        }
        public static bool mEmail(string pEmail, out string pError)
        {
            pError = "";
            string[] splitatat = pEmail.Split('@');
            string[] splitatperiod = pEmail.Split('.');
            string anothertest = splitatperiod[0];
            string testing = splitatat[0];
            bool test = testing.Contains('.');

            if (splitatat.Length == 2 && splitatperiod.Length == 2 && !test && !string.IsNullOrEmpty(testing) && anothertest.Length >= 3)
            {
                return true;
            }
            else
            {
                pError = ("An email address must include a string of one or more characters followed by an ‘@’ symbol, then another string of one or more characters, then a ‘.’ symbol, then another string of one or more characters.");
                return false;
            }
        } // Checking Email
        public static bool mNumber(string pNumber, out string pError)
        {
            pError = "";
            if(pNumber.Length == 11 && AllDigits(pNumber))
            {
                return true;
            }
            else
            {
                pError = "A phone number must contain 11 digits and no more. they must all be numerical values";
                return false;
            }
        } // Checking Number
        public static bool mHourlyRate(string pHourlyRate, out string pError)
        {
            pError = "";
            if (!string.IsNullOrEmpty(pHourlyRate))
            {
                string PoundSignTest = pHourlyRate.Substring(0, 1);
                string DigitTest = pHourlyRate.Substring(1, pHourlyRate.Length - 1);
                if (PoundSignTest == "£" && AllDigits(DigitTest) && !string.IsNullOrEmpty(DigitTest) && !string.IsNullOrWhiteSpace(DigitTest))
                {
                    return true;
                }
                else
                {
                    pError = "The Hourly rate must be a whole number with a £ prefix";
                    return false;
                }
            }
            else
            {
                pError = "The Hourly rate must be a whole number with a £ prefix";
                return false;
            }
        } // Checking Hourly Rate
        #endregion

        #region Initialising variables
        StylistSelectionForm form2 = new StylistSelectionForm();
        public List<Chair> tempChairList = new List<Chair>();
        public Stylist Stylist = null; 
        public Stylist existingStylist = null;
        public bool existing = false;
        public bool notexisting = false;
        #endregion

        #region Constructors
        public StylistForm()
        {
            Stylist = new Stylist();  
            InitializeComponent();
        } // Form Initialisation
        public StylistForm(Stylist pStylist):this()
        {
            StylistFirstName.Text = pStylist._FirstName;
            StylistSurname.Text = pStylist._Surname;
            StylistEmail.Text = pStylist._Email;
            StylistNumber.Text = pStylist._Number;
            StylistHourlyRate.Text = pStylist._HourlyRate;
            existingStylist = pStylist;
            existing = true;
        } // Stylist Constructor for editing existing Stylist
        #endregion

        #region Button events
        private void acceptButton_Click(object sender, EventArgs e)
        {
            Stylist = new Stylist();
            StylistForm form = new StylistForm();
            string firstname = StylistFirstName.Text;
            string surname = StylistSurname.Text;
            string email = StylistEmail.Text;
            string number = StylistNumber.Text;
            string hourlyrate = StylistHourlyRate.Text;

            string Error = "";

            if (mFirstname(firstname, out Error))
            {
                if (mSurname(surname, out Error))
                {
                    if (mEmail(email, out Error))
                    {
                        if (mNumber(number, out Error))
                        {
                            if (mHourlyRate(hourlyrate, out Error))
                            {
                                if (existing)
                                {
                                    existingStylist._FirstName = firstname.ToLower();
                                    existingStylist._Surname = surname.ToLower();
                                    existingStylist._Email = email;
                                    existingStylist._Number = number;
                                    existingStylist._HourlyRate = hourlyrate;
                                }
                                else
                                {
                                    Stylist._FirstName = firstname.ToLower();
                                    Stylist._Surname = surname.ToLower();
                                    Stylist._Email = email;
                                    Stylist._Number = number;
                                    Stylist._HourlyRate = hourlyrate;
                                }
                                DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                //Stylist = null;
                                MessageBox.Show(Error);
                            }
                        }
                        else
                        {
                            //Stylist = null;
                            MessageBox.Show(Error);
                        }
                    }
                    else
                    {
                        //Stylist = null;
                        MessageBox.Show(Error);
                    }
                }
                else
                {
                    //Stylist = null;
                    MessageBox.Show(Error);
                }
            }
            else
            {
                //Stylist = null;
                MessageBox.Show(Error);
            }

        } // Check to see if all fields are valid

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Stylist = null;
            this.Close();
        }
        #endregion
    }
}
