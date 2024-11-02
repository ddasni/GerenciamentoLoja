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

namespace Aula_25_10_24
{
    public partial class frmMovimento : Form
    {
        clsConexao Conexao = new clsConexao();
        StringBuilder cmdSql = new StringBuilder();
        DataSet DS;
        DataTable DT;
        SqlDataReader SDR;


        public frmMovimento()
        {
            InitializeComponent();
        }

        private void frmMovimento_Load(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

            cmdSql.Clear();
            cmdSql.Append("INSERT INTO Movto (cod_prod_fk, dt_movto, tipo, quant, obs) VALUES (@cod_prod_fk, @dt_movto, @tipo, @quant, @obs)");

            using (MySqlCommand cmd = new MySqlCommand(cmdSql.ToString()))
            {
                try
                {

                    // Adiciona os parâmetros
                    cmd.Parameters.AddWithValue("@cod_prod_fk", txtCodProd.Text);
                    cmd.Parameters.AddWithValue("@dt_movto", dateMovto.Value);
                    string tipo = rdbEntrada.Checked ? "Entrada" : "Saida";
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@quant", txtQuant.Text);
                    cmd.Parameters.AddWithValue("@obs", txtObservacoes.Text);

                    // Executa o comando
                    if (Conexao.ExecutarCmd(cmd) > 0)
                    {
                        MessageBox.Show("Cadastro incluído com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("O cadastro não deu certo.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cmdSql.Clear();
            cmdSql.Append("DELETE FROM Movto WHERE cod_movto = @Codigo");

            using (MySqlCommand cmd = new MySqlCommand(cmdSql.ToString()))
            {
                cmd.Parameters.AddWithValue("@Codigo", txtCodMovto.Text);

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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            cmdSql.Clear();


            if (!string.IsNullOrWhiteSpace(txtCodProd.Text))
            {

                cmdSql.Append("SELECT * FROM Movto WHERE cod_movto = @Codigo");


                using (MySqlCommand cmd = new MySqlCommand(cmdSql.ToString()))
                {

                    try
                    {
                        cmd.Parameters.AddWithValue("@Codigo", txtCodMovto.Text);

                        DataSet DS = Conexao.RetornarDataSet(cmd);

                        if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                        {
                            gridMovimento.DataSource = DS.Tables[0];
                            gridMovimento.Visible = true; // Tornar o grid visível
                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado.");
                            gridMovimento.DataSource = null; // Limpar a grid se não encontrar
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}");
                    }  
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string tipo = rdbEntrada.Checked ? "Entrada" : "Saida";


            cmdSql.Clear();
            cmdSql.Append("UPDATE Movto SET dt_movto = @dt_movto, tipo = @tipo, quant = @quant, obs = @obs WHERE cod_movto = @cod_movto");

            using (MySqlCommand cmd = new MySqlCommand(cmdSql.ToString()))
            {

                cmd.Parameters.AddWithValue("@cod_movto", txtCodMovto.Text);
                cmd.Parameters.AddWithValue("@dt_movto", dateMovto.Value);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@quant", txtQuant.Text);
                cmd.Parameters.AddWithValue("@obs", txtObservacoes.Text);


                if (Conexao.ExecutarCmd(cmd) > 0)
                {
                    MessageBox.Show("Alteração feita com sucesso");
                }
                else
                {
                    MessageBox.Show("A alteração não deu certo");
                }
            }
        }

    }
}
