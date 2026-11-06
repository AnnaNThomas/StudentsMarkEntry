using System;
using System.Numerics;
using System.Windows.Forms;


namespace StudentsMarkEntry
{
    public partial class Form1 : Form
    {
        int serialNumber = 1;
        int mark;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Clear existing items
            cmbSubject.Items.Clear();

            // Add subjects
            cmbSubject.Items.Add("Select Subject");
            cmbSubject.Items.Add("Physics");
            cmbSubject.Items.Add("Chemistry");
            cmbSubject.Items.Add("Mathematics");

            // Display Select Subject initially
            cmbSubject.SelectedIndex = 0;

            




            //Adding Data to DataGrid

            dgvMarks.Columns.Clear();

            dgvMarks.Columns.Add("SlNo", "Sl.");
            dgvMarks.Columns.Add("AdmissionNo", "Admnno");
            dgvMarks.Columns.Add("StudentName", "Name");
            dgvMarks.Columns.Add("Age", "Age");
            dgvMarks.Columns.Add("Course", "Course");
            dgvMarks.Columns.Add("Subject", "Subject");
            dgvMarks.Columns.Add("Mark", "Mark");

            dtpDOB.MaxDate = DateTime.Today;



           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAdmissionNo.Text) &&
       !string.IsNullOrWhiteSpace(txtName.Text) &&
       !string.IsNullOrWhiteSpace(txtCourse.Text) &&
       !string.IsNullOrWhiteSpace(txtMark.Text) &&
       cmbSubject.SelectedIndex > 0)
            {

                string admissionNo = txtAdmissionNo.Text.Trim();
                string studentName = txtName.Text.Trim();
                string course = txtCourse.Text.Trim();
                string subject = cmbSubject.SelectedItem.ToString();
                int mark = int.Parse(txtMark.Text.Trim());

                int age = CalculateAge(dtpDOB.Value);


                // 7. Add record to DataGridView
                dgvMarks.Rows.Add(
                    serialNumber,
                    admissionNo,
                    studentName,
                    age,
                    course,
                    subject,
                    mark
                );

                // 8. Increase serial number
                serialNumber++;

                // 9. Clear subject and mark for next entry
                cmbSubject.SelectedIndex = -1;           //no item is selected
                txtMark.Clear();                         //removes all text from the TextBox

                cmbSubject.Focus();    //just to highlight that combobox
            }
            else
            {
                MessageBox.Show("Please fill all fields", "Validation",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private int CalculateAge(DateTime dob)
        {
            int age = DateTime.Today.Year - dob.Year;

            if (dob.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

    }
}
