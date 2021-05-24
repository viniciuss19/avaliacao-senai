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
            lblfalachefe.Text = "-- MAIS UM PRO ESQUEMA DE PIRÂMIDE ROUF ";
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

            sql.CommandText = $"INSERT INTO Clientes(Nome,CPF,Telefone,CEP,Estado,Cidade,Rua,Número) VALUES (@nome,@cpf,@telefone,@cep,@estado,@cidade,@rua,@número)";

            try
            {
                conexao.Open();
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
    }
}
