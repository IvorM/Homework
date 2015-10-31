using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment01.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;
using System.Transactions;

namespace Assignment01.DB
{
    static class Repository
    {
        private static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public static IEnumerable<Country> GetCountries()
        {
            Country temp = new Country();

            using (SqlConnection con=new SqlConnection(cs))
            {
                using (SqlCommand cmd=new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spGetCountries";
                    cmd.Connection = con;

                    con.Open();
                    using (SqlDataReader reader=cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                temp.IDCountry = (int)reader["IDCountry"];
                                temp.Name = reader["Name"].ToString();

                                yield return temp;
                            }
                        }
                    }
                }
            }
        }

        public static int DeleteCountries(ListBox countriesToDelete)
        {
            int numberOfDeletedCountries = 0;

            using (TransactionScope trScope=new TransactionScope() )
            {
                using (SqlConnection con=new SqlConnection(cs))
                {
                    using (SqlCommand com=new SqlCommand())
                    {  
                        com.CommandType=CommandType.StoredProcedure;
                        com.CommandText = "spDeleteCountries";
                        com.Connection = con;
                        con.Open();
                        SqlParameter p = new SqlParameter();
                        p.DbType = DbType.Int32;
                        p.ParameterName = "@IDCountry";
                        com.Parameters.Add(p);

                        foreach (ListItem item in countriesToDelete.Items)
                            {
                                if (item.Selected)
                                {
                                    com.Parameters.Remove(p);
                                    p.Value = int.Parse(item.Value);
                                    com.Parameters.Add(p);
                                    numberOfDeletedCountries += com.ExecuteNonQuery();
                                }
                                
                            }
                    }
                }
                trScope.Complete();
            }

            return numberOfDeletedCountries;
        }

        public static int InsertCountry(string CountryName)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spInsertCountry";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@CountyName", CountryName);
                    con.Open();

                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}