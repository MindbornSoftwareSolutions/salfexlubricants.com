
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

        static public Object ExecuteScalar(String query)
        {

            DataTable dt = new DataTable();
            IDbConnection con = OpenConnection();
            IDbCommand cmd = con.CreateCommand();
            cmd.CommandText = query;

            Object result = cmd.ExecuteScalar();

            cmd.Dispose();
            con.Dispose();
            return result;
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

        static public long ExecuteInsert(String query)
        {
            SqlConnection con = OpenConnection();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            int n = cmd.ExecuteNonQuery();

            cmd.CommandText = "select @@identity";
            long id = Convert.ToInt64(cmd.ExecuteScalar());

            cmd.Dispose();
            con.Dispose();

            return id;
        }


        public static DateTime? StringtoDate(String dt)
        {
            dt = dt.Trim();
            if (dt.Length == 0) return null;
            return DateTime.ParseExact(dt, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        public static int ExecuteNonQuery(String query, params object[] map)
        {
            SqlConnection con = OpenConnection();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;

            for (int i = 0; i < map.Length; i += 2)
            {
                cmd.Parameters.AddWithValue((string)map[i], (object)map[i + 1] ?? DBNull.Value);
            }

            int n = cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Dispose();
            return n;
        }

        public static long ExecuteInsert(String query, params object[] map)
        {
            SqlConnection con = OpenConnection();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;

            for (int i = 0; i < map.Length; i += 2)
            {
                cmd.Parameters.AddWithValue((string)map[i], (object)map[i + 1] ?? DBNull.Value);
            }

            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            long id = Convert.ToInt64(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Dispose();
            return id;
        }

    }

}