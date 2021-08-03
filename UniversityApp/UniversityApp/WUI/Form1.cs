using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityApp.Impl;
using UniversityApp.WUI;

namespace UniversityApp
{
    public partial class Form1 : Form
    {
        private University University = new University();

        //private const string _JsonFile = "Data.json";
        public BindingList<Schedule> ScheduledCourses { get; set; }
        public Form1()
        {
            InitializeComponent();
        }


        private void dateTimePickerHours_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNewSchedule_Click(object sender, EventArgs e)
        {
            
            //get the selected cells in a DataGridView control
            //get the selected rows in a DataGridView control
                DataGridViewSelectedRowCollection selectedProfessorItem = ctrlProfessordataGridView.SelectedRows;
                DataGridViewSelectedRowCollection selectedStudentItem = ctrlStudentdataGridView.SelectedRows;
                DataGridViewSelectedRowCollection selectedCourseItem = ctrlCoursedataGridView.SelectedRows;
                //Data grid view selected cell value ID
                var professorID = (Guid)selectedProfessorItem[0].Cells[4].Value;
                var studentID = (Guid)selectedStudentItem[0].Cells[4].Value;
                var courseID = (Guid)selectedCourseItem[0].Cells[4].Value;

                dateTimePickerDays.CustomFormat = "dd/MM/yyyy";

                DateTime calendar = dateTimePickerDays.Value;

                string courseTime = dateTimePickerHours.Text;

                if (string.IsNullOrEmpty(courseTime))
                {
                    MessageBox.Show("Please choose a Course Time first! ");
                    return;
                }

           

            if (StudentCoursesValidation(calendar, studentID) == false)
                {
                    return;
                }
                else if (ProfessorCoursesValidation(calendar, professorID) == false)
                {
                    return;
                }
                else if (StudentAvailabilityValidation(courseTime, calendar, studentID) == false)
                {
                    return;
                }
                else if (ProfessorAvailabilityValidation(courseTime, calendar, professorID) == false)
                {
                    return;
                }

                //Adding new scheduled course in grid
                University.AddScheduledCourse(courseID, professorID, studentID, calendar.Date, courseTime);
                //View data to schedule Grid
                SchedulesForm schedulesForm = new SchedulesForm();
                //ctrlSchedulesdataGridView.DataSource = University.ScheduledCourses;
                schedulesForm.ctrlSchedulesdataGridView.DataSource = University.ScheduledCourses;
                schedulesForm.Show();
        }

        //1. CANNOT ADD SAME STUDENT + PROFESSOR IN SAME DATE & HOUR
        public bool StudentAvailabilityValidation(string tutorialTime, DateTime calendar, Guid studentID)
        {
            IEnumerable<Schedule> studentSchedule = University.ScheduledCourses.Where(x => x.StudentID == studentID);
            foreach (Schedule schedule in studentSchedule)
            {
                if (schedule.Date == calendar.Date)
                {
                    if (schedule.CourseTime == tutorialTime)
                    {
                        MessageBox.Show("Selected Student is in another course in selected hour");
                        return false;
                    }
                }
            }
            return true;
        }

        //  2. EACH STUDENT CANNOT HAVE MORE THAN 3 COURSES PER DAY!
        public bool StudentCoursesValidation(DateTime calendar, Guid studentID)
        {
            var studentSchedule = University.ScheduledCourses.Where(x => x.StudentID == studentID);
            var countCourses = studentSchedule.Count(x => x.Date == calendar.Date);
            if (countCourses >= 3)
            {
                MessageBox.Show("Selected student cannot have more than 3 courses per day!");
                return false;
            }
            return true;
        }

        //3. A PROFESSOR CANNOT TEACH MORE THAN 4 COURSES PER DAY
        public bool ProfessorCoursesValidation(DateTime calendar, Guid professorID)
        {
            var professorSchedule = University.ScheduledCourses.Where(x => x.ProfessorID == professorID);
            var countCourses = professorSchedule.Count(x => x.Date == calendar.Date);
            if (countCourses >= 4)
            {
                MessageBox.Show("Selected Professor cannot teach more than 4 courses per day!");
                return false;
            }
            return true;
        }

        //Check if professor is in another course same time.
        public bool ProfessorAvailabilityValidation(string tutorialTime, DateTime calendar, Guid professorID)
        {
            IEnumerable<Schedule> professorSchedule = University.ScheduledCourses.Where(x => x.ProfessorID == professorID);
            foreach (Schedule schedule in professorSchedule)
            {
                if (schedule.Date == calendar.Date)
                {
                    if (schedule.CourseTime == tutorialTime)
                    {
                        MessageBox.Show("Selected Professor is in another scheduled course in selected hour");
                        return false;
                    }
                }
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlSchedulesdataGridView.Visible = false;
            // Load data on enter!
            LoadUniversityData();
            ctrlProfessordataGridView.DataSource = University.Professors;
            ctrlStudentdataGridView.DataSource = University.Students;
            ctrlCoursedataGridView.DataSource = University.Courses;
        }

        private void LoadUniversityData()
        {
            // Display on a grid
            University.UniversityData();
        }

        private void btnViewSchedules_Click(object sender, EventArgs e)
        {
            SchedulesForm schedulesform = new SchedulesForm();
            schedulesform.Show();
        }
    }
}
