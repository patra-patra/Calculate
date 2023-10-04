using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculate
{
    public partial class Calculator : Form
    {   
        float first, last;
        int sign;
        float memory = 0;
        int top = 10;
        int left = 10;

        public Calculator()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            first = float.Parse(textBox1.Text);
            textBox1.Clear();
            sign = 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            first = float.Parse(textBox1.Text);
            textBox1.Clear();
            sign = 2;
    
        }

        private void button13_Click(object sender, EventArgs e)
        {
            first = float.Parse(textBox1.Text);
            textBox1.Clear();
            sign = 3;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }
        
        private void button14_Click(object sender, EventArgs e)
        {
            first = float.Parse(textBox1.Text);
            textBox1.Clear();
            sign = 4;
    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

       

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = (float.Parse(textBox1.Text) * float.Parse(textBox1.Text)).ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            memory = 0;
            textBox2.Text = memory.ToString();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            memory += float.Parse(textBox1.Text);
            textBox2.Text = memory.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            memory -= float.Parse(textBox1.Text);
            textBox2.Text = memory.ToString();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = (1/float.Parse(textBox1.Text)).ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = (first/ 100 * int.Parse(textBox1.Text)).ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            last = 0;
            textBox1.Text = "";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Trim(textBox1.Text[textBox1.Text.Length - 1]);
            }
            else
            {
                textBox1.Text = 0.ToString();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sqrt(float.Parse(textBox1.Text)).ToString();
        }

        int c = 0;

        private void button23_Click(object sender, EventArgs e)
        {
            
            if (c == 0)
            {
                textBox2.Visible = true;
                c++;
            }
            else
            {
                textBox2.Visible = false;
                c--;
            }


            textBox2.Text = memory.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            memory = int.Parse(textBox1.Text);
            textBox2.Text = memory.ToString();
        
        }

        private void calculate()
        {
            switch (sign)
            {
                case 1:
                    last = first + float.Parse(textBox1.Text);
                    textBox1.Text = last.ToString();
                    break;
                case 2:
                    last = first - float.Parse(textBox1.Text);
                    textBox1.Text = last.ToString();
                    break;
                case 3:
                    last = first * float.Parse(textBox1.Text);
                    textBox1.Text = last.ToString();
                    break;
                case 4:
                    if (float.Parse(textBox1.Text) == 0)
                    {
                        textBox1.Text = "Ошибка";
                        break;
                    }
                    last = first / float.Parse(textBox1.Text);
                    textBox1.Text = last.ToString();
                    break;

                default:
                    break;
            }

        }

    }
}
