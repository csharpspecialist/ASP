using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCVenkat1.Models
{
    [Table("Employees")]
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
    }
}