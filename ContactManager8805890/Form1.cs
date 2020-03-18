using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager8805890
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        public class Contact
        {
            private int ID { get; set; }
            private string ContactFName { get; set; } 

            private string ContactLName { get; set; }

            private string ContactTel { get; set; }

            private string ContactEmail { get; set; }

            private string ContactAddr1 { get; set; }
            
            private string ContactAddr2 { get; set; }

            private string ContactCity { get; set; }

            private string ContactPostcode { get; set; }






        }

        public partial class BusinessContact : Contact
        {
            private string ContactBusinessTel { get; set; }

        }

        public partial class PersonalContact
        {
            private string ContactPersonalTel { get; set; }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

     

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                label1.Text = "Business Contact is Selected";
            if (radioButton2.Checked)
                label1.Text = "Personal Contact is Selected";

        }

        private void RadioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


