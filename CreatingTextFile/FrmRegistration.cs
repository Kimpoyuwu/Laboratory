using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CreatingTextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string getStudno = tbStudNo.Text;
            string getLname = tbLname.Text;
            string getFname = tbFname.Text;
            string getMI = tbMI.Text;
            string getAge = tbAge.Text;
            string getProgram = cbProgram.Text;
            string getGender = cbGender.Text;
            string getBday = bdayPicker.Text;
            string getContact = tbContactNo.Text;

            string SetFilename = tbStudNo.Text + ".txt";

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, SetFilename)))
            {
                outputFile.WriteLine("Student No: " + getStudno);
                outputFile.WriteLine("Full Name: " + getLname + ", " + getFname + " " + getMI);
                outputFile.WriteLine("Program: " + getProgram);
                outputFile.WriteLine("Gender: " + getGender);
                outputFile.WriteLine("Age: " + getAge);
                outputFile.WriteLine("Birthday: " + getBday);
                outputFile.WriteLine("Contact No: " + getContact);



            }

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
