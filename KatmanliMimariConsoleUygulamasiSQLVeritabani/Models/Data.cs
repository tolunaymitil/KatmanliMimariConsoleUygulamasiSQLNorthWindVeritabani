using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimariConsoleUygulamasiSQLVeritabani.Models
{
    class Data
    {
        public SqlConnection OpenConnection()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NORTHWND;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            baglanti.Open();
            return baglanti;
        }
        // Her sorgu oluşturduğumuzda buradan yararlanacağız.
        public SqlCommand CreateConnection(string sorgu)
        {
            SqlCommand sqlCommand = new SqlCommand(sorgu, OpenConnection());
            return sqlCommand;
        }
    }
}
