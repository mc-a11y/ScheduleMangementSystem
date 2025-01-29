namespace ScheduleManagement.Forms
{
    partial class UpdateScheduleForm
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
            label2 = new Label();
            label3 = new Label();
            lblDate = new Label();
            txtScheduleName = new TextBox();
            gboxUpdateForm = new GroupBox();
            txtScheduleCourse = new TextBox();
            label4 = new Label();
            btnSaveSchedule = new Button();
            rtxtRoom = new RichTextBox();
            pictureBox1 = new PictureBox();
            gboxUpdateForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSteelBlue;
            label1.Location = new Point(173, 19);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "UpdateSchedule";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSteelBlue;
            label2.Location = new Point(29, 54);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "Subject Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.Location = new Point(29, 113);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Course";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.FromArgb(192, 255, 255);
            lblDate.Location = new Point(29, 163);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 15);
            lblDate.TabIndex = 3;
            // 
            // txtScheduleName
            // 
            txtScheduleName.Location = new Point(160, 46);
            txtScheduleName.Name = "txtScheduleName";
            txtScheduleName.Size = new Size(128, 23);
            txtScheduleName.TabIndex = 4;
            // 
            // gboxUpdateForm
            // 
            gboxUpdateForm.BackColor = Color.FromArgb(192, 255, 255);
            gboxUpdateForm.Controls.Add(txtScheduleCourse);
            gboxUpdateForm.Controls.Add(label4);
            gboxUpdateForm.Controls.Add(label1);
            gboxUpdateForm.Controls.Add(label2);
            gboxUpdateForm.Controls.Add(label3);
            gboxUpdateForm.Controls.Add(lblDate);
            gboxUpdateForm.Controls.Add(txtScheduleName);
            gboxUpdateForm.Controls.Add(btnSaveSchedule);
            gboxUpdateForm.Controls.Add(rtxtRoom);
            gboxUpdateForm.Controls.Add(pictureBox1);
            gboxUpdateForm.Location = new Point(-1, -2);
            gboxUpdateForm.Name = "gboxUpdateForm";
            gboxUpdateForm.Size = new Size(372, 233);
            gboxUpdateForm.TabIndex = 5;
            gboxUpdateForm.TabStop = false;
            // 
            // txtScheduleCourse
            // 
            txtScheduleCourse.Location = new Point(160, 79);
            txtScheduleCourse.Name = "txtScheduleCourse";
            txtScheduleCourse.Size = new Size(128, 23);
            txtScheduleCourse.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSteelBlue;
            label4.Location = new Point(29, 82);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 6;
            label4.Text = "Room";
            // 
            // btnSaveSchedule
            // 
            btnSaveSchedule.BackColor = Color.BlanchedAlmond;
            btnSaveSchedule.Location = new Point(218, 151);
            btnSaveSchedule.Name = "btnSaveSchedule";
            btnSaveSchedule.Size = new Size(70, 27);
            btnSaveSchedule.TabIndex = 2;
            btnSaveSchedule.Text = "Update";
            btnSaveSchedule.UseVisualStyleBackColor = false;
            btnSaveSchedule.Click += btnSaveSchedule_Click;
            // 
            // rtxtRoom
            // 
            rtxtRoom.Location = new Point(160, 110);
            rtxtRoom.Name = "rtxtRoom";
            rtxtRoom.Size = new Size(128, 31);
            rtxtRoom.TabIndex = 0;
            rtxtRoom.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ScheduleManagementSystem.Properties.Resources.ajsh;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // UpdateScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(367, 217);
            Controls.Add(gboxUpdateForm);
            Name = "UpdateScheduleForm";
            Text = "UpdateScheduleForm";
            gboxUpdateForm.ResumeLayout(false);
            gboxUpdateForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblDate;
        private TextBox txtScheduleName;
        private GroupBox gboxUpdateForm;
        private RichTextBox rtxtRoom;
        private Button btnSaveSchedule;
        private PictureBox pictureBox1;
        private TextBox txtScheduleCourse;
        private Label label4;
    }
}