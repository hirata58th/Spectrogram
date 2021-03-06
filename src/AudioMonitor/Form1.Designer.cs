﻿namespace AudioMonitor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetMicrophone = new System.Windows.Forms.Button();
            this.cbMicrophones = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDisplay = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbDecibels = new System.Windows.Forms.CheckBox();
            this.tbIntensity = new System.Windows.Forms.TrackBar();
            this.nudIntensity = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbColormap = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbTicks = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntensity)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetMicrophone);
            this.groupBox1.Controls.Add(this.cbMicrophones);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 47);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Microphone";
            // 
            // btnSetMicrophone
            // 
            this.btnSetMicrophone.Location = new System.Drawing.Point(133, 18);
            this.btnSetMicrophone.Name = "btnSetMicrophone";
            this.btnSetMicrophone.Size = new System.Drawing.Size(61, 23);
            this.btnSetMicrophone.TabIndex = 1;
            this.btnSetMicrophone.Text = "open";
            this.btnSetMicrophone.UseVisualStyleBackColor = true;
            this.btnSetMicrophone.Click += new System.EventHandler(this.BtnSetMicrophone_Click);
            // 
            // cbMicrophones
            // 
            this.cbMicrophones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMicrophones.FormattingEnabled = true;
            this.cbMicrophones.Location = new System.Drawing.Point(6, 19);
            this.cbMicrophones.Name = "cbMicrophones";
            this.cbMicrophones.Size = new System.Drawing.Size(121, 21);
            this.cbMicrophones.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1045, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(118, 17);
            this.lblStatus.Text = "toolStripStatusLabel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1021, 408);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDisplay);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 47);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display";
            // 
            // cbDisplay
            // 
            this.cbDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisplay.FormattingEnabled = true;
            this.cbDisplay.Location = new System.Drawing.Point(6, 19);
            this.cbDisplay.Name = "cbDisplay";
            this.cbDisplay.Size = new System.Drawing.Size(127, 21);
            this.cbDisplay.TabIndex = 0;
            this.cbDisplay.SelectedIndexChanged += new System.EventHandler(this.CbDisplay_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbDecibels);
            this.groupBox3.Controls.Add(this.tbIntensity);
            this.groupBox3.Controls.Add(this.nudIntensity);
            this.groupBox3.Location = new System.Drawing.Point(572, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 47);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Intensity";
            // 
            // cbDecibels
            // 
            this.cbDecibels.AutoSize = true;
            this.cbDecibels.Location = new System.Drawing.Point(79, 22);
            this.cbDecibels.Name = "cbDecibels";
            this.cbDecibels.Size = new System.Drawing.Size(65, 17);
            this.cbDecibels.TabIndex = 2;
            this.cbDecibels.Text = "decibels";
            this.cbDecibels.UseVisualStyleBackColor = true;
            // 
            // tbIntensity
            // 
            this.tbIntensity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIntensity.AutoSize = false;
            this.tbIntensity.LargeChange = 1;
            this.tbIntensity.Location = new System.Drawing.Point(150, 11);
            this.tbIntensity.Maximum = 50;
            this.tbIntensity.Name = "tbIntensity";
            this.tbIntensity.Size = new System.Drawing.Size(305, 30);
            this.tbIntensity.TabIndex = 1;
            this.tbIntensity.Value = 10;
            this.tbIntensity.Scroll += new System.EventHandler(this.TbIntensity_Scroll);
            // 
            // nudIntensity
            // 
            this.nudIntensity.DecimalPlaces = 1;
            this.nudIntensity.Location = new System.Drawing.Point(6, 19);
            this.nudIntensity.Name = "nudIntensity";
            this.nudIntensity.Size = new System.Drawing.Size(67, 20);
            this.nudIntensity.TabIndex = 0;
            this.nudIntensity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbColormap);
            this.groupBox4.Location = new System.Drawing.Point(363, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(139, 47);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Colormap";
            // 
            // cbColormap
            // 
            this.cbColormap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbColormap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColormap.FormattingEnabled = true;
            this.cbColormap.Location = new System.Drawing.Point(6, 19);
            this.cbColormap.Name = "cbColormap";
            this.cbColormap.Size = new System.Drawing.Size(127, 21);
            this.cbColormap.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbTicks);
            this.groupBox5.Location = new System.Drawing.Point(508, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(58, 47);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Misc";
            // 
            // cbTicks
            // 
            this.cbTicks.AutoSize = true;
            this.cbTicks.Location = new System.Drawing.Point(6, 21);
            this.cbTicks.Name = "cbTicks";
            this.cbTicks.Size = new System.Drawing.Size(48, 17);
            this.cbTicks.TabIndex = 3;
            this.cbTicks.Text = "ticks";
            this.cbTicks.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1045, 498);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Audio Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntensity)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSetMicrophone;
        private System.Windows.Forms.ComboBox cbMicrophones;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbDisplay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudIntensity;
        private System.Windows.Forms.TrackBar tbIntensity;
        private System.Windows.Forms.CheckBox cbDecibels;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbColormap;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbTicks;
    }
}

