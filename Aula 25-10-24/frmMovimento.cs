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
            //TEM QUE DEFINIR A FK COD_PROD, FAZENDO ELA SER PUXADA DA OUTRA TABELA

            string tipo = rdbEntrada.Checked ? "Entrada" : "Saida";

            cmdSql.Clear();
            cmdSql.Append("INSERT INTO Movto (cod_movto_fk, dt_movto, tipo, quant, obs) VALUES (@cod_movto, @dt_movto, @tipo, @quant, @obs)");

            using (MySqlCommand cmd = new MySqlCommand(cmdSql.ToString()))
            {
                // Adiciona os parâmetros
                cmd.Parameters.AddWithValue("@cod_movto_fk", txtCodMovto.Text);
                cmd.Parameters.AddWithValue("@dt_movto", dateMovto.Value);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@quant", txtQuant.Text);
                cmd.Parameters.AddWithValue("@obs", txtObservacoes.Text);



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
    }
}
