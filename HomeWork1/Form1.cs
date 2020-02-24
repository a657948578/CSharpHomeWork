using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            if (double.TryParse(textBox1.Text, out a)) { }
            else
            {
                label1.Text = "请在第一个框内输入数字";
                return;
            }
            if(double.TryParse(textBox3.Text, out b)) { }
            else
            {
                label1.Text = "请在第二个框内输入数字";
                return;
            }
            double c = 0;
            string operate = textBox2.Text;
            switch (operate)
            {
                case "+":
                    c = a + b;
                    label1.Text = $"{c}";
                    break;
                case "-":
                    c = a - b;
                    label1.Text = $"{c}";
                    break;
                case "*":
                    c = a * b;
                    label1.Text = $"{c}";
                    break;
                case "/":
                    if (b == 0) label1.Text = "被除数不能为0";
                    else {
                        c = a / b;
                        label1.Text = $"{c}";
                    }
                    break;
                case "%":
                    c = a % b;
                    label1.Text = $"{c}";
                    break;
                default:
                    label1.Text = "符号位出错";
                    break;
            }
        }

        
        }
    }
