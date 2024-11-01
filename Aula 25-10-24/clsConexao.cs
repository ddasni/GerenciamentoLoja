using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_25_10_24
{
    internal class clsConexao
    {
        private string _StrSql;
        private MySqlCommand cmd; // Adicione um campo para o comando

        public string StrSql
        {
            get { return _StrSql; }
            set { _StrSql = value; }
        }
        private string strConexao = "datasource=localhost;username=root;password=;database=Loja";

        private MySqlConnection AbrirBanco()
        {
            MySqlConnection Conn = new MySqlConnection();
            Conn.ConnectionString = strConexao;
            Conn.Open();
            return Conn;
        }

        private void FecharBanco(MySqlConnection Conn)
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }

        public DataSet RetornarDataSet()
        {
            MySqlConnection Conn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter DA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            try
            {
                Conn = AbrirBanco();
                cmd.CommandText = _StrSql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = Conn;

                DA.SelectCommand = cmd;
                DA.Fill(DS);

                return (DS);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
        }

        public MySqlDataReader RetornarDataReader()
        {

            MySqlConnection Conn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();


            try
            {
                Conn = AbrirBanco();
                cmd.CommandText = _StrSql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = Conn;

                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ExecutarCmd()
        {

            MySqlConnection Conn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                Conn = AbrirBanco();
                cmd.CommandText = _StrSql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = Conn;

                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro " + ex.Message.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }

        // Adicionei isso para os parametros
        public void Parametro(string nome, object valor)
            // Tem que verificar esse string nome e object valor
        {
            if (cmd == null)
            {
                cmd = new MySqlCommand();
            }
            cmd.Parameters.AddWithValue(nome, valor);
            // aqui o mesmo
        }
    }
}
