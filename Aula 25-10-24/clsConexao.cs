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
        public DataSet RetornarDataSet(MySqlCommand cmd)
        {
            MySqlDataAdapter DA = new MySqlDataAdapter();
            DataSet DS = new DataSet();

            using (MySqlConnection Conn = AbrirBanco())
            {
                cmd.Connection = Conn;
                DA.SelectCommand = cmd;
                DA.Fill(DS);
            }
            return DS;
        }

        public int ExecutarCmd(MySqlCommand cmd)
        {
            try
            {
                using (MySqlConnection Conn = AbrirBanco())
                {
                    cmd.Connection = Conn;
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao executar comando no banco de dados: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro inesperado: " + ex.Message);
            }
        }
    }
}
