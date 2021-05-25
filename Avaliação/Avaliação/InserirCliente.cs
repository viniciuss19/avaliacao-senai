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
    public partial class InserirCliente : Form
    {
        public InserirCliente()
        {
            InitializeComponent();
        }

        private void InserirCliente_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha os campos restantes");
                txtNome.Focus();
                lblfalachefe.Text = "ROUF PREENCHA OS CAMPOS";
            }
            else if (txtCPF.Text == "")
            {
                MessageBox.Show("Preencha os campos restantes");
                txtCPF.Focus();
                lblfalachefe.Text = "ROUF PREENCHA OS CAMPOS";
            }
            else if (txtTelefone.Text == "")
            {
                MessageBox.Show("Preencha os campos restantes");
                txtTelefone.Focus();
                lblfalachefe.Text = "ROUF PREENCHA OS CAMPOS";
            }
            else if (txtCEP.Text == "")
            {
                MessageBox.Show("Preencha os campos restantes");
                txtCEP.Focus();
                lblfalachefe.Text = "ROUF PREENCHA OS CAMPOS";
            }
            else if (txtRua.Text == "")
            {
                MessageBox.Show("Preencha os campos restantes");
                txtRua.Focus();
                lblfalachefe.Text = "ROUF PREENCHA OS CAMPOS";
            }
            else if (txtCidade.Text == "")
            {
                MessageBox.Show("Preencha os campos restantes");
                txtCidade.Focus();
                lblfalachefe.Text = "ROUF PREENCHA OS CAMPOS";
            }
            else if (txtEstado.Text == "")
            {
                MessageBox.Show("Preencha os campos restantes");
                txtEstado.Focus();
            }
            else if (txtNúmero.Text == "")
            {
                MessageBox.Show("Preencha os campos restantes");
                txtNúmero.Focus();
                lblfalachefe.Text = "ROUF PREENCHA OS CAMPOS";
            }
           else
            {
                lblfalachefe.Text = "ROOOOOOOOOOOOOOUUUUFFFFFF";
                AdicionarCliente();
            }

            

           
          
        }

        private void lblfalachefe_Click(object sender, EventArgs e)
        {

        }
        public void AdicionarCliente()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=provasenai;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;

           

            try
            {
                conexao.Open();
                sql.CommandText = $"INSERT INTO Clientes(Nome,CPF,Telefone,CEP,Estado,Cidade,Rua,Número) VALUES (@nome,@cpf,@telefone,@cep,@estado,@cidade,@rua,@número)";
                sql.Parameters.AddWithValue("@nome", txtNome.Text);
                sql.Parameters.AddWithValue("@cpf", txtCPF.Text);
                sql.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                sql.Parameters.AddWithValue("@cep", txtCEP.Text);
                sql.Parameters.AddWithValue("@estado", txtEstado.Text);
                sql.Parameters.AddWithValue("@cidade", txtCidade.Text);
                sql.Parameters.AddWithValue("@rua", txtRua.Text);
                sql.Parameters.AddWithValue("@número", txtNúmero.Text);

                int i = sql.ExecuteNonQuery();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                MessageBox.Show($"O {txtNome.Text} caiu no esquema de piramide com sucesso ROUF ROUF");
                conexao.Close();
            }
            txtNome.Clear();
            txtCPF.Clear();
            txtCidade.Clear();
            txtCEP.Clear();
            txtEstado.Clear();
            txtRua.Clear();
            txtNúmero.Clear();
            txtTelefone.Clear();
            txtComplemento.Clear();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Hide();
        }
    }
}
