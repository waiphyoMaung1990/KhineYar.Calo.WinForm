using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace KhineYar.Calo.WinForm
{
    public class DBConnection
    {
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection("server=localhost;database=fitnesspro;port=3306;username=root;password=");
        }
    }
}
