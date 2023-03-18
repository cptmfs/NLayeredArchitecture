using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StudentDal
    {
        public static int StudentAdd(EntityStudent student)
        {
            SqlCommand cmd = new SqlCommand("insert into datStudent (FirstName,LastName,StudentNumber,Department) values (@p1,@p2,@p3,@p4)", Connection.connection);
            if (cmd.Connection.State != ConnectionState.Open) // SqlCommand'ın Bağlantı durumu Open  değilse , if komutuna düşüp bağlantıyı açıcak..
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", student.FirstName);
            cmd.Parameters.AddWithValue("@p2", student.LastName);
            cmd.Parameters.AddWithValue("@p3", student.StudentNumber);
            cmd.Parameters.AddWithValue("@p4", student.Department);
            
            return cmd.ExecuteNonQuery();

        }
        public static List<EntityStudent> GetStudents()
        {
            List<EntityStudent> students= new List<EntityStudent>();
            SqlCommand cmd2 = new SqlCommand("Select * from datStudent",Connection.connection);
            if (cmd2.Connection.State!=ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                EntityStudent student = new EntityStudent();
                student.StudentID = int.Parse(dr[0].ToString());
                student.FirstName= dr[1].ToString();
                student.LastName = dr[2].ToString();
                student.StudentNumber = dr[3].ToString();
                student.Department = dr[4].ToString();
                students.Add(student);
            }
            dr.Close();
            return students;
        }
        public static int DeleteStudent(int p)
        {
            SqlCommand cmd3 = new SqlCommand("Delete from datStudent where StudentId=@p1", Connection.connection);
            if (cmd3.Connection.State!=ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }
            cmd3.Parameters.AddWithValue("@p1",p);
            return cmd3.ExecuteNonQuery();
        }
        public static int UpdateStudent(EntityStudent entityStudent)
        {
            SqlCommand cmd4 = new SqlCommand("Update datStudent set FirstName=@p1,LastName=@p2,StudentNumber=@p3,Department=@p4 where StudentId=@p5",Connection.connection);
            if (cmd4.Connection.State!=ConnectionState.Open)
            {
                cmd4.Connection.Open();
            }
            cmd4.Parameters.AddWithValue("@p1", entityStudent.FirstName);
            cmd4.Parameters.AddWithValue("@p2", entityStudent.LastName);
            cmd4.Parameters.AddWithValue("@p3", entityStudent.StudentNumber);
            cmd4.Parameters.AddWithValue("@p4", entityStudent.Department);
            cmd4.Parameters.AddWithValue("@p5", entityStudent.StudentID);
            return cmd4.ExecuteNonQuery();

        }
        public static int SearchStudent(int id)
        {
            SqlCommand cmd5 = new SqlCommand("Select * From datStudent where = @p1",Connection.connection);
            if (cmd5.Connection.State!=ConnectionState.Open)
            {
                cmd5.Connection.Open();
            }
            cmd5.Parameters.AddWithValue("@p1",id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd5);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return cmd5.ExecuteNonQuery();
        }
        
    }
}
