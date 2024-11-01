using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Aula_25_10_24
{
    public partial class frmProduto : Form
    {
        clsConexao Conexao = new clsConexao();
        StringBuilder cmdSql = new StringBuilder();
        DataSet DS;
        DataTable DT;
        SqlDataReader SDR;

        public frmProduto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            cmdSql.Clear();
            cmdSql.Append("INSERT INTO Produto (cod_prod, descricao, valor, vencto) VALUES (@cod_prod, @descricao, @valor, @vencto)");

            using (MySqlCommand cmd = new MySqlCommand(cmdSql.ToString()))
            {
                // Adiciona os parâmetros
                cmd.Parameters.AddWithValue("@cod_prod", txtCodProd.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDesc.Text);
                cmd.Parameters.AddWithValue("@valor", txtValor.Text);
                cmd.Parameters.AddWithValue("@vencto", dtpVencto.Value);


                // Executa o comando
                if (Conexao.ExecutarCmd(cmd) > 0)
                {
                    MessageBox.Show("Cadastro feito com sucesso");
                }
                else
                {
                    MessageBox.Show("O cadastro não deu certo");
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Limpar o comando SQL
            cmdSql.Clear();

            // Verificar se o campo de código do produto não está vazio
            if (!string.IsNullOrWhiteSpace(txtCodProd.Text))
            {
                // Montar a consulta SQL
                cmdSql.Append("SELECT * FROM Produto WHERE cod_prod = @Codigo");

                // Criar o comando SQL
                using (MySqlCommand cmd = new MySqlCommand(cmdSql.ToString()))
                {
                    // Adicionar o parâmetro com o código do produto
                    cmd.Parameters.AddWithValue("@Codigo", txtCodProd.Text);

                    // Executar a consulta e retornar o DataSet
                    DataSet DS = Conexao.RetornarDataSet(cmd);

                    // Verificar se o DataSet contém alguma tabela
                    if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                    {
                        gridProdutos.DataSource = DS.Tables[0];
                        gridProdutos.Visible = true; // Tornar o grid visível
                    }
                    else
                    {
                        // Caso não encontre resultados
                        MessageBox.Show("Produto não encontrado.");
                        gridProdutos.DataSource = null; // Limpar a grid se não encontrar
                    }
                }
            }

            else
            {
                cmdSql.Append("SELECT * FROM Produto");
                using (MySqlCommand cmd = new MySqlCommand(cmdSql.ToString()))
                {

                    DataSet DS = Conexao.RetornarDataSet(cmd);

                    if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                    {
                        gridProdutos.DataSource = DS.Tables[0];
                        gridProdutos.Visible = true; // Tornar o grid visível
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cmdSql.Clear();
            cmdSql.Append("DELETE FROM Produto WHERE cod_prod = @Codigo");

            using (MySqlCommand cmd = new MySqlCommand(cmdSql.ToString()))
            {
                cmd.Parameters.AddWithValue("@Codigo", txtCodProd.Text);

                if (Conexao.ExecutarCmd(cmd) > 0)
                {
                    MessageBox.Show("Exclusão executada com sucesso");
                }
                else
                {
                    MessageBox.Show("Exclusão não deu certo");
                }
            }
        }
    }
}
