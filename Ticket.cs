using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

abstract class Ticket //This class is abstract in case future changes require methods to be added. It is a superclass to StandardTicket
{
    String date;
    String startingStation;
    String destination;
    String kindOfTicket;
    String trainClass;
    String price;
}
