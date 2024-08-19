using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SysPecNSLib
{
    public static class Banco //classe de conexao de banco de dados
    {
        /// <summary>
        /// Metodo abrir da classe banco é utulizado para representar comandos SQL
        /// no servidor, cujo os dados foram informados na string de conexao (strconn)
        /// </summary>
        /// <returns> Entrega um objeto de comandos SQL, que serao executados na conexao informada</returns>

        public static MySqlCommand Abrir() //metdodo de conexao
        {
            // dados da conexao
            string strconn = @"server=127.0.0.1;database=syspecdb;user=root;password=;";
            MySqlConnection cn = new MySqlConnection(strconn);
            MySqlCommand cmd = new();
            try //tratamento de excessao
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (Exception)                                                                                                                                    
            {
                throw;
            }
            return cmd;
        }
    }
}
