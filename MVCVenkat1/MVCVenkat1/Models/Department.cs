using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;

namespace MVCVenkat1.Models
{
    [Table("Department")]
    public class Department
    {

        public int DepartmentID { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }
}