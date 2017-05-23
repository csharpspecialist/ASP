using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Customers
    {
        public string Fname { get; set; }
        public string Gender { get; set; }
        public string Salary { get; set; }
        public string City { get; set; }

    }

    string connectionString = ConfigurationManager.ConnectionString["DBCS"].ConnectionString;

    List<Customer> cust = new List<Customer>();

    using (SqlConnection con = new SqlConnection(connectionString))
    {   
        SqlCommand cmd = new SqlCommand("spGetAllCustomers", con);
    cmd.CommandType= CommandType.StoredProcedure;
        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
    while(rdr.Read())
        {

        }



    }



}
