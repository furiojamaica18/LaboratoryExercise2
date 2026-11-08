using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LaboratoryExercise2
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string studentNo = txtStudentNo.Text;
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(docPath, studentNo + ".txt");
            string birthDate = dtpBirthday.Value.ToString("MM/dd/yyyy");

            string[] details = {
                "Student Number: " + studentNo,
                "Full Name: " + txtLastname.Text + ", " +  txtFirstname.Text + ", " + txtMi.Text + ".",
                "Program: " + cmbProgram.Text,
                "Gender: " + cmbGender.Text,
                "Age: " + txtAge.Text,
                "Birthday: " + birthDate,
                "Contact Number: " + txtContactNo.Text,
            };

            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                foreach (string detail in details)
                {
                    outputFile.WriteLine(detail);
                }
            }

            MessageBox.Show("Successfully Registered");
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord recordForm = new FrmStudentRecord();
            recordForm.Show();
            this.Hide();
        }
    }
}
