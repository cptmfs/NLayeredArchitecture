using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class LessonDal
    {
        //Crud Metotları 
        // Ekle Sil Güncelle Listele

        public static int LessonAdd(EntityLesson lesson)
        {
            SqlCommand cmd = new SqlCommand("insert into datLesson (LessonName) values (@p1)",Connection.connection);
            if (cmd.Connection.State != ConnectionState.Open ) // SqlCommand'ın Bağlantı durumu Open  değilse , if komutuna düşüp bağlantıyı açıcak..
            { 
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1",lesson.LessonName);
            return cmd.ExecuteNonQuery();

        }
        public static List<EntityLesson> GetLessons()
        {
            List<EntityLesson> lessons = new List<EntityLesson>();
            SqlCommand cmd2 = new SqlCommand("Select * from datLesson",Connection.connection);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            SqlDataReader dataReader= cmd2.ExecuteReader();
            while (dataReader.Read())
            {
                EntityLesson lesson = new EntityLesson();
                lesson.LessonID = byte.Parse(dataReader[0].ToString());
                lesson.LessonName= dataReader[1].ToString(); //dataReader["LessonName"] aynı işlem
                lessons.Add(lesson);
            }
            dataReader.Close();
            return lessons;
        }
        public static int DeleteLesson(byte p)
        {
            SqlCommand cmd3 = new SqlCommand("Delete  from datLesson where LessonId=@p1", Connection.connection);
            if (cmd3.Connection.State!=ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }
            cmd3.Parameters.AddWithValue("@p1",p);
            return cmd3.ExecuteNonQuery();

        }
        public static int UpdateLesson(EntityLesson lesson)
        {
            SqlCommand cmd4 = new SqlCommand("Update datLesson set LessonName=@p1 where LessonId=@p2", Connection.connection);
            if (cmd4.Connection.State!=ConnectionState.Open)
            {
                cmd4.Connection.Open();
            }
            cmd4.Parameters.AddWithValue("@p1",lesson.LessonName);
            cmd4.Parameters.AddWithValue("@p2",lesson.LessonID);
            return cmd4.ExecuteNonQuery();
        }
    }
}
