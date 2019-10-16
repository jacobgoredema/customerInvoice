using CuxtomerInvoice.Data;
using CuxtomerInvoice.MMABookDataSetTableAdapters;
using CuxtomerInvoice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuxtomerInvoice
{
    public partial class frmCustomerInvoice : Form
    {
        public frmCustomerInvoice()
        {
            InitializeComponent();
        }
        MMABookDataSet mmaBooksDataSet = new MMABookDataSet();
        InvoicesTableAdapter invoicesTableAdapter = new InvoicesTableAdapter();
        CustomersTableAdapter customersTableAdapter = new CustomersTableAdapter();

        private void frmCustomerInvoice_Load(object sender, EventArgs e)
        {
            invoicesTableAdapter.Fill(mmaBooksDataSet.Invoices);
            customersTableAdapter.Fill(mmaBooksDataSet.Customers);

            var invoices = from invoice in mmaBooksDataSet.Invoices
                           join customer in mmaBooksDataSet.Customers
                           on invoice.CustomerID equals customer.CustomerID
                           orderby customer.Name, invoice.InvoiceTotal descending
                           select new
                           {
                               customer.Name,
                               invoice.InvoiceID,
                               invoice.InvoiceDate,
                               invoice.InvoiceTotal
                           };

            string customerName = string.Empty;
            int i = 0;

            foreach (var invoice in invoices)
            {
                if (invoice.Name != customerName)
                {
                    lstInvoiceList.Items.Add(invoice.Name);
                    customerName = invoice.Name;
                }
                else
                {
                    lstInvoiceList.Items.Add("");
                }

                lstInvoiceList.Items[i].SubItems.Add(invoice.InvoiceID.ToString());
                lstInvoiceList.Items[i].SubItems.Add(Convert.ToDateTime(invoice.InvoiceDate).ToString());
                lstInvoiceList.Items[i].SubItems.Add(invoice.InvoiceTotal.ToString("c"));

                i += 1;
            }        
        }
    }
}
