namespace Bai2_7
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
            this.UnSetButton = new System.Windows.Forms.Button();
            this.SetButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SetTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CountDown = new System.Windows.Forms.Label();
            this.SecBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MinBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HourBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NowTime = new System.Windows.Forms.Label();
            this.NowTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UnSetButton
            // 
            this.UnSetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.UnSetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnSetButton.ForeColor = System.Drawing.Color.Black;
            this.UnSetButton.Location = new System.Drawing.Point(607, 277);
            this.UnSetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnSetButton.Name = "UnSetButton";
            this.UnSetButton.Size = new System.Drawing.Size(126, 46);
            this.UnSetButton.TabIndex = 27;
            this.UnSetButton.Text = "UnSet";
            this.UnSetButton.UseVisualStyleBackColor = false;
            this.UnSetButton.Click += new System.EventHandler(this.UnSetButton_Click);
            // 
            // SetButton
            // 
            this.SetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetButton.ForeColor = System.Drawing.Color.Black;
            this.SetButton.Location = new System.Drawing.Point(359, 388);
            this.SetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(88, 46);
            this.SetButton.TabIndex = 26;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = false;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(196, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 32);
            this.label5.TabIndex = 25;
            this.label5.Text = "Shut Down At:";
            // 
            // SetTime
            // 
            this.SetTime.AutoSize = true;
            this.SetTime.BackColor = System.Drawing.Color.Transparent;
            this.SetTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTime.ForeColor = System.Drawing.Color.Black;
            this.SetTime.Location = new System.Drawing.Point(433, 154);
            this.SetTime.Name = "SetTime";
            this.SetTime.Size = new System.Drawing.Size(134, 32);
            this.SetTime.TabIndex = 24;
            this.SetTime.Text = "00:00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Now: ";
            // 
            // CountDown
            // 
            this.CountDown.AutoSize = true;
            this.CountDown.BackColor = System.Drawing.Color.Transparent;
            this.CountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountDown.ForeColor = System.Drawing.Color.Black;
            this.CountDown.Location = new System.Drawing.Point(302, 65);
            this.CountDown.Name = "CountDown";
            this.CountDown.Size = new System.Drawing.Size(213, 54);
            this.CountDown.TabIndex = 22;
            this.CountDown.Text = "00:00:00";
            // 
            // SecBox
            // 
            this.SecBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecBox.Location = new System.Drawing.Point(415, 337);
            this.SecBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SecBox.Name = "SecBox";
            this.SecBox.Size = new System.Drawing.Size(100, 34);
            this.SecBox.TabIndex = 21;
            this.SecBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(285, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Sec:";
            // 
            // MinBox
            // 
            this.MinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBox.Location = new System.Drawing.Point(415, 289);
            this.MinBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinBox.Name = "MinBox";
            this.MinBox.Size = new System.Drawing.Size(100, 34);
            this.MinBox.TabIndex = 19;
            this.MinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(289, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Min:";
            // 
            // HourBox
            // 
            this.HourBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourBox.Location = new System.Drawing.Point(415, 242);
            this.HourBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(100, 34);
            this.HourBox.TabIndex = 17;
            this.HourBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(274, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hour:";
            // 
            // NowTime
            // 
            this.NowTime.AutoSize = true;
            this.NowTime.BackColor = System.Drawing.Color.Transparent;
            this.NowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowTime.ForeColor = System.Drawing.Color.Black;
            this.NowTime.Location = new System.Drawing.Point(75, 6);
            this.NowTime.Name = "NowTime";
            this.NowTime.Size = new System.Drawing.Size(88, 22);
            this.NowTime.TabIndex = 15;
            this.NowTime.Text = "00:00:00";
            // 
            // NowTimer
            // 
            this.NowTimer.Interval = 1000;
            this.NowTimer.Tick += new System.EventHandler(this.NowTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UnSetButton);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SetTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CountDown);
            this.Controls.Add(this.SecBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MinBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HourBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NowTime);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ShutDown";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UnSetButton;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SetTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CountDown;
        private System.Windows.Forms.TextBox SecBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MinBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HourBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NowTime;
        private System.Windows.Forms.Timer NowTimer;
    }
}

