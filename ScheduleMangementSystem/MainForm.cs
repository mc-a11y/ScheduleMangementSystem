using ScheduleManagement.Controllers;
using ScheduleManagement.DAO;
using ScheduleManagement.Data;
using ScheduleManagement.Forms;
using ScheduleManagement.Models;
using ScheduleManagement.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScheduleManagement
{
    public partial class MainForm : Form
    {
        public readonly ScheduleController _scheduleController;
        public MainForm()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var scheduleRepository = new ScheduleRepository(context);
            var scheduleService = new ScheduleService(scheduleRepository);
            _scheduleController = new ScheduleController(scheduleService);
        }
        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            var addScheduleForm = new AddScheduleForm();
            addScheduleForm.ScheduleAdded += LoadSchedule;
            addScheduleForm.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSchedule();
        }
        private void LoadSchedule()
        {
            var schedule = _scheduleController.GetAllSchedule();
            schedulePanel.Controls.Clear();
            foreach (var Schedule in schedule)
            {
                AddScheduleCard(Schedule);
            }
        }

        private void AddScheduleCard(ScheduleItem scheduleItem)
        {
            var cardPanel = new Panel
            {
                Size = new Size(370, 160),
                BackColor = Color.CadetBlue,
                Margin = new Padding(30),
                Padding = new Padding(10)
            };

            var deleteIcon = new Label
            {
                Text = "✖",
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = Color.Red,
                Cursor = Cursors.Hand,
                Location = new Point(cardPanel.Width - 30, 5),
                AutoSize = true
            };
            deleteIcon.Click += (sender, e) => DeleteSchedule(scheduleItem);
            cardPanel.Controls.Add(deleteIcon);

            var editIcon = new Label
            {
                Text = "✏",
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = Color.Gold,
                Cursor = Cursors.Hand,
                Location = new Point(cardPanel.Width - 60, 5),
                AutoSize = true
            };
            editIcon.Click += (sender, e) => UpdateSchedule(scheduleItem);
            cardPanel.Controls.Add(editIcon);

            var courseLabel = new Label
            {
                Text = $"{scheduleItem.ScheduleName}",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.DarkSlateGray,
                Location = new Point(10, 10),
                AutoSize = true
            };
            cardPanel.Controls.Add(courseLabel);

            var nameLabel = new Label
            {
                Text = $"{scheduleItem.ScheduleRoom}",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.DimGray,
                Location = new Point(10, 35),
                AutoSize = true
            };
            cardPanel.Controls.Add(nameLabel);

            var courselabel = new Label
            {
                Text = $"{scheduleItem.ScheduleCourse}",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.DimGray,
                Location = new Point(10, 35),
                AutoSize = true
            };
            cardPanel.Controls.Add(courseLabel);


            var viewDetails = new LinkLabel
            {
                Text = "View Details",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.Blue,
                Location = new Point(20, 55),
                AutoSize = true
            };

            viewDetails.Location = new Point(cardPanel.Width - viewDetails.Width - 10, cardPanel.Height - viewDetails.Height - 10);
            viewDetails.LinkClicked += (sender, e) => ShowScheduleDetails(scheduleItem);
            cardPanel.Controls.Add(viewDetails);

            schedulePanel.Controls.Add(cardPanel);
        }

        private void ShowScheduleDetails(ScheduleItem scheduleItem)
        {
            string details = $"ClassName:{scheduleItem.ScheduleName}\n\n" +
                $"Course: {scheduleItem.ScheduleCourse}\n\n" +
                $"Room: {scheduleItem.ScheduleRoom}";
            MessageBox.Show(details, "Schedule Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateSchedule(ScheduleItem scheduleItem)
        {

            var updateScheduleForm = new UpdateScheduleForm(scheduleItem);

            updateScheduleForm.scheduleUpdated += (updatedSchedule) =>
            {
                LoadSchedule();
            };

            updateScheduleForm.ShowDialog();
        }

        private void DeleteSchedule(ScheduleItem scheduleItem)
        {
            var confirmResult = MessageBox.Show($"Are you sure to delete {scheduleItem.ScheduleName}?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _scheduleController.DeleteSchedule(scheduleItem.Id);
                LoadSchedule();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void schedulePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

