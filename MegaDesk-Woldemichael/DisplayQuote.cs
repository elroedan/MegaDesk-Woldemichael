using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Windows.Forms;

namespace MegaDesk_Woldemichael
{
    public partial class DisplayQuote : Form
    {
        // Get the current date
        DateTime currentDate = DateTime.Now;

        public DisplayQuote()
        {
            InitializeComponent();
        }

        public void StartDisplayQuote()
        {
            // Get the Date on the form when quiz starts.
            date.Text = currentDate.ToString("dd MMMM, yyyy");
        }

        private void Close_Click(object sender, EventArgs e)
        {
            MegaDesk menu = new MegaDesk();
            menu.Tag = this;
            menu.Show();
            Close();
        }

        private void width_Validating(object sender,  CancelEventArgs e)
        {
            if(true)
            {
                Width.Text = string.Empty;
                Width.Focus();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
