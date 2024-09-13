using System;
using System.Windows.Forms;

namespace SnippitsFormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            CustomerSelectionForm form = new CustomerSelectionForm();
            form.ShowDialog();
        }

        private void stylistsButton_Click(object sender, EventArgs e)
        {
            StylistSelectionForm form = new StylistSelectionForm();
            form.ShowDialog();
        }
    }
}
