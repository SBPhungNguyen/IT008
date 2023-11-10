namespace Lab2_2_6
{
    partial class Form1
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
            XemButton = new Button();
            ThemSuaButton = new Button();
            XoaButton = new Button();
            SuspendLayout();
            // 
            // XemButton
            // 
            XemButton.Location = new Point(221, 38);
            XemButton.Name = "XemButton";
            XemButton.Size = new Size(112, 34);
            XemButton.TabIndex = 0;
            XemButton.Text = "Xem";
            XemButton.UseVisualStyleBackColor = true;
            XemButton.Click += XemButton_Click;
            // 
            // ThemSuaButton
            // 
            ThemSuaButton.Location = new Point(221, 111);
            ThemSuaButton.Name = "ThemSuaButton";
            ThemSuaButton.Size = new Size(112, 34);
            ThemSuaButton.TabIndex = 1;
            ThemSuaButton.Text = "Them/Sua";
            ThemSuaButton.UseVisualStyleBackColor = true;
            ThemSuaButton.Click += ThemSuaButton_Click;
            // 
            // XoaButton
            // 
            XoaButton.Location = new Point(221, 186);
            XoaButton.Name = "XoaButton";
            XoaButton.Size = new Size(112, 34);
            XoaButton.TabIndex = 2;
            XoaButton.Text = "Xoa";
            XoaButton.UseVisualStyleBackColor = true;
            XoaButton.Click += XoaButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(XoaButton);
            Controls.Add(ThemSuaButton);
            Controls.Add(XemButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button XemButton;
        private Button ThemSuaButton;
        private Button XoaButton;
    }
}