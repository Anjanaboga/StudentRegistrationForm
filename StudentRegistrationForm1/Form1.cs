using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentRegistrationForm1
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Experience_Click(object sender, EventArgs e)
        {

        }

        private void cmbExperience_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picPhoto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (rdoMale.Checked)
                gender = "Male";
            else if (rdoFemale.Checked)
                gender = "Female";

            string maritalStatus = "";

            if (rdoMarried.Checked)
                maritalStatus = "Married";
            else if (rdoUnmarried.Checked)
                maritalStatus = "Unmarried";

            string qualification = "";

            if (chkDiploma.Checked)
                qualification += "Diploma ";

            if (chkUG.Checked)
                qualification += "UG ";

            if (chkPG.Checked)
                qualification += "PG ";

            string experience = cmbExperience.Text;

            MessageBox.Show(
                "Name : " + textBox1.Text +
                "\n\nDate of Birth : " + dtpDOB.Text +
                "\n\nGender : " + gender +
                "\n\nMarital Status : " + maritalStatus +
                "\n\nQualification : " + qualification +
                "\n\nExperience : " + experience +
                "\n\nAbout Project :\n" + rtbProject.Text,
                "Student Details"
);
        }

        private void rtbProject_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DateofBirth_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void picPhoto_Click(object sender, EventArgs e)
        {

        }
    }
}
