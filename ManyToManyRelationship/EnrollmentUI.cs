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
    public partial class EnrollmentUI : Form
    {

        private Student aStudent;
        private Course aCourse;
        private String date;
        private List<Enrollment> enrollments; 

        public EnrollmentUI(List<Student> students, List<Course> courses, List<Enrollment> enrollments )
        {
            InitializeComponent();
            PopulateStudentComboBox(students);
            PopulateCourseCombo(courses);
            PopulateGridView(enrollments);
            this.enrollments = enrollments;
        }

        private void PopulateGridView(List<Enrollment> enrollments)
        {
            
        }

        private void PopulateCourseCombo(List<Course> courses)
        {
            courseComboBox.DisplayMember = "Title";
            courseComboBox.ValueMember = "Title";
            courseComboBox.DataSource = courses;

        }

        private void PopulateStudentComboBox(List<Student> students)
        {
            studentComboBox.DisplayMember = "RegNo";
            studentComboBox.ValueMember = "RegNo";
            studentComboBox.DataSource = students;

            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aStudent = new Student();
            
            aStudent.RegNo = studentComboBox.Text;
            aCourse = new Course();
            aCourse.Title = courseComboBox.Text;

            
            DateTime date = enrollmentDateTimePicker.Value;


            Enrollment aEnrollment = new Enrollment();
            aEnrollment.AStudent = aStudent;
            aEnrollment.CourseTaken = aCourse;
            aEnrollment.EnrolledDate = date;

            enrollments.Add(aEnrollment);
        }
    }
}
