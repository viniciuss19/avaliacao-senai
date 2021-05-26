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
    public partial class GerenciarPlanos : Form
    {
        public GerenciarPlanos()
        {
            InitializeComponent();
        }

        private void GerenciarPlanos_Load(object sender, EventArgs e)
        {
            AtualizarClientes();
            AtualizarPlanos();
            AtualizarLinhas();
           
        }
        public void AtualizarLinhas()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=provasenai;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            sql.CommandText = $"Select * FROM Linhas";
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
                dgvLinhas.DataSource = tabela;
                dgvLinhas.ClearSelection();
                conexao.Close();
            }
        }
        public void AtualizarClientes()
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
        public void AtualizarPlanos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=provasenai;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            sql.CommandText = $"Select * FROM Planos";
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
                dgvPlanos.DataSource = tabela;
                dgvPlanos.ClearSelection();
                conexao.Close();
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvClientes.Rows[e.RowIndex];

                tbIDCliente.Text = row.Cells["ID"].Value.ToString();
                tbCPF.Text = row.Cells["CPF"].Value.ToString();
                tbTelefone.Text = row.Cells["Telefone"].Value.ToString();
                tbNomeCliente.Text = row.Cells["Nome"].Value.ToString();

                
            }
        }

        private void dgvPlanos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvPlanos.Rows[e.RowIndex];

            tbNomePlano.Text = row.Cells["Nome_Plano"].Value.ToString();
            tbIDPlano.Text = row.Cells["ID"].Value.ToString();
            tbFranquia.Text = row.Cells["Franquia"].Value.ToString();
            tbMensalidade.Text = row.Cells["Mensalidade"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModificarPlanoCliente();
        }
        public void ModificarPlanoCliente()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=provasenai;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;

            try
            {
                conexao.Open();
                sql.CommandText = $"UPDATE Linhas SET IDPlano = @idplano WHERE ID = @idlinhas AND IDCliente = @idcliente";
               
                sql.Parameters.AddWithValue("@idplano", tbIDPlano.Text);
                sql.Parameters.AddWithValue("@idlinhas", tbIDLinhas.Text);
                sql.Parameters.AddWithValue("@idcliente", tbIDCliente.Text);

                int i = sql.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                MessageBox.Show($"O plano do cliente foi alterado para o plano com o ID {tbIDPlano.Text}");
                conexao.Close();
                tbCPF.Clear();
                tbFranquia.Clear();
                tbNomeCliente.Clear();
                tbIDCliente.Clear();
                tbIDPlano.Clear();
                tbTelefone.Clear();
                tbMensalidade.Clear();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Hide();
        }

        private void dgvLinhas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                DataGridViewRow row = this.dgvLinhas.Rows[e.RowIndex];
                tbIDLinhas.Text = row.Cells["ID"].Value.ToString();
            }
        }
    }
}
