using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_Coders
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

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = "";
            if (text1 == "")
            {
                textBox1.Text = "0";
            }
            if (text2 == "")
            {
                textBox2.Text = "0";
            }
            float add = text1ToInt + text2ToInt;
            result.Text = add.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void number2_Click(object sender, EventArgs e)
        {

        }
        public float text1ToInt,text2ToInt;
        public string text1,text2;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
 
             text1 = textBox1.Text;
            if (text1 != "")
            {
                text1ToInt = Convert.ToInt32(text1);
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             text2 = textBox2.Text;
            if (text2 != "")
            {
                text2ToInt = Convert.ToInt32(text2);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            result.Text = "";
            if (text1 == "")
            {
                textBox1.Text = "0";
            }
            if (text2 == "")
            {
                textBox2.Text = "0";
            }
            float subtr = text1ToInt - text2ToInt;
            result.Text = subtr.ToString();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (text1 == "")
            {
                textBox1.Text = "0";
            }
            if (text2 == "")
            {
                textBox2.Text = "0";
            }
            result.Text = "";
            float mult = text1ToInt * text2ToInt;
            result.Text = mult.ToString();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (text1 == "")
            {
                textBox1.Text = "0";
            }
            if (text2 == "")
            {
                textBox2.Text = "0";
            }
            result.Text = "";
            float div = text1ToInt / text2ToInt;
            result.Text = div.ToString();
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            if (text1 == "")
            {
                textBox1.Text = "0";
            }
            if (text2 == "")
            {
                textBox2.Text = "0";
            }
            result.Text = "";
            float factorial(float x)
            {
                float f = 1;
                for (float i = x; i >= 1; i--)
                {
                    f = f * i;
                }
                return f;
            }
            float rf = factorial(text1ToInt);
            result.Text = rf.ToString();
        }

        private void exponent_Click(object sender, EventArgs e)
        {
            if (text1 == "")
            {
                textBox1.Text = "0";
            }
            if (text2 == "")
            {
                textBox2.Text = "0";
            }
            result.Text = "";
            float power(float a, float n)
            {
                float r = 1;
                for (float i = 1; i <= n; i++)
                {
                    r = r * a;
                }
                return r;
            }
            result.Text = power(text1ToInt, text2ToInt).ToString();

        }

        private void percent_Click(object sender, EventArgs e)
        {
            if (text1 == "")
            {
                textBox1.Text = "0";
            }
            if (text2 == "")
            {
                textBox2.Text = "0";
            }
            result.Text = "";
            float rem = text1ToInt % text2ToInt;
            result.Text = rem.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void clear_Click(object sender, EventArgs e)
        {
            result.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void number1_Click(object sender, EventArgs e)
        {

        }
    }
}
