using CuxtomerInvoice.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuxtomerInvoice.Data
{
    public class CustomerDB
    {
        private const string dir = @"C:\C# 2015\Files\";
        private const string path = dir + "CustomersX23.txt";

        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek()!=-1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                Customer customer = new Customer();
                customer.CustomerId = Convert.ToInt32(columns[0]);
                customer.Name = columns[1];
                customers.Add(customer);
            }

            textIn.Close();
            return customers;
        }
    }
}
