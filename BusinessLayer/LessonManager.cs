using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LessonManager
    {
        public static int LessonAddBL(EntityLesson lesson)
        {
            if (lesson.LessonName!=null && lesson.LessonName.Length>=3 && lesson.LessonName.Length<=30) //Şartlarımızı Sağlıyor ise Aşağıdaki ekleme metodu çalışacak..
            {
                return LessonDal.LessonAdd(lesson);
            }
            return -1; // şartlar sağlanmadı ise -1 döndüreceği için ekleme işlemi gerçekleşmeyecek. " 1 döndürdüğünde ekleme gerçekleşir .. "
        }
        public static List<EntityLesson> GetLessonsBL()
        {
            return LessonDal.GetLessons();
        }
        public static int DeleteLessonBL(byte p)
        {
            if (p>=1)
            {
                return LessonDal.DeleteLesson(p);
            }
            else
            {
                return -1;  
            }
        }
        public static int UpdateLessonBL(EntityLesson lesson)
        {
            if (lesson.LessonName!="" && lesson.LessonName.Length>=3 && lesson.LessonName.Length<=30 && lesson.LessonID>=1)
            {
                return LessonDal.UpdateLesson(lesson);
            }
            return -1;
        }
    }
}
