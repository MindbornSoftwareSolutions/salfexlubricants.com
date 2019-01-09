
using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace slfexlubricants.com
{

    public class DBManager
    {

        private DBManager()
        {

        }


        public static SqlConnection OpenConnection()
        {
            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=OVS;Integrated Security=True");
            SqlConnection con = new SqlConnection(@"Data Source=IDCSQL3.znetlive.com,1234;Initial Catalog=salfexlubricant;User ID=salfexlubricant;Password=Salfexlubricant#1");

            //try
            {
                con.Open();
                return con;
            }
            //catch (Exception e)
            //{

            //    return null;
            //}
        }


        static public DataTable ExecuteQuery(String query)
        {

            DataTable dt = new DataTable();
            IDbConnection con = OpenConnection();
            IDbCommand cmd = con.CreateCommand();
            cmd.CommandText = query;

            IDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            reader.Dispose();
            cmd.Dispose();
            con.Dispose();
            return dt;
        }

        static public int ExecuteNonQuery(String query)
        {
            SqlConnection con = OpenConnection();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            int n = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Dispose();

            return n;
        }


        public static DateTime? StringtoDate(String dt)
        {
            dt = dt.Trim();
            if (dt.Length == 0) return null;
            return DateTime.ParseExact(dt, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }


    }

}