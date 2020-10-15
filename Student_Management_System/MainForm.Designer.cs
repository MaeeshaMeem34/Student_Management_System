namespace Student_Management_System
{
    partial class MainForm
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelCourseSubMenu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCourse = new System.Windows.Forms.Button();
            this.panelStudentSubMenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonStudentList = new System.Windows.Forms.Button();
            this.buttonStudentAdd = new System.Windows.Forms.Button();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelChildform = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelCourseSubMenu.SuspendLayout();
            this.panelStudentSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelSideMenu.Controls.Add(this.panelCourseSubMenu);
            this.panelSideMenu.Controls.Add(this.buttonCourse);
            this.panelSideMenu.Controls.Add(this.panelStudentSubMenu);
            this.panelSideMenu.Controls.Add(this.buttonStudent);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 749);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelCourseSubMenu
            // 
            this.panelCourseSubMenu.Controls.Add(this.button5);
            this.panelCourseSubMenu.Controls.Add(this.button4);
            this.panelCourseSubMenu.Controls.Add(this.button1);
            this.panelCourseSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCourseSubMenu.Location = new System.Drawing.Point(0, 307);
            this.panelCourseSubMenu.Name = "panelCourseSubMenu";
            this.panelCourseSubMenu.Size = new System.Drawing.Size(250, 112);
            this.panelCourseSubMenu.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(0, 56);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 28);
            this.button5.TabIndex = 2;
            this.button5.Text = "See Course";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(0, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 28);
            this.button4.TabIndex = 1;
            this.button4.Text = "See Course";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Course";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // buttonCourse
            // 
            this.buttonCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCourse.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCourse.Location = new System.Drawing.Point(0, 267);
            this.buttonCourse.Name = "buttonCourse";
            this.buttonCourse.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCourse.Size = new System.Drawing.Size(250, 40);
            this.buttonCourse.TabIndex = 3;
            this.buttonCourse.Text = "Courses";
            this.buttonCourse.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonCourse.UseVisualStyleBackColor = true;
            this.buttonCourse.Click += new System.EventHandler(this.buttonCourse_click);
            // 
            // panelStudentSubMenu
            // 
            this.panelStudentSubMenu.Controls.Add(this.button3);
            this.panelStudentSubMenu.Controls.Add(this.button2);
            this.panelStudentSubMenu.Controls.Add(this.buttonStudentList);
            this.panelStudentSubMenu.Controls.Add(this.buttonStudentAdd);
            this.panelStudentSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudentSubMenu.Location = new System.Drawing.Point(0, 148);
            this.panelStudentSubMenu.Name = "panelStudentSubMenu";
            this.panelStudentSubMenu.Size = new System.Drawing.Size(250, 119);
            this.panelStudentSubMenu.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(0, 84);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(250, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Statistics";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(0, 56);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(250, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit Student";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonStudentList
            // 
            this.buttonStudentList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudentList.FlatAppearance.BorderSize = 0;
            this.buttonStudentList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStudentList.Location = new System.Drawing.Point(0, 28);
            this.buttonStudentList.Name = "buttonStudentList";
            this.buttonStudentList.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonStudentList.Size = new System.Drawing.Size(250, 28);
            this.buttonStudentList.TabIndex = 1;
            this.buttonStudentList.Text = "Student List";
            this.buttonStudentList.UseVisualStyleBackColor = true;
            this.buttonStudentList.Click += new System.EventHandler(this.buttonStudentList_Click);
            // 
            // buttonStudentAdd
            // 
            this.buttonStudentAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudentAdd.FlatAppearance.BorderSize = 0;
            this.buttonStudentAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStudentAdd.Location = new System.Drawing.Point(0, 0);
            this.buttonStudentAdd.Name = "buttonStudentAdd";
            this.buttonStudentAdd.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonStudentAdd.Size = new System.Drawing.Size(250, 28);
            this.buttonStudentAdd.TabIndex = 0;
            this.buttonStudentAdd.Text = "Add Student";
            this.buttonStudentAdd.UseVisualStyleBackColor = true;
            this.buttonStudentAdd.Click += new System.EventHandler(this.buttonStudentAdd_Click);
            // 
            // buttonStudent
            // 
            this.buttonStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudent.FlatAppearance.BorderSize = 0;
            this.buttonStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudent.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStudent.Location = new System.Drawing.Point(0, 108);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonStudent.Size = new System.Drawing.Size(250, 40);
            this.buttonStudent.TabIndex = 1;
            this.buttonStudent.Text = "Student";
            this.buttonStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudent.UseVisualStyleBackColor = true;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 108);
            this.panel1.TabIndex = 0;
            // 
            // panelChildform
            // 
            this.panelChildform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.panelChildform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildform.Location = new System.Drawing.Point(250, 0);
            this.panelChildform.Name = "panelChildform";
            this.panelChildform.Size = new System.Drawing.Size(932, 749);
            this.panelChildform.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1182, 749);
            this.Controls.Add(this.panelChildform);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "secondForm";
            this.panelSideMenu.ResumeLayout(false);
            this.panelCourseSubMenu.ResumeLayout(false);
            this.panelStudentSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelCourseSubMenu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCourse;
        private System.Windows.Forms.Panel panelStudentSubMenu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonStudentList;
        private System.Windows.Forms.Button buttonStudentAdd;
        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChildform;
    }
}