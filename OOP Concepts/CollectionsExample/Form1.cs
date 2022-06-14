using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsExample
{
    public partial class Form1 : Form
    {
        private List<string> _data = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblStudents.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _data.Add(txtStudentName.Text);

            lblStudents.Text = string.Empty;
            foreach (var item in _data)
            {
                lblStudents.Text += item + "\n\r";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _data.Remove(txtStudentName.Text);

            lblStudents.Text = string.Empty;
            foreach (var item in _data)
            {
                lblStudents.Text += $"{item}\n\r";
            }
        }
    }
}
