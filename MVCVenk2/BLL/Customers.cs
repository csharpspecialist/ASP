using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BLL
{
    public class Customers
    {
        public int  CustomerID { get; set; }
        [Required]
        public string Fname { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Salary { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string PaymentType { get; set; }


    }



}
