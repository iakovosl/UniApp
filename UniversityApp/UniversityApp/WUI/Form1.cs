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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
