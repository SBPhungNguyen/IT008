namespace Lab2_2_6
{
    partial class ThemSuaForm
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
            label4 = new Label();
            MSSVTextBox = new TextBox();
            HoTenTextBox = new TextBox();
            GioiTinhTextBox = new TextBox();
            NgaySinhTextBox = new TextBox();
            ThemButton = new Button();
            SuaButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 48);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "MSSV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 93);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 1;
            label2.Text = "Ho Ten";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 145);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 2;
            label3.Text = "GioiTinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 194);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 3;
            label4.Text = "NgaySinh";
            // 
            // MSSVTextBox
            // 
            MSSVTextBox.Location = new Point(160, 45);
            MSSVTextBox.Name = "MSSVTextBox";
            MSSVTextBox.Size = new Size(150, 31);
            MSSVTextBox.TabIndex = 4;
            // 
            // HoTenTextBox
            // 
            HoTenTextBox.Location = new Point(160, 93);
            HoTenTextBox.Name = "HoTenTextBox";
            HoTenTextBox.Size = new Size(150, 31);
            HoTenTextBox.TabIndex = 5;
            // 
            // GioiTinhTextBox
            // 
            GioiTinhTextBox.Location = new Point(160, 145);
            GioiTinhTextBox.Name = "GioiTinhTextBox";
            GioiTinhTextBox.Size = new Size(150, 31);
            GioiTinhTextBox.TabIndex = 6;
            // 
            // NgaySinhTextBox
            // 
            NgaySinhTextBox.Location = new Point(160, 194);
            NgaySinhTextBox.Name = "NgaySinhTextBox";
            NgaySinhTextBox.Size = new Size(150, 31);
            NgaySinhTextBox.TabIndex = 7;
            // 
            // ThemButton
            // 
            ThemButton.Location = new Point(174, 251);
            ThemButton.Name = "ThemButton";
            ThemButton.Size = new Size(112, 34);
            ThemButton.TabIndex = 8;
            ThemButton.Text = "Them";
            ThemButton.UseVisualStyleBackColor = true;
            ThemButton.Click += ThemButton_Click;
            // 
            // SuaButton
            // 
            SuaButton.Location = new Point(174, 301);
            SuaButton.Name = "SuaButton";
            SuaButton.Size = new Size(112, 34);
            SuaButton.TabIndex = 9;
            SuaButton.Text = "Sua";
            SuaButton.UseVisualStyleBackColor = true;
            SuaButton.Click += SuaButton_Click;
            // 
            // ThemSuaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SuaButton);
            Controls.Add(ThemButton);
            Controls.Add(NgaySinhTextBox);
            Controls.Add(GioiTinhTextBox);
            Controls.Add(HoTenTextBox);
            Controls.Add(MSSVTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThemSuaForm";
            Text = "ThemSuaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox MSSVTextBox;
        private TextBox HoTenTextBox;
        private TextBox GioiTinhTextBox;
        private TextBox NgaySinhTextBox;
        private Button ThemButton;
        private Button SuaButton;
    }
}