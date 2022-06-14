using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsExample02
{
    public partial class Form1 : Form
    {
        private List<Student> _students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblStudents.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Bu aşamayı veritabanına kaydetme aşaması gibi düşünün
            var student = new Student();
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;

            _students.Add(student);

            lblStudents.Text = string.Empty;

            foreach (var item in _students)
            {
                lblStudents.Text += string.Format("{0}\n\r", item.FullName);
            }
        }
    }
}
