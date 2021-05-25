using System;
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



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PesquisarNomeCliente();
            lbltabela.Text = "Busca por nome...";
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            AtualizarDGVClientes();
        }
        public void AtualizarDGVClientes()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=provasenai;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            sql.CommandText = $"Select * FROM Clientes";
            try
            {
                conexao.Open();
                int i = sql.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(sql.CommandText, conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dgvClientes.DataSource = tabela;
                dgvClientes.ClearSelection();
                conexao.Close();
            }
        }
        public void PesquisarNomeCliente()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=provasenai;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            sql.CommandText = $"SELECT * FROM Clientes WHERE Nome LIKE   '%{tbNomePesquisar.Text}%'";

            try
            {
                conexao.Open();
                int i = sql.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(sql.CommandText, conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dgvClientes.DataSource = tabela;
                dgvClientes.ClearSelection();
                conexao.Close();
            }
        }
        public void PesquisarCPFCliente()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=provasenai;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            sql.CommandText = $"SELECT * FROM Clientes WHERE CPF LIKE  '%{tbCPFPesquisar.Text}%'";

            try
            {
                conexao.Open();
                int i = sql.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(sql.CommandText, conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dgvClientes.DataSource = tabela;
                dgvClientes.ClearSelection();
                conexao.Close();
            }
        }
        public void PesquisarTelefoneCliente()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=provasenai;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            sql.CommandText = $"SELECT * FROM Clientes WHERE Telefone LIKE '{tbTelefonePesquisar.Text}'";

            try
            {
                conexao.Open();
                int i = sql.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(sql.CommandText, conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dgvClientes.DataSource = tabela;
                dgvClientes.ClearSelection();
                conexao.Close();
            }

        }

        private void pbPesquisarCPF_Click(object sender, EventArgs e)
        {
            PesquisarCPFCliente();
            lbltabela.Text = "Busca por CPF";
        }

        private void pbPesquisarTelefone_Click(object sender, EventArgs e)
        {
            PesquisarTelefoneCliente();
            lbltabela.Text = "Busca por telefone";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AtualizarDGVClientes();
            lbltabela.Text = "Tabela de Clientes...";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new GerenciarCliente().Show();
            this.Hide();
        }
    }
}
