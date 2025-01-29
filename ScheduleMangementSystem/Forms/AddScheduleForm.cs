using ScheduleManagement.Data;
using ScheduleManagement.Controllers;
using ScheduleManagement.DAO;
using ScheduleManagement.Service;
using ScheduleManagement.Data;

namespace ScheduleManagement.Forms
{
    public partial class AddScheduleForm : Form
    {
        private readonly ScheduleController _scheduleController;
        public event Action ScheduleAdded;

        public AddScheduleForm()
        {

            InitializeComponent();
            var context = new ApplicationDbContext();
            var scheduleRepository = new ScheduleRepository(context);
            var scheduleService = new ScheduleService(scheduleRepository);
            _scheduleController = new ScheduleController(scheduleService);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {

            string scheduleName = txtScheduleName.Text.Trim();
            string room = rtxtRoom.Text.Trim();
            string scheduleCourse = txtScheduleCourse.Text.Trim();

            if (string.IsNullOrEmpty(scheduleName) || string.IsNullOrEmpty(room) || string.IsNullOrEmpty(scheduleCourse))
            {
                MessageBox.Show("You need to fill in all the fields!", "Warning");
                return;
            }


            _scheduleController.AddSchedule(scheduleName,room,scheduleCourse);
            MessageBox.Show($"Added Successfully!\nDate: {DateTime.Now:yyyy-MM-dd}", "Information");


            ScheduleAdded?.Invoke();
            this.Close();
        }

        private void txtScheduleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
