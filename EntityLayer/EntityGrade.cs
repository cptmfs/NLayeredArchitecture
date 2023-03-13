using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityGrade
    {
        public int GradeID { get; set; }
        public int Student { get; set; }
        public byte Lesson { get; set; }
        public byte LessonGrade { get; set; }
    }
}
