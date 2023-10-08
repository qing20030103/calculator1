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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int num1;
        string optType;//当前运算符
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Console.WriteLine(button1.Text);
            Button btn = (Button)sender;
            Console.WriteLine(btn.Text);
            string txt = btn.Text;
            if (txt == "+" || txt == "-" || txt == "*" || txt == "/")
            {
                num1 = int.Parse(textBox1.Text);
                textBox1.Text = "";
                optType = txt;//记录当前运算符
            }
            else if (txt == "=")
            {
                int num2 = int.Parse(textBox1.Text);
                int result = 0;

                if (optType == "+")
                {
                    result = num1 + num2;
                }

                else if (optType == "-")
                {
                    result = num1 - num2;

                }
                else if (optType == "*")
                {
                    result = num1 * num2;

                }
                else if (optType == "/")
                {
                    result = num1 / num2;

                }
            
                textBox1.Text = result.ToString();

            }
            else if (txt == "delete")
            {
                string tempStr = textBox1.Text;
                tempStr = tempStr.Substring(0, tempStr.Length - 1);
                textBox1.Text = tempStr;


            }

            else if (txt == "clear")
            {
                textBox1.Text = "";
            }
            else
            {
                string tempStr = textBox1.Text;
                tempStr = tempStr + txt;
                textBox1.Text = tempStr;
            }
        

    }

    private void Form1_Load(object sender, EventArgs e)
        {
            this.button2.Click += new System.EventHandler(this.button1_Click);//为button设置初始点击事件，回调
            this.button3.Click += new System.EventHandler(this.button1_Click);
            this.button4.Click += new System.EventHandler(this.button1_Click);
            this.button5.Click += new System.EventHandler(this.button1_Click);
            this.button6.Click += new System.EventHandler(this.button1_Click);
            this.button7.Click += new System.EventHandler(this.button1_Click);
            this.button8.Click += new System.EventHandler(this.button1_Click);
            this.button9.Click += new System.EventHandler(this.button1_Click);
            this.button10.Click += new System.EventHandler(this.button1_Click);
            this.button11.Click += new System.EventHandler(this.button1_Click);
            this.button12.Click += new System.EventHandler(this.button1_Click);
            this.button13.Click += new System.EventHandler(this.button1_Click);
            this.button14.Click += new System.EventHandler(this.button1_Click);
            this.button15.Click += new System.EventHandler(this.button1_Click);
            this.button16.Click += new System.EventHandler(this.button1_Click);
            this.button17.Click += new System.EventHandler(this.button1_Click);

        }
    }
}
