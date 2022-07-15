using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.DomainLayer.Models
{
    public class TermAccount
    {
        public char Account_Number { get; set; }
        public int Customer_ID { get; set; }
        public char IFSC_Code { get; set; }
        public int Term_Balance { get; set; }
        public int Interest { get; set; }
    }
}
