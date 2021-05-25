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
        public void EditarCliente()
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                int linhasselecionadas = dgvClientes.SelectedCells[0].RowIndex;
                int idCliente = (int)dgvClientes.Rows[linhasselecionadas].Cells[0].Value;
                i = BD.EditarCliente(idCliente, new Cliente(tbNome.Text, tbEndereço.Text, tbEndereço.Text));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                if (i > 0)
                {
                    MessageBox.Show("Editado com sucesso ROUF");
                    tbEndereço.Clear();
                    tbNome.Clear();
                    tbTelefone.Clear();
                    dgvClientes.ClearSelection();
                }
                AtualizarClientes();
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvClientes.Rows[e.RowIndex];
                tbNome.Text = row.Cells["Nome"].Value.ToString();
                tbTelefone.Text = row.Cells["Telefone"].Value.ToString();
                tbEndereço.Text = row.Cells["Rua"].Value.ToString();

            }

        }
    }
}
