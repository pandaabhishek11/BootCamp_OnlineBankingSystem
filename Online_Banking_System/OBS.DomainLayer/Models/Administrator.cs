using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OBS.DomainLayer.Models
{
    public class Administrator
    {
        [Key]
        public int Customer_ID { get; set; }
        public char ID_Proof { get; set; }

    }
}
