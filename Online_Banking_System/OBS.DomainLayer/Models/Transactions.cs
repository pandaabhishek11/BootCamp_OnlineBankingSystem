using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.DomainLayer.Models
{
    public class Transactions
    {
        public char Account_Number { get; set; }
        public char Transaction_Type { get; set; }
        public int Customer_ID { get; set; }
        public int Amount { get; set; }
        public int Pin { get; set; }


    }
}
