using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsExample03
{
    public partial class Form1 : Form
    {
        private List<Student> _students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var student = new Student();
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.CourseName = txtCourseName.Text;

            if (!string.IsNullOrWhiteSpace(txtStudentNumber.Text))
            {
                student.StudentNumber = int.Parse(txtStudentNumber.Text);
            }

            _students.Add(student);

            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtStudentNumber.Text = string.Empty;
            txtCourseName.Text = string.Empty;

            //txtFirstName.Clear();

            foreach (var control in Controls)
            {
                // Upcast
                if (control is TextBox)
                {
                    var textBox = (TextBox)control;
                    //textBox.Text = string.Empty;
                    textBox.Clear();
                }
            }

            //lstStudents.Items.Add(student); // 1. yöntem

            //lstStudents.Items.Add(student.FullName); // Alternatif 1. yöntem
            // Görünür birime sadece isimleri eklerim

            // 2. yöntem, üsttekinden daha yakışıklı
            // (gerçek bir db senaryosu varmış gibi)
            //lstStudents.Items.Clear();
            //foreach (var item in _students)
            //{
            //    lstStudents.Items.Add(item.FullName);
            //}

            lstStudents.DataSource = null;
            lstStudents.DisplayMember = "FullName";
            lstStudents.DataSource = _students;

            //var namesList = new List<string>();
            //foreach (var item in _students)
            //{
            //    namesList.Add(item.FullName);
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstStudents.DisplayMember = "FullName";
        }
    }
}
