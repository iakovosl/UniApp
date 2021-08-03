
namespace UniversityApp.WUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrlViewSchedules = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ctrlViewStudents = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ctrlViewSchedules);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.ctrlViewStudents);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 573);
            this.panel1.TabIndex = 0;
            // 
            // ctrlViewSchedules
            // 
            this.ctrlViewSchedules.Location = new System.Drawing.Point(0, 290);
            this.ctrlViewSchedules.Name = "ctrlViewSchedules";
            this.ctrlViewSchedules.Size = new System.Drawing.Size(200, 39);
            this.ctrlViewSchedules.TabIndex = 4;
            this.ctrlViewSchedules.Text = "View Schedules";
            this.ctrlViewSchedules.UseVisualStyleBackColor = true;
            this.ctrlViewSchedules.Click += new System.EventHandler(this.ctrlViewSchedules_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "View Courses";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "View Professors";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ctrlViewStudents
            // 
            this.ctrlViewStudents.Location = new System.Drawing.Point(0, 147);
            this.ctrlViewStudents.Name = "ctrlViewStudents";
            this.ctrlViewStudents.Size = new System.Drawing.Size(200, 46);
            this.ctrlViewStudents.TabIndex = 1;
            this.ctrlViewStudents.Text = "View Students";
            this.ctrlViewStudents.UseVisualStyleBackColor = true;
            this.ctrlViewStudents.Click += new System.EventHandler(this.ctrlViewStudents_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(194, 116);
            this.panelLogo.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 573);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ctrlViewStudents;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button ctrlViewSchedules;
    }
}