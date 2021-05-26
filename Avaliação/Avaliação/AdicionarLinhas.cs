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
    public partial class AdicionarLinhas : Form
    {
        public AdicionarLinhas()
        {
            InitializeComponent();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=provasenai;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvClientes.Rows[e.RowIndex];
                tbNome.Text = row.Cells["Nome"].Value.ToString();
                tbNúmero.Text = row.Cells["Telefone"].Value.ToString();
                tbCPF.Text = row.Cells["CPF"].Value.ToString();
                tbID.Text = row.Cells["ID"].Value.ToString();
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
        private void AdicionarLinhas_Load(object sender, EventArgs e)
        {
            AtualizarClientes();
            AtualizarPlanos();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=provasenai;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;

            try
            {
                conexao.Open();
                sql.CommandText = $"INSERT INTO Linhas(IDCliente,IDPlano,Número,DATAC,Ativo) VALUES (@idcliente,@idplano,@número,@datac,@ativo)";
                sql.Parameters.AddWithValue("@idcliente", tbID.Text);
                sql.Parameters.AddWithValue("@idplano", tbIDPlano.Text);
                sql.Parameters.AddWithValue("@número", tbNúmero.Text);
                sql.Parameters.AddWithValue("@datac", DateTime.Now);
                sql.Parameters.AddWithValue("@ativo", "Sim");

                int i = sql.ExecuteNonQuery();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                MessageBox.Show("A linha foi adicionada com sucesso ROUF ROUF ");
                conexao.Close();
            }
        }

        private void dgvPlanos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.RowIndex > 0)
            {
                DataGridViewRow row = this.dgvPlanos.Rows[e.RowIndex];
                tbIDPlano.Text = row.Cells["ID"].Value.ToString();
                tbNomePlano.Text = row.Cells["Nome_Plano"].Value.ToString();
                tbConteudoIlimitado.Text = row.Cells["CI"].Value.ToString();
                tbFranquia.Text = row.Cells["Franquia"].Value.ToString();
                tbMensalidade.Text = row.Cells["Mensalidade"].Value.ToString();
                
            }
           
        }

        private void label12_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Hide();
        }
    }
}
