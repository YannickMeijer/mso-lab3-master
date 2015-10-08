using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    abstract public class Ticket //This class is abstract in case future changes require methods to be added. It is a superclass to StandardTicket

    {
        public string date;
        public string startingStation;
        public string destination;
        public string trainClass;
        public float price;
        public string discount;
        private UIInfo info;

        protected float calculatePrice(string from, string to,UIDiscount discount, UIClass classKind)
        {
            // Get number of tariefeenheden
            int tariefeenheden = Tariefeenheden.getTariefeenheden(from ,to);
            
            // Compute the column in the table based on choices
            int tableColumn;
            
            // First based on class
            if (UIClass.FirstClass == classKind)
                tableColumn = 3;
            else
                tableColumn = 0;

            // Then, on the discount
            if (UIDiscount.TwentyDiscount == discount)
                tableColumn += 1;
            else if (UIDiscount.FortyDiscount == discount)
                tableColumn += 2;

            // Get price
            float price = PricingTable.getPrice(tariefeenheden, tableColumn);
            if (info.Way == UIWay.Return)
            {
                price *= 2;
            }
            // Add 50 cent if paying with credit card
            if (info.Payment == UIPayment.CreditCard)
            {
                price += 0.50f;
            }
            return price;
        }

        protected String determineDiscount(UIDiscount discount)
        {
            if (discount == UIDiscount.NoDiscount)
                return "Korting: geen.";
            else if (discount == UIDiscount.TwentyDiscount)
                return "Korting: 20%.";
            else
                return "Korting 40%.";
        }

        protected String determineClass(UIClass classKind)
        {
            if (classKind == UIClass.FirstClass)
                return "Klasse: eerste klasse";
            else
                return "Klasse: tweede klasse";
        }

    }
}
