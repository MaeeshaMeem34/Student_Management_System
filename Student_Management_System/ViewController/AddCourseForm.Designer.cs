namespace Student_Management_System
{
    partial class AddCourseForm
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
            this.buttonCancelstd = new System.Windows.Forms.Button();
            this.buttonAddStd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Topbar = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textCourseCredit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCourseName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textCourseCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Topbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelstd
            // 
            this.buttonCancelstd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelstd.Location = new System.Drawing.Point(175, 393);
            this.buttonCancelstd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelstd.Name = "buttonCancelstd";
            this.buttonCancelstd.Size = new System.Drawing.Size(98, 32);
            this.buttonCancelstd.TabIndex = 31;
            this.buttonCancelstd.Text = "Cancel";
            this.buttonCancelstd.UseVisualStyleBackColor = true;
            this.buttonCancelstd.Click += new System.EventHandler(this.buttonCancel_click);
            // 
            // buttonAddStd
            // 
            this.buttonAddStd.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAddStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStd.Location = new System.Drawing.Point(321, 393);
            this.buttonAddStd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddStd.Name = "buttonAddStd";
            this.buttonAddStd.Size = new System.Drawing.Size(98, 32);
            this.buttonAddStd.TabIndex = 30;
            this.buttonAddStd.Text = "Add";
            this.buttonAddStd.UseVisualStyleBackColor = false;
            this.buttonAddStd.Click += new System.EventHandler(this.buttonAdd_click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(181, 264);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 1);
            this.panel3.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(183, 200);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 1);
            this.panel2.TabIndex = 33;
            // 
            // Topbar
            // 
            this.Topbar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Topbar.Controls.Add(this.label7);
            this.Topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Topbar.Location = new System.Drawing.Point(0, 0);
            this.Topbar.Margin = new System.Windows.Forms.Padding(2);
            this.Topbar.Name = "Topbar";
            this.Topbar.Size = new System.Drawing.Size(800, 84);
            this.Topbar.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(52, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 47);
            this.label7.TabIndex = 0;
            this.label7.Text = "Add New Course";
            // 
            // textCourseCredit
            // 
            this.textCourseCredit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.textCourseCredit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCourseCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCourseCredit.ForeColor = System.Drawing.SystemColors.Info;
            this.textCourseCredit.Location = new System.Drawing.Point(183, 246);
            this.textCourseCredit.Margin = new System.Windows.Forms.Padding(2);
            this.textCourseCredit.Name = "textCourseCredit";
            this.textCourseCredit.Size = new System.Drawing.Size(238, 19);
            this.textCourseCredit.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Credits";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textCourseName
            // 
            this.textCourseName.BackColor = System.Drawing.Color.LightSeaGreen;
            this.textCourseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCourseName.ForeColor = System.Drawing.SystemColors.Info;
            this.textCourseName.Location = new System.Drawing.Point(181, 182);
            this.textCourseName.Margin = new System.Windows.Forms.Padding(2);
            this.textCourseName.Name = "textCourseName";
            this.textCourseName.Size = new System.Drawing.Size(240, 19);
            this.textCourseName.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 310);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Code";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextCourseCode
            // 
            this.textCourseCode.BackColor = System.Drawing.Color.LightSeaGreen;
            this.textCourseCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCourseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCourseCode.ForeColor = System.Drawing.SystemColors.Info;
            this.textCourseCode.Location = new System.Drawing.Point(181, 315);
            this.textCourseCode.Margin = new System.Windows.Forms.Padding(2);
            this.textCourseCode.Name = "TextCourseCode";
            this.textCourseCode.Size = new System.Drawing.Size(238, 19);
            this.textCourseCode.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(183, 333);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 1);
            this.panel1.TabIndex = 34;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textCourseCode);
            this.Controls.Add(this.buttonCancelstd);
            this.Controls.Add(this.buttonAddStd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Topbar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textCourseCredit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCourseName);
            this.Controls.Add(this.label8);
            this.Name = "AddCourseForm";
            this.Text = "AddCourse";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            this.Topbar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancelstd;
        private System.Windows.Forms.Button buttonAddStd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Topbar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCourseCredit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCourseName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCourseCode;
        private System.Windows.Forms.Panel panel1;
    }
}