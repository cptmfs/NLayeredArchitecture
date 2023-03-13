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
        
    }
}
