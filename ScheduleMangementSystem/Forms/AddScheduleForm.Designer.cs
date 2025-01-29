
using ScheduleManagement.Controllers;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace ScheduleManagement.Forms
{
    partial class AddScheduleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblDate = new Label();
            label3 = new Label();
            txtScheduleName = new TextBox();
            rtxtRoom = new RichTextBox();
            btnSaveSchedule = new Button();
            gboxAddForm = new GroupBox();
            txtScheduleCourse = new TextBox();
            label2 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            gboxAddForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSteelBlue;
            label1.Location = new Point(79, 88);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Subject Name";
            label1.Click += label1_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(36, 183);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 15);
            lblDate.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.Location = new Point(79, 154);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Room";
            // 
            // txtScheduleName
            // 
            txtScheduleName.Location = new Point(187, 78);
            txtScheduleName.Name = "txtScheduleName";
            txtScheduleName.Size = new Size(115, 23);
            txtScheduleName.TabIndex = 3;
            txtScheduleName.TextChanged += txtScheduleName_TextChanged;
            // 
            // rtxtRoom
            // 
            rtxtRoom.Location = new Point(204, 151);
            rtxtRoom.Name = "rtxtRoom";
            rtxtRoom.Size = new Size(115, 30);
            rtxtRoom.TabIndex = 4;
            rtxtRoom.Text = "";
            // 
            // btnSaveSchedule
            // 
            btnSaveSchedule.BackColor = Color.BlanchedAlmond;
            btnSaveSchedule.Location = new Point(226, 195);
            btnSaveSchedule.Name = "btnSaveSchedule";
            btnSaveSchedule.Size = new Size(67, 23);
            btnSaveSchedule.TabIndex = 6;
            btnSaveSchedule.Text = "Save";
            btnSaveSchedule.UseVisualStyleBackColor = false;
            btnSaveSchedule.Click += btnSaveSchedule_Click;
            // 
            // gboxAddForm
            // 
            gboxAddForm.BackColor = Color.FromArgb(192, 255, 255);
            gboxAddForm.Controls.Add(txtScheduleCourse);
            gboxAddForm.Controls.Add(label2);
            gboxAddForm.Controls.Add(rtxtRoom);
            gboxAddForm.Controls.Add(btnSaveSchedule);
            gboxAddForm.Controls.Add(label4);
            gboxAddForm.Controls.Add(label3);
            gboxAddForm.Controls.Add(lblDate);
            gboxAddForm.Controls.Add(label1);
            gboxAddForm.Controls.Add(pictureBox1);
            gboxAddForm.Location = new Point(-17, -2);
            gboxAddForm.Name = "gboxAddForm";
            gboxAddForm.Size = new Size(452, 309);
            gboxAddForm.TabIndex = 7;
            gboxAddForm.TabStop = false;
            // 
            // txtScheduleCourse
            // 
            txtScheduleCourse.Location = new Point(204, 115);
            txtScheduleCourse.Name = "txtScheduleCourse";
            txtScheduleCourse.Size = new Size(115, 23);
            txtScheduleCourse.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSteelBlue;
            label2.Location = new Point(79, 123);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 7;
            label2.Text = "Course";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSteelBlue;
            label4.Location = new Point(238, 52);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Schedule";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ScheduleManagementSystem.Properties.Resources.ajsh1;
            pictureBox1.Location = new Point(6, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(446, 289);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // AddScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(426, 282);
            Controls.Add(txtScheduleName);
            Controls.Add(gboxAddForm);
            Name = "AddScheduleForm";
            Text = "AddScheduleForm";
            gboxAddForm.ResumeLayout(false);
            gboxAddForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnSaveSchedule_Click(object sender, EventArgs e, ScheduleController scheduleController)
        {
        }


        #endregion

        private Label label1;
        private Label lblDate;
        private Label label3;
        private TextBox txtScheduleName;
        private RichTextBox rtxtRoom;
        private Button btnSaveSchedule;
        private GroupBox gboxAddForm;
        private Label label4;
        private PictureBox pictureBox1;
        private TextBox txtScheduleCourse;
        private Label label2;
    }
}