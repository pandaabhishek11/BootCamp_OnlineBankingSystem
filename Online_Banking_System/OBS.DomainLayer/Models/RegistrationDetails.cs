using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OBS.DomainLayer.Models
{
    public class RegistrationDetails
    {
        [Key]
        public char ID_Proof { get; set; }
        public char Customer_Name { get; set; }
        public int Phone { get; set; }
        public char Email { get; set; }
        public int DOB { get; set; }
        public char Address { get; set; }
        public int Age { get; set; }
        public char Account_Type { get; set; }
        public char Gender { get; set; }
        public int Initial_Deposit { get; set; }
        public char Nominee_Name { get; set; }
        public int Nominee_Phone { get; set; }


    }
}
