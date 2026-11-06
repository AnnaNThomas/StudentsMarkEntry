namespace StudentsMarkEntry
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
            lblTitle = new Label();
            lblAdmission = new Label();
            lblName = new Label();
            lblDOB = new Label();
            lblCourse = new Label();
            lblMark = new Label();
            txtAdmissionNo = new TextBox();
            txtName = new TextBox();
            txtCourse = new TextBox();
            cmbSubject = new ComboBox();
            btnAdd = new Button();
            IblTitle = new Label();
            label6 = new Label();
            lblSubject = new Label();
            txtMark = new TextBox();
            dtpDOB = new DateTimePicker();
            dgvMarks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMarks).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(341, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(275, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Mark Entry";
            // 
            // lblAdmission
            // 
            lblAdmission.AutoSize = true;
            lblAdmission.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmission.Location = new Point(87, 136);
            lblAdmission.Name = "lblAdmission";
            lblAdmission.Size = new Size(145, 20);
            lblAdmission.TabIndex = 1;
            lblAdmission.Text = "Admission Number";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(298, 136);
            lblName.Name = "lblName";
            lblName.Size = new Size(114, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Student Name ";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDOB.Location = new Point(87, 225);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(100, 20);
            lblDOB.TabIndex = 3;
            lblDOB.Text = "Date of Birth";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourse.Location = new Point(298, 225);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(57, 20);
            lblCourse.TabIndex = 4;
            lblCourse.Text = "Course";
            // 
            // lblMark
            // 
            lblMark.AutoSize = true;
            lblMark.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMark.Location = new Point(90, 383);
            lblMark.Name = "lblMark";
            lblMark.Size = new Size(86, 20);
            lblMark.TabIndex = 5;
            lblMark.Text = "Enter Mark";
            // 
            // txtAdmissionNo
            // 
            txtAdmissionNo.Location = new Point(90, 175);
            txtAdmissionNo.Name = "txtAdmissionNo";
            txtAdmissionNo.Size = new Size(155, 27);
            txtAdmissionNo.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(298, 175);
            txtName.Name = "txtName";
            txtName.Size = new Size(292, 27);
            txtName.TabIndex = 7;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(298, 261);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(292, 27);
            txtCourse.TabIndex = 9;
            // 
            // cmbSubject
            // 
            cmbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(298, 421);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(292, 28);
            cmbSubject.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Highlight;
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(90, 534);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(500, 52);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "+Add Mark";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // IblTitle
            // 
            IblTitle.BackColor = SystemColors.InactiveCaption;
            IblTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IblTitle.Location = new Point(87, 80);
            IblTitle.Name = "IblTitle";
            IblTitle.Size = new Size(503, 25);
            IblTitle.TabIndex = 12;
            IblTitle.Text = "Student Information";
            // 
            // label6
            // 
            label6.BackColor = SystemColors.InactiveCaption;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(87, 323);
            label6.Name = "label6";
            label6.Size = new Size(503, 25);
            label6.TabIndex = 13;
            label6.Text = "Mark Details";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubject.Location = new Point(298, 383);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(60, 20);
            lblSubject.TabIndex = 14;
            lblSubject.Text = "Subject";
            // 
            // txtMark
            // 
            txtMark.Location = new Point(90, 422);
            txtMark.Name = "txtMark";
            txtMark.Size = new Size(155, 27);
            txtMark.TabIndex = 15;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(87, 273);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(158, 27);
            dtpDOB.TabIndex = 16;
            // 
            // dgvMarks
            // 
            dgvMarks.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvMarks.BorderStyle = BorderStyle.Fixed3D;
            dgvMarks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarks.Location = new Point(612, 136);
            dgvMarks.MultiSelect = false;
            dgvMarks.Name = "dgvMarks";
            dgvMarks.RowHeadersWidth = 51;
            dgvMarks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMarks.Size = new Size(645, 450);
            dgvMarks.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1269, 737);
            Controls.Add(dgvMarks);
            Controls.Add(dtpDOB);
            Controls.Add(txtMark);
            Controls.Add(lblSubject);
            Controls.Add(label6);
            Controls.Add(IblTitle);
            Controls.Add(btnAdd);
            Controls.Add(cmbSubject);
            Controls.Add(txtCourse);
            Controls.Add(txtName);
            Controls.Add(txtAdmissionNo);
            Controls.Add(lblMark);
            Controls.Add(lblCourse);
            Controls.Add(lblDOB);
            Controls.Add(lblName);
            Controls.Add(lblAdmission);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Mark Entry";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMarks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAdmission;
        private Label lblName;
        private Label lblDOB;
        private Label lblCourse;
        private Label lblMark;
        private TextBox txtAdmissionNo;
        private TextBox txtName;
        private TextBox txtCourse;
        private ComboBox cmbSubject;
        private Button btnAdd;
        private Label IblTitle;
        private Label label6;
        private Label lblSubject;
        private TextBox txtMark;
        private DateTimePicker dtpDOB;
        private DataGridView dgvMarks;
    }
}
