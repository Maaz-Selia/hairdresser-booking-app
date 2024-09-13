using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnippitsFormUI
{

    #region Classes
    public class AllUsers
    {
        public string _FirstName { get; set; }
        public string _Surname { get; set; }
        public string _Email { get; set; }
        public string _Number { get; set; }

        public override string ToString()
        {
            return _FirstName + " " + _Surname;
        }

    }  // Base/Parent Class 
    public class Customer : AllUsers
    {
        public Customer()
        {

        }
        public Customer(string fname, string sname, string email, string number)
        {
            this._FirstName = fname;
            this._Surname = sname;
            this._Email = email;
            this._Number = number;
        }
    }  // Customer Class - No added functionality apart from those given by Parent Class
    public class Stylist : AllUsers 
    {
        public string _HourlyRate { get; set; }

        public Stylist()
        {

        }
        public Stylist(string fname, string sname, string email, string number, string hrate)
        {
            this._FirstName = fname;
            this._Surname = sname;
            this._Email = email;
            this._Number = number;
            this._HourlyRate = hrate;
        }
        
    } // Stylist Class - Added field for Hourly Rate
    public class Chair
    {
        public string _Date { get; set; }
        public int _chairsAvailable = 4;
        public Stylist[] _Stylist = new Stylist[4];

        public Chair()
        {

        }
        public Chair(string date, int chairs, Stylist[] stylists)
        {
            this._Date = date;
            this._chairsAvailable = chairs;
            this._Stylist = stylists;
        }
        public string ToString(int i)
        {
            return _Stylist[i] + ", has booked a chair on: " + _Date;
        }

    }
    #endregion

    #region FileIO
    public static class StylistFile
    {
        public static List<Stylist> Loader(string pFilename, out string pError)
        {
            pError = "";

            List<Stylist> Stylists = new List<Stylist>();

            StreamReader reader = null;

            try
            {
                reader = new StreamReader(pFilename);

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    if (values.Length == 5)
                    {
                        string fname = values[0];
                        string sname = values[1];
                        string email = values[2];
                        string number = values[3];
                        string hrate = values[4];

                        try
                        {
                            Stylists.Add(new Stylist(fname, sname, email, number, hrate));
                        }
                        catch (Exception ex)
                        {
                            pError = ex.Message;
                            return null;
                        }
                    }
                    else
                    {
                        pError = "Line in file in incorrect format:" + line;
                        return null;
                    }
                }
            }
            catch
            {
                pError = "Could not open file " + pFilename;
                return null;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            if (pError == "")
            {
                return Stylists;
            }
            return null;
        }
        public static bool Saver(string pFilename, List<Stylist> pStylists, out string pError)
        {
            pError = "";

            if (!File.Exists(pFilename))
            {
                pError = "could not find file " + pFilename;
                return false;
            }

            StreamWriter writer = new StreamWriter(pFilename, false);

            foreach (Stylist s in pStylists)
            {
                string[] values = new string[5];
                values[0] = s._FirstName;
                values[1] = s._Surname;
                values[2] = s._Email;
                values[3] = s._Number;
                values[4] = s._HourlyRate;
                writer.WriteLine("{0},{1},{2},{3},{4}", values[0], values[1], values[2], values[3], values[4]);
            }
            writer.Close();

            return true;
        }
    } // Saving and Loading Stylists
    public static class CustomerFile
    {
        public static List<Customer> Loader(string pFilename, out string pError)
        {
            pError = "";

            List<Customer> Customers = new List<Customer>();

            StreamReader reader = null;

            try
            {
                reader = new StreamReader(pFilename);

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    if (values.Length == 4)
                    {
                        string fname = values[0];
                        string sname = values[1];
                        string email = values[2];
                        string number = values[3];

                        try
                        {
                            Customers.Add(new Customer(fname, sname, email, number));
                        }
                        catch (Exception ex)
                        {
                            pError = ex.Message;
                            return null;
                        }
                    }
                    else
                    {
                        pError = "Line in file in incorrect format:" + line;
                        return null;
                    }
                }
            }
            catch
            {
                pError = "Could not open file " + pFilename;
                return null;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            if (pError == "")
            {
                return Customers;
            }
            return null;
        }
        public static bool Saver(string pFilename, List<Customer> pCustomers, out string pError)
        {
            pError = "";

            if (!File.Exists(pFilename))
            {
                pError = "could not find file " + pFilename;
                return false;
            }

            StreamWriter writer = new StreamWriter(pFilename, false);

            foreach (Customer c in pCustomers)
            {
                string[] values = new string[4];
                values[0] = c._FirstName;
                values[1] = c._Surname;
                values[2] = c._Email;
                values[3] = c._Number;
                writer.WriteLine("{0},{1},{2},{3}", values[0], values[1], values[2], values[3]);
            }
            writer.Close();

            return true;
        }
    } // Saving and Loading Customers
    #endregion

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
