﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csh_db_login
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btPlanoAdicional_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlanoAdicional p = new PlanoAdicional();
            p.Show();

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
