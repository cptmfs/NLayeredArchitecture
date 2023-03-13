using BusinessLayer;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EntityLesson entityLesson= new EntityLesson();
            entityLesson.LessonName = txtLessonName.Text;
            LessonManager.LessonAddBL(entityLesson);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<EntityLesson> list = LessonManager.GetLessonsBL();
            dgwLesson.DataSource= list;

        }
    }
}
