﻿using System.Drawing;
using System.Windows.Forms;

namespace Constelli_DMM
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.headerLabel = new System.Windows.Forms.Label();
            this.powerButton = new System.Windows.Forms.Button();
            this.powerLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ReceiveMntText = new System.Windows.Forms.TextBox();
            this.fetchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Green;
            this.headerLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(10, 10);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(238, 16);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "DMM6500 6 1/2 DIGIT MULTIMETER";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // powerButton
            // 
            this.powerButton.BackColor = System.Drawing.Color.Green;
            this.powerButton.Enabled = false;
            this.powerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerButton.Location = new System.Drawing.Point(20, 50);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(25, 25);
            this.powerButton.TabIndex = 1;
            this.powerButton.UseVisualStyleBackColor = false;
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerLabel.Location = new System.Drawing.Point(50, 50);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(59, 16);
            this.powerLabel.TabIndex = 2;
            this.powerLabel.Text = "POWER";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Constelli_DMM.Properties.Resources.DCV;
            this.pictureBox1.Location = new System.Drawing.Point(880, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 188);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ReceiveMntText
            // 
            this.ReceiveMntText.AcceptsReturn = true;
            this.ReceiveMntText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ReceiveMntText.BackColor = System.Drawing.SystemColors.Window;
            this.ReceiveMntText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReceiveMntText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiveMntText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ReceiveMntText.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ReceiveMntText.Location = new System.Drawing.Point(880, 244);
            this.ReceiveMntText.MaxLength = 60000;
            this.ReceiveMntText.Multiline = true;
            this.ReceiveMntText.Name = "ReceiveMntText";
            this.ReceiveMntText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReceiveMntText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ReceiveMntText.Size = new System.Drawing.Size(316, 224);
            this.ReceiveMntText.TabIndex = 48;
            this.ReceiveMntText.WordWrap = false;
            // 
            // fetchButton
            // 
            this.fetchButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchButton.Location = new System.Drawing.Point(880, 474);
            this.fetchButton.Name = "fetchButton";
            this.fetchButton.Size = new System.Drawing.Size(172, 39);
            this.fetchButton.TabIndex = 49;
            this.fetchButton.Text = "Measure";
            this.fetchButton.UseVisualStyleBackColor = true;
            this.fetchButton.Click += new System.EventHandler(this.fetchButton_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1221, 565);
            this.Controls.Add(this.fetchButton);
            this.Controls.Add(this.ReceiveMntText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.headerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Multimeter UI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label measurementLabel;
        private Timer timer1;
        private Label headerLabel;
        private Button powerButton;
        private Label powerLabel;
        private Button button1;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private TextBox ReceiveMntText;
        private Button fetchButton;
    }
}

