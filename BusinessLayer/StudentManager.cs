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
    }
}
