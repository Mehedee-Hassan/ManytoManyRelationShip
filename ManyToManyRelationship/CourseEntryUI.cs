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
    public partial class CourseEntryUI : Form
    {

        List<Course> courses = new List<Course>(); 
        private Course aCourse;
        public CourseEntryUI()
        {

            InitializeComponent();
        }
        public CourseEntryUI(List<Course> courses )
        {

            InitializeComponent();
            this.courses = courses;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aCourse = new Course(codeTextBox.Text ,titleTextBox.Text);
            courses.Add(aCourse);
            
        }
    }
}
