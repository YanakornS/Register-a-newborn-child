using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register_a_newborn_child
{
    public partial class Form2 : Form
    {
        const string dp = "หน่วยงานรับลงทะเบียน องค์การบริหารส่วนตําบลลมศักดิ์";
        const string form_Name = " (ลงทะเบียนขอรับเงินสนับสนุน) ";
        const string officer = " ญาณกร ";


        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Form2_Load_1(object sender, EventArgs e)
        {
            string tl = string.Format("{0} ผู้ใช้ -{1} ระบบ{2}", dp, officer, form_Name);
            // MessageBox.Show("load");
            comboBox1.Text = "2568";
            comboBox2.Text = "ไทย";
            //this.Text = dp + officer + form_Name ;
            this.Text = tl;




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string RS = "";
            if (radioButton1.Checked)
            {
                RS = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                RS = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                RS = textBox1.Text;
            }
            string RSB = "";
            if (radioButton4.Checked)
            {
                RSB = radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                RSB = radioButton5.Text;
            }

            //string tle = string.Format("   {0} {1} {2} ", groupBox2.Text, label3.Text, RSB +  " : " + textBox2.Text);

            DateTime ShowDate = dateTimePicker1.Value;
            string tl = string.Format("{0} ผู้ใช้ -{1} ระบบ{2} เวลา -{3} ความสัมพันธ์กับเด็กแรกเกิด : {4} เลขบัตรประจำตัวประชาชน : {5} สัญชาติ : {6} {7}  {8} {9} ", dp, officer, form_Name, ShowDate, RS, maskedTextBox1.Text, comboBox2.Text,groupBox2.Text, label3.Text, RSB + " : " + textBox2.Text);
            // string tl2 = string.Format(" ความสัมพันธ์กับเด็กแรกเกิด : {0}  ", RS);
            MessageBox.Show(tl);
            // MessageBox.Show("Show Date: "+ tl + ShowDate.ToShortDateString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
