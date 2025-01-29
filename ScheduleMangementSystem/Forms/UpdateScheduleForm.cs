using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheduleManagement.Controllers;
using ScheduleManagement.DAO;
using ScheduleManagement.Data;
using ScheduleManagement.Models;
using ScheduleManagement.Service;
using ScheduleManagement.Data;

namespace ScheduleManagement.Forms
{
    public partial class UpdateScheduleForm : Form
    {
        private readonly ScheduleController _scheduleController;
        private readonly string scheduleName;

        public event Action<ScheduleItem> scheduleUpdated;
        private ScheduleItem _schedule;
        private object rtxtCourse;

        public UpdateScheduleForm(ScheduleItem scheduleItem)
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var scheduleRepository = new ScheduleRepository(context);
            var scheduleService = new ScheduleService(scheduleRepository);
            _scheduleController = new ScheduleController(scheduleService);

            _schedule = scheduleItem;
            PopulateFormFields();
        }
        private void PopulateFormFields()
        {
            txtScheduleName.Text = _schedule.ScheduleName;
            rtxtRoom.Text = _schedule.ScheduleRoom;
            txtScheduleCourse.Text = _schedule.ScheduleCourse;
            lblDate.Text = $"Last Updated: {_schedule.Date:yyyy-MM-dd}";
        }
        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            string noteName = txtScheduleName.Text;
            string room = rtxtRoom.Text;
            string course = txtScheduleCourse.Text;

            _schedule.ScheduleName = scheduleName;
            _schedule.ScheduleRoom = room;
            _schedule.ScheduleCourse = course;
            _schedule.Date = DateTime.Now;

            scheduleUpdated?.Invoke(_schedule);
            this.Close();
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
