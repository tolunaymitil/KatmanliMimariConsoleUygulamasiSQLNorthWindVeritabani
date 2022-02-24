using KatmanliMimariConsoleUygulamasiSQLVeritabani.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimariConsoleUygulamasiSQLVeritabani.Providers
{
    class Helper
    {   
 public List<Customers> TakeData()
        {
            // Bütün müşterileri bir liste içinde tutacağım
            List<Customers> customers = new List<Customers>();
            Data database = new Data();
            SqlConnection connection = database.OpenConnection();
            SqlCommand sqlCommand = database.CreateConnection("SELECT CustomerID,CompanyName,ContactName," +
                "ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax from Customers");
            SqlDataReader dataReader = sqlCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (dataReader.Read())
            {
                Customers customer = new Customers(
                    dataReader["CustomerID"].ToString(),
                    dataReader["CompanyName"].ToString(),
                    dataReader["ContactName"].ToString(),
                    dataReader["ContactTitle"].ToString(),
                    dataReader["Address"].ToString(),
                    dataReader["City"].ToString(),
                    dataReader["Region"].ToString(),
                    dataReader["PostalCode"].ToString(),
                    dataReader["Country"].ToString(),
                    dataReader["Phone"].ToString(),
                    dataReader["Fax"].ToString());
                customers.Add(customer);
            }

            connection.Close();
            return customers;

        }
    }
}
