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
    public partial class MainUI : Form
    {
        List<Student> students = new List<Student>();

        List<Course> courses = new List<Course>();
 
        List<Enrollment> enrollments = new List<Enrollment>();

        public MainUI()
        {
            InitializeComponent();
        }

        private void studentEntryButton_Click(object sender, EventArgs e)
        {
            StudentEntryUI aStudentEntryUI = new StudentEntryUI(students);
            aStudentEntryUI.Show();
        }

        private void courseEntryButton_Click(object sender, EventArgs e)
        {
            CourseEntryUI aCourseEntryUI = new CourseEntryUI(courses);
            aCourseEntryUI.Show();
        }

        private void enrollmentButton_Click(object sender, EventArgs e)
        {
            EnrollmentUI aEnrollmentUI = new EnrollmentUI(students, courses, enrollments);
            aEnrollmentUI.Show();

           

        }

        private void SowGrid(List<Enrollment> list)
        {
            
            {
                List<string> aList = new List<string>();

                aList.Add(list[0].AStudent.RegNo);
                aList.Add(list[0].CourseTaken.Title);
                aList.Add(list[0].EnrolledDate.ToString());


                MessageBox.Show(list[0].CourseTaken.Title);
                //enrollmentDataGridView.DataSource = aList;
                enrollmentDataGridView.Rows.Add(aList[0],aList[1],aList[2]);

            }

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            SowGrid(enrollments);
        }
    }
}
