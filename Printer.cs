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

       public void CreateReceipt(UIInfo infoo, Ticket ticket)
        {
            this.price = ticket.price;
            this.date = ticket.date;
            this.payment = infoo.Payment;
        }

        public void CreateTicket(UIInfo infoo, Ticket ticket)
        {
            this.price = ticket.price;
            this.trainClass = ticket.trainClass;
            this.startingStation = ticket.startingStation;
            this.destination = ticket.destination;
            this.discount = ticket.discount;

            CreateReceipt(infoo, ticket);
        }
    }

}
