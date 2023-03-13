using BusinessLayer;
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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EntityStudent student = new EntityStudent();
            student.FirstName= txtFirstName.Text;
            student.LastName= txtLastName.Text;
            student.StudentNumber=mskNo.Text;
            student.Department=txtDepartment.Text;
            StudentManager.StudentAddBL(student);
            MessageBox.Show("Adding Student Successfull","Student Add",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
