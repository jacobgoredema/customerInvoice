namespace CuxtomerInvoice
{
    partial class frmCustomerInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstInvoiceList = new System.Windows.Forms.ListView();
            this.Customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvoiceId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvoiceDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvoiceTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstInvoiceList
            // 
            this.lstInvoiceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Customer,
            this.InvoiceId,
            this.InvoiceDate,
            this.InvoiceTotal});
            this.lstInvoiceList.Location = new System.Drawing.Point(0, 0);
            this.lstInvoiceList.Name = "lstInvoiceList";
            this.lstInvoiceList.Size = new System.Drawing.Size(491, 437);
            this.lstInvoiceList.TabIndex = 0;
            this.lstInvoiceList.UseCompatibleStateImageBehavior = false;
            this.lstInvoiceList.View = System.Windows.Forms.View.Details;
            // 
            // Customer
            // 
            this.Customer.Text = "Customer";
            this.Customer.Width = 190;
            // 
            // InvoiceId
            // 
            this.InvoiceId.Text = "Invoice Id";
            this.InvoiceId.Width = 80;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.Text = "Invoice Date";
            this.InvoiceDate.Width = 80;
            // 
            // InvoiceTotal
            // 
            this.InvoiceTotal.Text = "Invoice Total";
            this.InvoiceTotal.Width = 80;
            // 
            // frmCustomerInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 435);
            this.Controls.Add(this.lstInvoiceList);
            this.Name = "frmCustomerInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Invoice By Invoice Total";
            this.Load += new System.EventHandler(this.frmCustomerInvoice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstInvoiceList;
        private System.Windows.Forms.ColumnHeader Customer;
        private System.Windows.Forms.ColumnHeader InvoiceId;
        private System.Windows.Forms.ColumnHeader InvoiceDate;
        private System.Windows.Forms.ColumnHeader InvoiceTotal;
    }
}

