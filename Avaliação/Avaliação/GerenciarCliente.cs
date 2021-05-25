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
    public partial class GerenciarCliente : Form
    {
        public GerenciarCliente()
        {
            InitializeComponent();
        }

        private void GerenciarCliente_Load(object sender, EventArgs e)
        {
            AtualizarClientes();
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
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbID.Text);
            EditarCliente(id);
            
             
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvClientes.Rows[e.RowIndex];
                tbNome.Text = row.Cells["Nome"].Value.ToString();
                tbTelefone.Text = row.Cells["Telefone"].Value.ToString();
                tbEstado.Text = row.Cells["Estado"].Value.ToString();
                tbCidade.Text = row.Cells["Cidade"].Value.ToString();
                tbRua.Text = row.Cells["Rua"].Value.ToString();
                tbNumero.Text = row.Cells["Número"].Value.ToString();

                tbID.Text = row.Cells["ID"].Value.ToString();


            }

        }
        public void EditarCliente(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=provasenai;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;

           

            try
            {
                conexao.Open();
                sql.CommandText = $"UPDATE Clientes SET Nome = @nome, Telefone = @telefone, Rua = @rua, Estado = @estado, Cidade = @cidade, Número = @numero WHERE ID = @id";
                sql.Parameters.AddWithValue("@nome", tbNome.Text);
                sql.Parameters.AddWithValue("@telefone", tbTelefone.Text);
                sql.Parameters.AddWithValue("@rua", tbRua.Text);
                sql.Parameters.AddWithValue("@cidade", tbCidade.Text);
                sql.Parameters.AddWithValue("@estado", tbEstado.Text);
                sql.Parameters.AddWithValue("@numero", tbNumero.Text);

                sql.Parameters.AddWithValue("@id", id);
               int i = sql.ExecuteNonQuery();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                MessageBox.Show("Editado com sucesso!");
                AtualizarClientes();
                tbNome.Clear();
                tbEstado.Clear();
                tbTelefone.Clear();
                tbRua.Clear();
                tbCidade.Clear();
                tbID.Clear();
                tbNumero.Clear();

                
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Hide();
        }
    }
}
