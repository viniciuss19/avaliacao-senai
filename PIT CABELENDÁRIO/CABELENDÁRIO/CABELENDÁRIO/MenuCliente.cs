﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CABELENDÁRIO
{
    public partial class MenuCliente : Form
    {
        public  string barbeariaselecionada = "";
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void menuconfigs_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (barbeariaselecionada == "")
            {
                MessageBox.Show("Você precisa selecionar uma barbearia primeiro!");
            }
            else
            {
                new Agendamento().Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Barb1_Click(object sender, EventArgs e)
        {
            barbeariaselecionada = Barb1.Text;
        }

        private void Barb2_Click(object sender, EventArgs e)
        {
            barbeariaselecionada = Barb2.Text;
        }

        private void Barb3_Click(object sender, EventArgs e)
        {
            barbeariaselecionada = Barb3.Text;
           
        }

        private void Barb4_Click(object sender, EventArgs e)
        {
            barbeariaselecionada = Barb4.Text;
        }

        private void Barb5_Click(object sender, EventArgs e)
        {
            barbeariaselecionada = Barb5.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MostrarAgendamentos().Show();
            this.Hide();
        }
    }
}
