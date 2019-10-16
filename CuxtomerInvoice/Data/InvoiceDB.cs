using CuxtomerInvoice.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuxtomerInvoice.Data
{
    public class InvoiceDB
    {
        private const string dir = @"C:\C# 2015\Files\";
        private const string path = dir + "Invoices.txt";

        public static List<Invoice> GetInvoices()
        {
            List<Invoice> invoices = new List<Invoice>();
            StreamReader textIn= new StreamReader(new FileStream (path,FileMode.Open,FileAccess.Read));

            while (textIn.Peek()!=-1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');

                Invoice invoice = new Invoice();
                invoice.InvoiceId = Convert.ToInt32(columns[0]);
                invoice.CustomerId = Convert.ToInt32(columns[1]);
                invoice.InvoiceDate = Convert.ToDateTime(columns[2]);
                invoice.ProductTotal = Convert.ToDecimal(columns[3]);
                invoice.SalesTax = Convert.ToDecimal(columns[4]);
                invoice.Shipping = Convert.ToDecimal(columns[5]);
                invoice.InvoiceTotal = Convert.ToDecimal(columns[6]);
                invoices.Add(invoice);
            }

            textIn.Close();
            return invoices;
        }
    }
}
