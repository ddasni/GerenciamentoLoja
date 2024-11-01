using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_25_10_24
{
    internal class clsConexao // "classe conexão"
    {
        // String privada para usar na classe conexão, onde essa string armazena a consulta SQL a ser executada
        private string _StrSql;
        private MySqlCommand cmd; // Adicione um campo para o comando

        public string StrSql
        {
            get { return _StrSql; }
            set { _StrSql = value; }
        }
        // String privada para usar na classe conexão, onde ela guarda uma conexão com o banco de dados MySQL
        private string strConexao = "datasource=localhost;username=root;password=;database=Loja";

        // nesses dois metodos privados a baixo, como já dizem, vão abrir e fechar o banco de dados
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

        // neste metodo ele executa uma consulta SQL armazenada em _StrSql e retorna um DataSet com os resultados.
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

        // Neste metodo ele executa uma consulta SQL e retorna um MySqlDataReader para leitura dos dados.
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
                // tratamento de erro
                throw ex;
            }
        }

        // Neste método é usado para executar comandos SQL que não retornam dados (como INSERT, UPDATE, DELETE).
        public int ExecutarCmd()
        {
            // Abre uma conexão e executa uma consulta 
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
                // tratamento de erro
                throw new Exception("Erro " + ex.Message.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }

        // Adicionei isso para os parametros
        public void Parametro(string nome, object valor)
        {
            if (cmd == null)
            {
                cmd = new MySqlCommand();
            }
            cmd.Parameters.AddWithValue(nome, valor);
        }
    }
}
