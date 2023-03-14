using BusinessLayer;
using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void btnList_Click(object sender, EventArgs e)
        {
            List<EntityStudent> students = StudentManager.GetStudentsBL();
            dgwLesson.DataSource= students;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int deger = int.Parse(txtId.Text);
            EntityStudent student = new EntityStudent();
            student.StudentID = deger;
            StudentManager.DeleteStudentBL(deger);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EntityStudent es = new EntityStudent();
            es.StudentID = int.Parse(txtId.Text);
            es.FirstName = txtFirstName.Text;
            es.LastName = txtLastName.Text;
            es.StudentNumber = mskNo.Text;
            es.Department = txtDepartment.Text;
            StudentManager.StudentAddBL(es);
        }

        private void dgwLesson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgwLesson.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgwLesson.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgwLesson.Rows[e.RowIndex].Cells[2].Value.ToString();
            mskNo.Text = dgwLesson.Rows[e.RowIndex].Cells[3].Value.ToString();
            mskSearch.Text = dgwLesson.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDepartment.Text = dgwLesson.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //int sID = int.Parse(mskNo.Text);
            //EntityStudent es = new EntityStudent();
            //es.StudentNumber = sID.ToString() ;
            //StudentManager.SearchStudentBL(sID);
            //dgwLesson.DataSource = sID;
        }
    }
}
