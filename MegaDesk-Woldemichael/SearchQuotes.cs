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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            MegaDesk mainMenu =  (MegaDesk)Tag;
            mainMenu.Tag = this;
            mainMenu.Show();
            Close();
        }
    }
}
