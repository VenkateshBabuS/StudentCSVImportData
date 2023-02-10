using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCSVImportData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lineNumber = 0;
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=studentdata;Integrated Security=True"))
            {
                conn.Open();
                
                using (StreamReader reader = new StreamReader(@"C:\Users\VenkateshBabuS\OneDrive - Anthology Inc\Desktop\studentdata.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (lineNumber != 0)
                        {
                            var values = line.Split(',');

                            var sql = "INSERT INTO studentdata.dbo.student VALUES ('" + values[0] + "','" + values[1] + "','" + values[2] + "','" + values[3] + "','" + values[4] + "','" + values[5] + "','" + values[6] + "','" + values[7] + "','" + values[8] + "','" + values[9] + "')";

                            var cmd = new SqlCommand();
                            cmd.CommandText = sql;
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.Connection = conn;
                            cmd.ExecuteNonQuery();
                        }
                        lineNumber++;
                    }
                }
                conn.Close();
            }
            Console.WriteLine("Students Import Complete");
            Console.ReadLine();
        }
    }

 }

