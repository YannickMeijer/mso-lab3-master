using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    public class Receipt
    {
        UIInfo uiinfo = new UIInfo();

        // Price and Payment are all we need on the receipt.
        public void ReceiptInfo(float amount)
        {
            MessageBox.Show("Price: " + amount + " EUR" + "\n" + 
                            "Payment: " + uiinfo.Payment);
        }
    }
}
