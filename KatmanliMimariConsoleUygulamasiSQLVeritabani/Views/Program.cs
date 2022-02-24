using KatmanliMimariConsoleUygulamasiSQLVeritabani.Models;
using KatmanliMimariConsoleUygulamasiSQLVeritabani.Providers;
using System;
using System.Collections.Generic;

namespace KatmanliMimariConsoleUygulamasiSQLVeritabani
{
    class Program
    {
        static void Main(string[] args)
        {
           
List<Customers> customerList = new List<Customers>();
            Helper helper = new Helper();
            customerList = helper.TakeData();
            foreach (var item in customerList)
            {
                Console.WriteLine(item.CustomerID + " " + item.CompanyName + " " + item.ContactName + " " + item.ContactTitle + " " +
                    item.Address + " " + item.City + " " + item.Region + " " + item.PostalCode + " " + item.Country + " " +
                    item.Phone + " " + item.Fax);
            }
            Console.ReadKey();
        }
    }
}
