namespace ListViewDemo
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
            lviSinhVien = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtPhone = new TextBox();
            btnThem = new Button();
            lblFLastName = new Label();
            lblFirstName = new Label();
            lblPhone = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            SuspendLayout();
            // 
            // lviSinhVien
            // 
            lviSinhVien.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lviSinhVien.Location = new Point(100, 39);
            lviSinhVien.Name = "lviSinhVien";
            lviSinhVien.Size = new Size(515, 154);
            lviSinhVien.TabIndex = 0;
            lviSinhVien.UseCompatibleStateImageBehavior = false;
            lviSinhVien.View = View.Details;
            lviSinhVien.SelectedIndexChanged += lviSinhVien_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Last Name";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "First Name";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Phone";
            columnHeader3.Width = 100;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(150, 254);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(150, 310);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(150, 373);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 3;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(484, 251);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblFLastName
            // 
            lblFLastName.AutoSize = true;
            lblFLastName.Location = new Point(50, 251);
            lblFLastName.Name = "lblFLastName";
            lblFLastName.Size = new Size(90, 25);
            lblFLastName.TabIndex = 5;
            lblFLastName.Text = "LastName";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(50, 316);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(92, 25);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "FirstName";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(50, 379);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(62, 25);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Phone";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(484, 311);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(484, 379);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(lblPhone);
            Controls.Add(lblFirstName);
            Controls.Add(lblFLastName);
            Controls.Add(btnThem);
            Controls.Add(txtPhone);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lviSinhVien);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lviSinhVien;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtPhone;
        private Button btnThem;
        private Label lblFLastName;
        private Label lblFirstName;
        private Label lblPhone;
        private Button btnSua;
        private Button btnXoa;
    }
}
