namespace ScheduleManagement
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            schedulePanel = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnAddSchedule = new Button();
            label1 = new Label();
            schedulePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // schedulePanel
            // 
            schedulePanel.AutoScroll = true;
            schedulePanel.BackColor = Color.Thistle;
            schedulePanel.Controls.Add(pictureBox3);
            schedulePanel.Controls.Add(pictureBox2);
            schedulePanel.Controls.Add(pictureBox1);
            schedulePanel.Dock = DockStyle.Top;
            schedulePanel.Location = new Point(0, 30);
            schedulePanel.Name = "schedulePanel";
            schedulePanel.Size = new Size(442, 256);
            schedulePanel.TabIndex = 0;
            schedulePanel.Paint += schedulePanel_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = ScheduleManagementSystem.Properties.Resources.OIP23;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(442, 259);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = ScheduleManagementSystem.Properties.Resources.OIP23;
            pictureBox2.Location = new Point(3, 268);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(452, 0);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = ScheduleManagementSystem.Properties.Resources.OIP23;
            pictureBox1.Location = new Point(3, 274);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(589, 0);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(schedulePanel);
            panel1.Controls.Add(btnAddSchedule);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 286);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btnAddSchedule
            // 
            btnAddSchedule.BackColor = SystemColors.GradientActiveCaption;
            btnAddSchedule.Dock = DockStyle.Top;
            btnAddSchedule.Location = new Point(0, 0);
            btnAddSchedule.Name = "btnAddSchedule";
            btnAddSchedule.Size = new Size(442, 30);
            btnAddSchedule.TabIndex = 1;
            btnAddSchedule.Text = "Add Schedule";
            btnAddSchedule.UseVisualStyleBackColor = false;
            btnAddSchedule.Click += btnAddSchedule_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "MY SCHEDULE";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 284);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Form1";
            schedulePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel schedulePanel;
        private Panel panel1;
        private Button btnAddSchedule;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
