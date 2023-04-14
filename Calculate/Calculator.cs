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

        public Calculator()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /*
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        */
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
