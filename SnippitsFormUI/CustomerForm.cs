using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SnippitsFormUI
{
    public partial class CustomerForm : Form
    {
        #region Methods to pass Customer object to Selection form
        public Customer GetCustomer()
        {
            return Customer;
        } // Takes Customer object to Parent Form
        public Customer GetExistingCustomer()
        {
            return existingCustomer;
        } // Takes Customer object to Parent Form
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
            if (pNumber.Length == 11 && AllDigits(pNumber))
            {
                return true;
            }
            else
            {
                pError = "A phone number must contain 11 digits and no more. they must all be numerical values";
                return false;
            }
        } // Checking Number
        #endregion

        #region Initialising Variables
        public Customer Customer = null;
        public Customer existingCustomer = null;
        public bool existing = false;
        public bool notexisting = false;
        #endregion

        #region Constructors
        public CustomerForm()
        {
            Customer = new Customer();
            InitializeComponent();

        } // Form Initialisation
        public CustomerForm(Customer pCustomer):this()
        {
            CustomerFirstName.Text = pCustomer._FirstName;
            CustomerSurname.Text = pCustomer._Surname;
            CustomerEmail.Text = pCustomer._Email;
            CustomerNumber.Text = pCustomer._Number;
            existingCustomer = pCustomer;
            existing = true;
        } // Customer Constructor for editing existing Customer
        #endregion

        #region Button Events
        private void acceptButton_Click(object sender, EventArgs e)
        {
            Customer = new Customer();
            CustomerForm form = new CustomerForm();
            string firstname = CustomerFirstName.Text;
            string surname = CustomerSurname.Text;
            string email = CustomerEmail.Text;
            string number = CustomerNumber.Text;

            string Error = "";

            if (mFirstname(firstname, out Error))
            {
                if (mSurname(surname, out Error))
                {
                    if (mEmail(email, out Error))
                    {
                        if (mNumber(number, out Error))
                        {
                            if (existing)
                            {
                                existingCustomer._FirstName = firstname.ToLower();
                                existingCustomer._Surname = surname.ToLower();
                                existingCustomer._Email = email;
                                existingCustomer._Number = number;
                            }
                            else
                            {
                                Customer._FirstName = firstname.ToLower();
                                Customer._Surname = surname.ToLower();
                                Customer._Email = email;
                                Customer._Number = number;
                            }
                            DialogResult = DialogResult.OK;
                            //this.Close();
                        }
                        else
                        {
                            Customer = null;
                            MessageBox.Show(Error);
                        }
                    }
                    else
                    {
                        Customer = null;
                        MessageBox.Show(Error);
                    }
                }
                else
                {
                    Customer = null;
                    MessageBox.Show(Error);
                }
            }
            else
            {
                Customer = null;

                MessageBox.Show(Error);
            }
        } // Check to see if all fields are Valid
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Customer = null;
            this.Close();
        }
        #endregion
    }
}
