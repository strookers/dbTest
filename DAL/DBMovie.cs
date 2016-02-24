using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace DAL
{
    public class DBMovie
    {
        private const int ID = 0;
        private const int TITLE = 1;
        private const int DESCRIPTION = 2;
        private const int PREMIERE = 3;

        private static SqlCommand dbCmd = null;

        public static List<Movie> GetMovieList()
        {
            List<Movie> returnList = new List<Movie>();
            string sql = "select * from Movie";
            dbCmd = DBConnection.GetDbCommand(sql);

            IDataReader dbReader;
            dbReader = dbCmd.ExecuteReader();

            Movie m;

            while (dbReader.Read())
            {
                m = new Movie();
                m.Id = Convert.ToInt32(dbReader[ID].ToString());
                m.Title = dbReader[TITLE].ToString();
                m.Description = dbReader[DESCRIPTION].ToString();
                m.Premiere = Convert.ToDateTime(dbReader[PREMIERE].ToString());
                returnList.Add(m);
            }
            DBConnection.Close();
            return returnList;

        }

        public static DataSet GetMovieSet()
        {
            DataSet movieSet = new DataSet();

            string sql = "select * from Movie";
            dbCmd = DBConnection.GetDbCommand(sql);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = dbCmd;
            da.Fill(movieSet, "Movie");

            DBConnection.Close();
            return movieSet;

        }

        public static void CreateMovie(string title, string description, DateTime premiere)
        {
            //string sql = @"insert into Movie (title, description, premiere) values (" + title + ",'" + description + "','" + premiere + "')";
            //SqlCommand cmd = DBConnection.GetDbCommand(sql);
            //cmd.ExecuteNonQuery();
            //DBConnection.Close();

            SqlCommand cmd = DBConnection.GetDbCommand("INSERT INTO Movie (title, description, premiere) VALUES (@title, @description, @premiere)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@premiere", premiere);
            cmd.ExecuteNonQuery();
            DBConnection.Close();
        }

        public static Movie FindMovieById(int id)
        {
            string sql = @"select * from Movie where id = " + id;
            dbCmd = DBConnection.GetDbCommand(sql);

            IDataReader dbReader;
            dbReader = dbCmd.ExecuteReader();

            Movie m = null;

            if (dbReader.Read())
            {
                m = new Movie();
                m.Id = Convert.ToInt32(dbReader[ID].ToString());
                m.Title = dbReader[TITLE].ToString();
                m.Description = dbReader[DESCRIPTION].ToString();
                m.Premiere = Convert.ToDateTime(dbReader[PREMIERE].ToString());
            }
            else
            {
                m = null;
                dbReader.Close();
                DBConnection.Close();
            }
            dbReader.Close();
            return m;

        }

        public static Movie FindMovieByTitle(string title)
        {
            string sql = @"select * from Movie where title = '" + title + @"'";
            dbCmd = DBConnection.GetDbCommand(sql);
            IDataReader dbReader;

            dbReader = dbCmd.ExecuteReader();

            Movie m = null; ;

            if (dbReader.Read())
            {
                m = new Movie();
                m.Id = Convert.ToInt32(dbReader[ID].ToString());
                m.Title = dbReader[TITLE].ToString();
                m.Description = dbReader[DESCRIPTION].ToString();
                m.Premiere = Convert.ToDateTime(dbReader[PREMIERE].ToString());
            }
            else
            {
                dbReader.Close();
                DBConnection.Close();
            }
            return m;
        }
    }
}
