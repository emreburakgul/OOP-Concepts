using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var student = new Student();
            student.FirstName = txtFirstName.Text.Trim();
            student.LastName = txtLastName.Text.Trim();
            
            if (!string.IsNullOrWhiteSpace(txtStudentNumber.Text))
            {
                student.StudentNumber = int.Parse(txtStudentNumber.Text);
            }

            // Ya da 
            //var firstName = txtFirstName.Text.Trim();
            //var lastName = txtLastName.Text.Trim();
            //var studentNumber = int.Parse(txtStudentNumber.Text);
            //var student01 = new Student(firstName, lastName, studentNumber);

            lstStudents.Items.Add(student);
        }
    }
}
