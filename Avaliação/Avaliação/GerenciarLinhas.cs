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
    }
}
