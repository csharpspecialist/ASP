using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class CustomerBLL
    {

        public IEnumerable<Customers> xCustomers
        {
            get
            {

                string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

                List<Customers> cust = new List<Customers>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetAllCustomers", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Customers custom = new Customers();
                        custom.CustomerID = Convert.ToInt32(rdr["CustomerID"]);
                        custom.Fname = rdr["FName"].ToString();
                        custom.Gender = rdr["Gender"].ToString();
                        custom.Salary = rdr["Salary"].ToString();
                        custom.City = rdr["City"].ToString();

                        cust.Add(custom);

                    }

                }
                
                return cust;

            }
        }

        public void AddCustomer(Customers customer)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramName = new SqlParameter();
                paramName.ParameterName = "@Fname";
                paramName.Value = customer.Fname;
                cmd.Parameters.Add(paramName);

                SqlParameter paramGender = new SqlParameter();
                paramGender.ParameterName = "@Gender";
                paramGender.Value = customer.Gender;
                cmd.Parameters.Add(paramGender);

                SqlParameter paramSalary = new SqlParameter();
                paramSalary.ParameterName = "@Salary";
                paramSalary.Value = customer.Salary;
                cmd.Parameters.Add(paramSalary);



                //SqlParameter paramSalary = new SqlParameter();
                //paramSalary.ParameterName = "@Salary";
                //paramSalary.Value = customer.Salary;
                //cmd.Parameters.Add(paramSalary);

                SqlParameter paramCity = new SqlParameter();
                paramCity.ParameterName = "@City";
                paramCity.Value = customer.City;
                cmd.Parameters.Add(paramCity);

                con.Open();
                cmd.ExecuteNonQuery();

            }
        }
    }
}
