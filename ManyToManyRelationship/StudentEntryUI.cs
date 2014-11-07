using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManyToManyRelationship
{
    public partial class StudentEntryUI : Form
    {
        private List<Student> students; 
        public StudentEntryUI(List<Student> students)
        {
            InitializeComponent();
            this.students = students;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student(regNoTextBox.Text, nameTextBox.Text);
            students.Add(aStudent);

        }
    }
}
