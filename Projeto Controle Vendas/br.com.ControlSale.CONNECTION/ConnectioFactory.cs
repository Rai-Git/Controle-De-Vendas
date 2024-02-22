using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Controle_Vendas.br.com.ControlSale.CONNECTION
{
    public class ConnectioFactory
    {
        //Método que conecta banco de dados

        public MySqlConnection getnonnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;
            return new MySqlConnection(conexao);
        }
    }
}
