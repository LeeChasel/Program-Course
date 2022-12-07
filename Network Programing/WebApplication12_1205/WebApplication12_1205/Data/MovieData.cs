using System.Data.SqlClient;
using WebApplication12_1205.Models;

namespace WebApplication12_1205.Data
{
    public class MovieData
    {
        private string strcon;
        public MovieData()
        {
            strcon = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=im_1205;Integrated Security=True";
        }
        public List<Movie> GetMovies()
        {
            List<Movie> res = new List<Movie>();
            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();
                using (SqlCommand sqlcmd = new SqlCommand())
                {
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.CommandText = "select * from Movie";
                    SqlDataReader sqldr = sqlcmd.ExecuteReader();
                    while (sqldr.Read())
                    {
                        Movie newMovie = new Movie();
                        newMovie.Id = sqldr.GetInt32(0); // or = Int32.Parse(sqldr["Id"].ToString())
                        newMovie.Title = sqldr.GetString(1);
                        newMovie.ReleasedTime = sqldr.GetDateTime(2);
                        newMovie.Type = sqldr.GetString(3);
                        newMovie.Price = sqldr.GetInt32(4);
                        res.Add(newMovie);
                        /* 靜態生成物件(生成即初始化) 匿名(anoymous)
                        res.Add(new Movie()
                        {
                            Id = sqldr.GetInt32(0),
                            Title= sqldr.GetString(1),
                            ReleasedTime = sqldr.GetDateTime(2),
                            Type = sqldr.GetString(3),
                            Price = sqldr.GetInt32(4)
                        });*/

                    }
                }
                sqlcon.Close();
            }
            return res;
        }
        public List<Movie> GetMoviesByType(string type)
        {
            List<Movie> res = new List<Movie>();
            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();
                using (SqlCommand sqlcmd = new SqlCommand())
                {
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.CommandText = "select * from Movie where Type=@g";
                    sqlcmd.Parameters.AddWithValue("@g", type);
                    SqlDataReader sqldr = sqlcmd.ExecuteReader();
                    while (sqldr.Read())
                    {
                        Movie newMovie = new Movie();
                        newMovie.Id = sqldr.GetInt32(0);
                        newMovie.Title = sqldr.GetString(1);
                        newMovie.ReleasedTime = sqldr.GetDateTime(2);
                        newMovie.Type = sqldr.GetString(3);
                        newMovie.Price = sqldr.GetInt32(4);
                        res.Add(newMovie);
                    }
                }
                sqlcon.Close();
            }
            return res;
        }
    }
}
