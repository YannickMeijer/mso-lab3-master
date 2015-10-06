using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
   class StandardTicket : Ticket
   {

        public StandardTicket(UIInfo info)
        {
            this.startingStation = info.From;
            this.destination = info.To;
            this.date = "";
            this.trainClass = determineClass(info.Class);
            this.discount = determineDiscount(info.Discount);
            this.price = calculatePrice(this.startingStation, this.destination,info.Discount,info.Class);
        }

   }
}
