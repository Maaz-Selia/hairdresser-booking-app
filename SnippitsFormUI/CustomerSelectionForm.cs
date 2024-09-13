using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SnippitsFormUI
{
    public partial class CustomerSelectionForm : Form
    {
        #region Intialising Lists
        public List<Customer> ListOfCustomers = null;
        #endregion

        #region Constructor
        public CustomerSelectionForm()
        {
            InitializeComponent();
            string error = "";
            if (CustomerFile.Loader("Customers.txt", out error) != null)
            {
                ListOfCustomers = CustomerFile.Loader("Customers.txt", out error); // List created when form is created
                CustomerListBox.Items.Clear();
                foreach (Customer c in ListOfCustomers)
                {
                    if (c != null)
                    {
                        CustomerListBox.Items.Add(c);
                    }
                    else { }
                }
            }
            else
            {
                ListOfCustomers = new List<Customer>(); // List created when form is created
            }
        } // Constructor for CustomerSelectionForm
        #endregion

        #region Button Events
        private void searchButton_Click(object sender, EventArgs e)
        {
            string search = CustomerSearch.Text;
            if (!string.IsNullOrWhiteSpace(search.ToLower()) && search.All(char.IsLetter))
            {
                CustomerListBox.Items.Clear();
                foreach (Customer customer in ListOfCustomers)
                {
                    string firstname = customer._FirstName;
                    string lastname = customer._Surname;

                    if (firstname.Contains(search.ToLower()) | lastname.Contains(search.ToLower()))
                    {
                        CustomerListBox.Items.Add(customer);
                    }
                    else if (string.IsNullOrWhiteSpace(firstname) && string.IsNullOrWhiteSpace(lastname))
                    {
                        MessageBox.Show("No Customer Found.");
                    }
                    else
                    {

                    }
                }  // Printing all Customer who match search
            }
            else
            {
                MessageBox.Show("Please enter a valid name");
            }

        } // Search through ListOfCustomers
        private void addNewCustomerButton_Click_1(object sender, EventArgs e)
        {
            bool allfieldsvalid = true;
            CustomerForm form = new CustomerForm();
            do
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    ListOfCustomers.Add(form.GetCustomer());
                    CustomerListBox.Items.Clear();
                    foreach (Customer c in ListOfCustomers)
                    {
                        if (c != null)
                        {
                            CustomerListBox.Items.Add(c);
                        }
                        else { }
                    }
                    allfieldsvalid = false;
                }
                else if (form.DialogResult == DialogResult.Abort)
                {
                    break;
                }
            } while (allfieldsvalid);

            if (form.DialogResult == DialogResult.OK)
            {
                string error = "";
                CustomerFile.Saver("Customers.txt", ListOfCustomers, out error);
                if (error != "")
                {
                    MessageBox.Show(error);

                } // Adds new Customer
            }
        }
        private void editCustomerButton_Click_1(object sender, EventArgs e)
        {
            if (CustomerListBox.SelectedItem != null)
            {
                Customer customer = (Customer)CustomerListBox.SelectedItem;
                CustomerForm form = new CustomerForm(customer);
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    ListOfCustomers.Remove(customer);
                    ListOfCustomers.Add(form.GetExistingCustomer());
                    CustomerListBox.Items.Clear();
                    foreach (Customer c in ListOfCustomers)
                    {
                        if (c != null)
                        {
                            CustomerListBox.Items.Add(c);
                        }
                        else { }
                    }
                }
                if (form.DialogResult == DialogResult.OK)
                {
                    string error = "";
                    CustomerFile.Saver("Customers.txt", ListOfCustomers, out error);
                    if (error != "")
                    {
                        MessageBox.Show(error);
                    }
                }
            }
            else { MessageBox.Show("No Customer selected."); }
        } // Edit existing Customer
        private void bookAppointmentButton_Click(object sender, EventArgs e)
        {
            BookAppointmentForm form = new BookAppointmentForm();
            form.ShowDialog();
        }
        #endregion
    }
}
