using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OBS.DomainLayer.Models
{
    public class UserDetails
    {
        [Key]
        public char Account_Number { get; set; }
        public char ID_Proof { get; set; }
        public int Customer_ID { get; set; }
        public int Pin { get; set; }
    }
}
