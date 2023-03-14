using DataAccessLayer;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentManager
    {
        public static int StudentAddBL(EntityStudent student)
        {
            if (student.FirstName!="" && student.FirstName.Length>=3 && student.FirstName.Length<=30 && student.LastName!="" && student.Department!="" && student.StudentNumber.Length==5)
            {
                return StudentDal.StudentAdd(student);
            }
                return -1;
        }
        public static List<EntityStudent> GetStudentsBL()
        {
            return StudentDal.GetStudents();
        }
        public static int DeleteStudentBL(int p)
        {
            if (p>=1)
            {
                return StudentDal.DeleteStudent(p);

            }
            else
            {
                return -1;
            }
        }
        public static int UpdateStudentBL(EntityStudent entityStudent)
        {
            if (entityStudent.FirstName.Length>=3 && entityStudent.LastName.Length>=3 && entityStudent.StudentID>=1 && entityStudent.Department!="" && entityStudent.Department.Length>=3 && entityStudent.Department.Length<=30 )
            {
                return StudentDal.UpdateStudent(entityStudent);

            }
            return -1;
        }
        public static int SearchStudentBL(int id)
        {
            if (id==5)
            {
                return StudentDal.SearchStudent(id);
            }
            return -1;
        }
    }
}
