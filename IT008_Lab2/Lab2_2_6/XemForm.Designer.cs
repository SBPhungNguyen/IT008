namespace Lab2_2_6
{
    partial class XemForm
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
            XemTatCaButton = new Button();
            lsvDanhSach = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            MSSVTextBox = new TextBox();
            TimTheoMSSVButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // XemTatCaButton
            // 
            XemTatCaButton.Location = new Point(61, 160);
            XemTatCaButton.Name = "XemTatCaButton";
            XemTatCaButton.Size = new Size(112, 34);
            XemTatCaButton.TabIndex = 0;
            XemTatCaButton.Text = "Xem Tat Ca";
            XemTatCaButton.UseVisualStyleBackColor = true;
            XemTatCaButton.Click += XemTatCaButton_Click;
            // 
            // lsvDanhSach
            // 
            lsvDanhSach.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvDanhSach.FullRowSelect = true;
            lsvDanhSach.GridLines = true;
            lsvDanhSach.Location = new Point(242, 48);
            lsvDanhSach.Name = "lsvDanhSach";
            lsvDanhSach.Size = new Size(463, 146);
            lsvDanhSach.TabIndex = 1;
            lsvDanhSach.UseCompatibleStateImageBehavior = false;
            lsvDanhSach.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "MSSV";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "HoTen";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "GioiTinh";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "NgaySinh";
            columnHeader4.Width = 150;
            // 
            // MSSVTextBox
            // 
            MSSVTextBox.Location = new Point(86, 48);
            MSSVTextBox.Name = "MSSVTextBox";
            MSSVTextBox.Size = new Size(150, 31);
            MSSVTextBox.TabIndex = 2;
            // 
            // TimTheoMSSVButton
            // 
            TimTheoMSSVButton.Location = new Point(44, 85);
            TimTheoMSSVButton.Name = "TimTheoMSSVButton";
            TimTheoMSSVButton.Size = new Size(150, 34);
            TimTheoMSSVButton.TabIndex = 3;
            TimTheoMSSVButton.Text = "Tim Theo MSSV";
            TimTheoMSSVButton.UseVisualStyleBackColor = true;
            TimTheoMSSVButton.Click += TimTheoMSSVButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 48);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 4;
            label1.Text = "MSSV";
            // 
            // XemForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(TimTheoMSSVButton);
            Controls.Add(MSSVTextBox);
            Controls.Add(lsvDanhSach);
            Controls.Add(XemTatCaButton);
            Name = "XemForm";
            Text = "XemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button XemTatCaButton;
        private ListView lsvDanhSach;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox MSSVTextBox;
        private Button TimTheoMSSVButton;
        private Label label1;
    }
}