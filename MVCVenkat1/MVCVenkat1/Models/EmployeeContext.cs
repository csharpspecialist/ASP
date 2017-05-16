using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCVenkat1.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }

    }
}