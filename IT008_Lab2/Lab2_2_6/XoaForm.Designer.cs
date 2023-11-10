namespace Lab2_2_6
{
    partial class XoaForm
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
            MSSVTextBox = new TextBox();
            XoaButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 50);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "MSSV";
            // 
            // MSSVTextBox
            // 
            MSSVTextBox.Location = new Point(177, 50);
            MSSVTextBox.Name = "MSSVTextBox";
            MSSVTextBox.Size = new Size(150, 31);
            MSSVTextBox.TabIndex = 1;
            // 
            // XoaButton
            // 
            XoaButton.Location = new Point(195, 108);
            XoaButton.Name = "XoaButton";
            XoaButton.Size = new Size(112, 34);
            XoaButton.TabIndex = 2;
            XoaButton.Text = "Xoa";
            XoaButton.UseVisualStyleBackColor = true;
            XoaButton.Click += XoaButton_Click;
            // 
            // XoaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(XoaButton);
            Controls.Add(MSSVTextBox);
            Controls.Add(label1);
            Name = "XoaForm";
            Text = "XoaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox MSSVTextBox;
        private Button XoaButton;
    }
}