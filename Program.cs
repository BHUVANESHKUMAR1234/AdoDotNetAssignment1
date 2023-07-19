using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdoAssignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateTable();
            Console.ReadLine();
        }

        public static void CreateTable()
        {
            {
                SqlConnection con = null;
                try
                {
                    // Creating Connection  
                    con = new SqlConnection("data source=.; database=Company; integrated security=SSPI");
                    // writing sql query  
                    SqlCommand cm = new SqlCommand("Select * from Worker",con);
    
                    
                    // Opening Connection  
                con.Open();
                    // Executing the SQL query  
                    SqlDataReader sdr = cm.ExecuteReader();
                    // Displaying a message  
                    while (sdr.Read())
                    {
                        Console.WriteLine(sdr["First_Name"] + " " + sdr["Last_Name"] ); // Displaying Record  
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("OOPs, something went wrong." + e);
                }
                // Closing the connection  
                finally
                {
                    con.Close();
                }
            }

        }
    }
}
