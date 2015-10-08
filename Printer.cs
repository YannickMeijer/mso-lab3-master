using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    public class Printer
    {
        public string date;
        public string startingStation;
        public string destination;
        public string trainClass;
        public float price;
        public string discount;
        public UIInfo info;
        public UIPayment payment;

       public void CreateReceipt(UIInfo infoo)
        {
            this.payment = infoo.Payment;
            PrintReceipt();
        }

        public void CreateTicket(UIInfo infoo, Ticket ticket)
        {
            this.date = ticket.date;
            this.price = ticket.price;
            this.trainClass = ticket.trainClass;
            this.startingStation = ticket.startingStation;
            this.destination = ticket.destination;
            this.discount = ticket.discount;

            CreateReceipt(infoo);
            PrintTicket();
        }

        public void PrintTicket()
        {
            MessageBox.Show("Uw ticket wordt geprint.");
        }

        public void PrintReceipt()
        {
            MessageBox.Show("Uw bon wordt geprint.");
        }
    }

}
