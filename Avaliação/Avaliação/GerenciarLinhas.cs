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
    public partial class GerenciarLinhas : Form
    {
        public GerenciarLinhas()
        {
            InitializeComponent();
        }

        private void GerenciarLinhas_Load(object sender, EventArgs e)
        {
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
                    dgvLinhasGerenciar.DataSource = tabela;
                    dgvLinhasGerenciar.ClearSelection();
                    conexao.Close();
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbIDLinha.Text);
            AtivarLinha(id);
        }
        public void AtivarLinha(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=provasenai;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            try
            {
                conexao.Open();
                sql.CommandText = $"UPDATE Linhas SET Ativo = @ativo WHERE ID = @id";
                sql.Parameters.AddWithValue("@ativo", "Ativo");
                sql.Parameters.AddWithValue("@id", tbIDLinha.Text);
                int i = sql.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                MessageBox.Show($"A Linha do id {tbIDLinha.Text} foi editada com sucesso ROUF ROOOUUFF");
                AtualizarLinhas();
                tbIDLinha.Clear();
                tbAtivoLinha.Clear();
                tbNumeroLinha.Clear();
                conexao.Close();
            }
        }
        public void DesativarLinha(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=provasenai;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            try
            {
                conexao.Open();
                sql.CommandText =  $"UPDATE Linhas SET Ativo = @ativo WHERE ID = @id";
                sql.Parameters.AddWithValue("@ativo", "Inativo");
                sql.Parameters.AddWithValue("@id", tbIDLinha.Text);

                int i = sql.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
               
                MessageBox.Show($"A Linha com o id {tbIDLinha.Text} foi editada com sucesso ROUF ROOOUUFF");
                AtualizarLinhas();
                tbIDLinha.Clear();
                tbAtivoLinha.Clear();
                tbNumeroLinha.Clear();
                conexao.Close();
            }
        }

        private void dgvLinhasGerenciar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvLinhasGerenciar.Rows[e.RowIndex];

                tbAtivoLinha.Text = row.Cells["Ativo"].Value.ToString();
                tbIDLinha.Text = row.Cells["ID"].Value.ToString();
                tbNumeroLinha.Text = row.Cells["Número"].Value.ToString();
               

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbIDLinha.Text);
            DesativarLinha(id);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PesquisarIDCliente();
        }
        public void PesquisarIDCliente()
        {
            SqlConnection conexao = new SqlConnection();
            SqlCommand sql = new SqlCommand();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=provasenai;Integrated Security=True";
            sql.Connection = conexao;

            try
            {
                conexao.Open();
                sql.CommandText = $"Select * FROM Linhas WHERE IDCliente = {tbPesquisarIDC.Text}";
               
                int i = sql.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(sql.CommandText, conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dgvLinhasGerenciar.DataSource = tabela;
                dgvLinhasGerenciar.ClearSelection();

                conexao.Close();
                tbPesquisarIDC.Clear();
            }
        }
    }
}
