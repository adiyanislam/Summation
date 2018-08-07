using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private float value1 = 0.0f;
        private float value2 = 0.0f;
        private float result = 0.0f;
        private float value3 = 0.0f;

        private void GetValues()
        {
            value1 = 0.0f;
            value2 = 0.0f;
            value3 = 0.0f;
            result = 0.0f;


            if (textBox1.Text.Trim() != "")
            {
                value1 = float.Parse(textBox1.Text);
            }

            if (textBox2.Text.Trim() != "")
            {
                value2 = float.Parse(textBox2.Text);
            }
            {
                if (textBox7.Text.Trim() != "")
                { value3 = float.Parse(textBox7.Text); }
            }
        }



        private void ShowResult()
        {
            textBox3.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetValues();
            result = value1 + value2;
            ShowResult();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetValues();
            result = value1 * value2;
            ShowResult();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            GetValues();
            result = value1 / value2;
            ShowResult();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetValues();
            result = value1 - value2;
            ShowResult();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetValues();
            result = value1 * value1;
            ShowResult();

            float sum = 1;

            for (float i = 0; i < value2; i++)
            {
                sum = sum * value1;
            }

            textBox3.Text = sum.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GetValues();
            result = value1 - value2;
            ShowResult();

            float sum = 1;

            for (float i = 0; i < value2; i++)
            {
                sum = sum / value1;
            }

            textBox3.Text = sum.ToString();
        }

       


      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }




        private void button6_Click_1(object sender, EventArgs e)
        {
            GetValues();
            result = value1 + value2 + value3;
            ShowResult();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button7_Click_1(object sender, EventArgs e)
        {
            GetValues();
            result = value1 * value2 * value3;
            ShowResult();
        }
    }

}