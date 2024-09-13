using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SnippitsFormUI
{
    public partial class StylistSelectionForm : Form
    {
        #region Initialising Lists
        public List<Stylist> ListOfStylists = null;
        public static List<Chair> ListOfStylistBookings = new List<Chair>();
        #endregion

        #region Constructor
        public StylistSelectionForm() 
        {
            
            InitializeComponent();
            string error = "";
            if (StylistFile.Loader("Stylists.txt", out error) != null)
            {
                ListOfStylists = StylistFile.Loader("Stylists.txt", out error); // List created when form is created
                StylistListBox.Items.Clear();
                foreach (Stylist s in ListOfStylists)
                {
                    if (s != null)
                    {
                        StylistListBox.Items.Add(s);
                    }
                    else { }
                }
            }
            else
            {
                ListOfStylists = new List<Stylist>(); // List created when form is created
            }

        }   // Constructor for StylistSelectionForm
        #endregion

        #region Button Events
        private void searchButton_Click(object sender, EventArgs e)
        {
            string search = StylistSearch.Text;
            if(!string.IsNullOrWhiteSpace(search.ToLower()) && search.All(char.IsLetter))
            {
                StylistListBox.Items.Clear();
                foreach (Stylist stylist in ListOfStylists)
                {
                    string firstname = stylist._FirstName;
                    string lastname = stylist._Surname;

                    if(firstname.Contains(search.ToLower()) | lastname.Contains(search.ToLower()))
                    {                       
                        StylistListBox.Items.Add(stylist);                       
                    }
                    else if(string.IsNullOrWhiteSpace(firstname) && string.IsNullOrWhiteSpace(lastname))
                    {
                        MessageBox.Show("No Stylist Found.");
                    }
                    else
                    {        
                        
                    }
                }  // Printing all Stylists who match search
            }
            else
            {
                MessageBox.Show("Please enter a valid name");
            }

        } // Search through ListOfStylist

        private void addNewStylistButton_Click(object sender, EventArgs e)
        {
            bool allfieldsvalid = true;
            StylistForm form = new StylistForm();
            do
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    ListOfStylists.Add(form.GetStylist());
                    StylistListBox.Items.Clear();
                    foreach (Stylist s in ListOfStylists)
                    {
                        if (s != null)
                        {
                            StylistListBox.Items.Add(s);
                        }
                        else { }
                    }
                    allfieldsvalid = false;
                }
                else if(form.DialogResult == DialogResult.Abort)
                {
                    break;
                }
            } while (allfieldsvalid);

            if(form.DialogResult == DialogResult.OK)
            {
                string error = "";
                StylistFile.Saver("Stylists.txt", ListOfStylists, out error);
                if (error != "")
                {
                    MessageBox.Show(error);
                }
            }
        } // Adds new Stylist

        private void editStylistButton_Click(object sender, EventArgs e)
        {
            
            if (StylistListBox.SelectedItem != null)
            {
                Stylist stylist = (Stylist)StylistListBox.SelectedItem;
                StylistForm form = new StylistForm(stylist);
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    ListOfStylists.Remove(stylist);
                    ListOfStylists.Add(form.GetExistingStylist());
                    StylistListBox.Items.Clear();
                    foreach (Stylist s in ListOfStylists)
                    {
                        if (s != null)
                        {
                            StylistListBox.Items.Add(s);
                        }
                        else { }
                    }
                }

                if (form.DialogResult == DialogResult.OK)
                {
                    string error = "";
                    StylistFile.Saver("Stylists.txt", ListOfStylists, out error);
                    if (error != "")
                    {
                        MessageBox.Show(error);
                    }
                }
            }
            else { MessageBox.Show("No Stylist selected."); }

            



        } // Edit existing Stylist

        private void bookChairButton_Click(object sender, EventArgs e)
        {

            
            if (StylistListBox.SelectedItem == null) // Makes sure a Stylist is selected
            {
                MessageBox.Show("A Stylist must be selected to book a chair.");
            }
            else if (StylistDateTime.Value.Date.ToString() != null) // Begins Booking Validation
            {
                MessageBox.Show("You have chosen : " + StylistDateTime.Value.Date.ToString());
                string date = StylistDateTime.Value.Date.ToString();
                Chair newChair = new Chair();
                newChair._Date = DateTime.Today.ToString();
                bool First = true;
                bool NotFirstDate = false;
                bool NotFirstBooking = true;
                int counter = 0;
                int itemAtIndex = 0;

                foreach (Chair c in ListOfStylistBookings) // Checks to see if that Date has already been booked
                {
                    if (c._Date == date)
                    {
                        First = false;
                        NotFirstDate = true;
                        itemAtIndex = counter;
                        foreach(Stylist s in c._Stylist) // Checks to see if the stylist has already booked on this day
                        {
                            if(s == (Stylist)StylistListBox.SelectedItem)
                            {
                                NotFirstBooking = false;
                            }
                        }
                    }
                    else
                    {
                        
                    }
                    counter++;
                }

                if (First && NotFirstBooking) 
                {
                    newChair._Date = date;
                    newChair._Stylist[0] = (Stylist)StylistListBox.SelectedItem;
                    newChair._chairsAvailable--;
                    ListOfStylistBookings.Add(newChair);
                    MessageBox.Show("You have booked a chair on: " + date);

                }
                else if (NotFirstDate && ListOfStylistBookings[itemAtIndex]._chairsAvailable < 4 && ListOfStylistBookings[itemAtIndex]._chairsAvailable > 0 && NotFirstBooking)
                {
                    switch (ListOfStylistBookings[itemAtIndex]._chairsAvailable)
                    {
                        case 3:
                            newChair._Date = date;
                            newChair._Stylist[1] = (Stylist)StylistListBox.SelectedItem;
                            newChair._chairsAvailable -= 2;
                            ListOfStylistBookings.Add(newChair);
                            MessageBox.Show("You have booked a chair on: " + date);
                            break;
                        case 2:
                            newChair._Date = date;
                            newChair._Stylist[2] = (Stylist)StylistListBox.SelectedItem;
                            newChair._chairsAvailable -= 3;
                            ListOfStylistBookings.Add(newChair);
                            MessageBox.Show("You have booked a chair on: " + date);
                            break;
                        case 1:
                            newChair._Date = date;
                            newChair._Stylist[3] = (Stylist)StylistListBox.SelectedItem;
                            newChair._chairsAvailable -= 4;
                            ListOfStylistBookings.Add(newChair);
                            MessageBox.Show("You have booked a chair on: " + date);
                            break;
                        default:
                            break;
                    }

                }
                else if(!NotFirstBooking)
                {
                    MessageBox.Show("You can only book one chair a day!");
                }
                else
                {
                    MessageBox.Show("Sorry this day is fully booked.");
                }
            }
            else { }

        } // Booking chairs
        #endregion
    }
}
