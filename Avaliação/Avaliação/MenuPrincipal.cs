﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Avaliação
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new InserirCliente().Show();
            this.Hide();
        }

        public void InserirCliente()
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }
    }
}
