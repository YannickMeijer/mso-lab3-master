using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Payment
    {   // Pay
        public Payment(Ticket standard, UIInfo info)
        {
            switch (info.Payment) //Changing this in any way whatsoever does get rid of the cases but would just replace it with a different system to determine which method of payyment is used.
            {                     // no other method would make it easier to add extra payment methods, so this might as well stay.
                case UIPayment.CreditCard:
                    CreditCard c = new CreditCard();
                    c.Connect();
                    int ccid = c.BeginTransaction(standard.price);
                    c.EndTransaction(ccid);
                    break;
                case UIPayment.DebitCard:
                    DebitCard d = new DebitCard();
                    d.Connect();
                    int dcid = d.BeginTransaction(standard.price);
                    d.EndTransaction(dcid);
                    break;
                case UIPayment.Cash:
                    IKEAMyntAtare2000 coin = new IKEAMyntAtare2000();
                    coin.starta();
                    coin.betala((int)Math.Round(standard.price * 100));
                    coin.stoppa();
                    break;
            }
        }
    }
}
