﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Woldemichael
{
    public partial class MegaDesk : Form
    {
        public MegaDesk()
        {
            InitializeComponent();
        }

        private void AddNewQuote_Click(object sender, EventArgs e)
        {
            AddQuote addQuote = new AddQuote();
            addQuote.Tag = this;
            addQuote.Show();
            Close();
        }

        private void ViewQuote_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes(); 
            viewAllQuotes.Tag = this;   
            viewAllQuotes.Show();   
            Close();
        }

        private void SearchQuote_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes(); 
            searchQuotes.Tag = this;
            searchQuotes.Show();
            Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
