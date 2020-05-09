using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApptestframework
{
    public partial class Form1 : Form
    {
        string input = String.Empty;
        string numone = String.Empty;
        string numtwo = String.Empty;
        char oper;
        double done = 0;
        public void Math()
        {

            double numonem = Convert.ToDouble(numone);
            double numtwom = Convert.ToDouble(numtwo);
            if (oper == '+')
            {
                done = numonem + numtwom;
            }
            if (oper == '-')
            {
                done = numonem - numtwom;
            }
            if (oper == '/')
            {
                done = numonem / numtwom;
            }
            if (oper == '*')
            {
                done = numonem * numtwom;
            }
            textBox1.Text = $"{done}";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "6";
            textBox1.Text += input;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "1";
            textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "2";
            textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "3";
            textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "4";
            textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "5";
            textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "7";
            textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "8";
            textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "9";
            textBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "0";
            textBox1.Text += input;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {//+
            textBox1.Text = "";
            numone = input;
            input = String.Empty;
            oper = '+';
            textBox1.Text = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {//-
            textBox1.Text = "";
            numone = input;
            input = String.Empty;
            oper = '-';
            textBox1.Text = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {//*
            textBox1.Text = "";
            numone = input;
            input = String.Empty;
            oper = '*';
            textBox1.Text = "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {// /
            textBox1.Text = "";
            numone = input;
            input = String.Empty;
            oper = '/';
            textBox1.Text = "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {//=
            textBox1.Text = "";
            numtwo = input;
            input = String.Empty;
            Math();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input = String.Empty;
            oper = ' ';
            numone = String.Empty;
            numtwo = String.Empty;
            textBox1.Text += input;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += ".";
            textBox1.Text += input;
        }
    }
}
