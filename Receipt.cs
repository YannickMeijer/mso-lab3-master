using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    public class Receipt
    {
        public string date;
        public float price;
        public UIPayment payment;

        // Price, Date and Payment are all we need on the receipt.
        public Receipt(UIInfo infoo, Ticket ticket)
        {
            this.price = ticket.price;
            this.date = ticket.date;
            this.payment = infoo.Payment;
        }
    }
}
