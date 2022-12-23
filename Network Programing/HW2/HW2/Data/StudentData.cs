using System.Data.SqlClient;
using HW2.Models;

namespace HW2.Data
{
    public class StudentData
    {
        private string strcon;
        public StudentData() 
        {
            strcon = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=hw2;Integrated Security=True;Pooling=False";
        }
        public List<Student> GetStudents()
        {
            List<Student> res = new List<Student>();
            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();
                using (SqlCommand sqlcmd = new SqlCommand())
                {
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.CommandText = "select * from Student";
                    SqlDataReader sqldr = sqlcmd.ExecuteReader();
                    while (sqldr.Read())
                    {
                        res.Add(new Student()
                        {
                            Id = sqldr.GetInt32(0),
                            Name = sqldr.GetString(1),
                            Department= sqldr.GetString(2)
                        });
                    }
                }
                sqlcon.Close();
            }
            return res;
        }

        public List<Student> GetStudentById(string id)
        {
            List<Student> res = new List<Student>();
            using (SqlConnection sqlcon = new SqlConnection(strcon)) 
            {
                sqlcon.Open();
                using (SqlCommand sqlcmd = new SqlCommand())
                {
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.CommandText = "select * from Student where ID=@i";
                    sqlcmd.Parameters.AddWithValue("@i", id);
                    SqlDataReader sqldr = sqlcmd.ExecuteReader();
                    while (sqldr.Read())
                    {
                        res.Add(new Student()
                        {
                            Id = sqldr.GetInt32(0),
                            Name = sqldr.GetString(1),
                            Department = sqldr.GetString(2)
                        });
                    }
                }
                sqlcon.Close();
            }
            return res;
        }
    }
}
