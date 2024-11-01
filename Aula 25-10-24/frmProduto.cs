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
            try
            {
                // o jeito que fiz não tava cadastrando e nem mostrando erro
                // Ao colocar tratamento de erro começou a acusar o erro
                // o grande problema é entender como funciona essa classe conexão com os parametros

                cmdSql.Remove(0, cmdSql.Length);
                cmdSql.Append("insert into Alunos ");
                cmdSql.Append("(matricula, nome, email, celular, cep) ");
                cmdSql.Append("values ");
                cmdSql.Append("(" + txtMatricula.Text + " , '" + txtNome.Text + "' , '" + txtEmail.Text + "' ,  ");
                cmdSql.Append(" '" + txtCelular + "' ,  '" + txtCep + "' ) ");
                // isso é um teste


                // MessageBox.Show(cmdSql.ToString());

                Conexao.StrSql = cmdSql.ToString();

                int linhasAfetadas = Conexao.ExecutarCmd();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Cadastro feito com sucesso!",
                                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("O cadastro não deu certo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Conexao.ExecutarCmd();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show ("Ocorreu um erro " + ex.Message, "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.ExecutarCmd();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpa o DataGridView antes da nova pesquisa
                gridProdutos.DataSource = null;

                StringBuilder cmdSql = new StringBuilder();

                // se o codigo for digitado
                if (txtCodProd.Text != null && txtCodProd.Text != "")
                {
                    cmdSql.Append("SELECT * FROM Produto WHERE cod_prod = @cod_prod");
                    Conexao.StrSql = cmdSql.ToString();
                    Conexao.Parametro("@cod_prod", txtCodProd.Text);
                }
                // se não foi digitado
                else
                {
                    cmdSql.Append("SELECT * FROM Produto");
                    Conexao.StrSql = cmdSql.ToString();
                }

                // Executa a consulta e obtém o DataSet
                DataSet ds = Conexao.RetornarDataSet();

                // Exibe os resultados no DataGridView
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    gridProdutos.DataSource = ds.Tables[0];
                    gridProdutos.Visible = true; // Torna o DataGridView visível
                }
                else
                {
                    gridProdutos.Visible = false; // deixar o DataGridView invisível se não houver dados
                    MessageBox.Show("Nenhum resultado encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a pesquisa: " + ex.Message);
            }
        }
    }
}
