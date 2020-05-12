using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadSpeedCalculator
{
    public partial class Form1 : Form
    {
        string dspeed = string.Empty;
        string dsize = string.Empty;
        string already = string.Empty;
        string dspeedunit = String.Empty;
        string dsizeunit = String.Empty;
        string alreadyunit = String.Empty;
        double dspeednum = 0;
        double dsizenum = 0;
        double alreadynum = 0;
        double sectotal = 0;
        int percent = 0;
        int mins = 0;
        int sec = 0;
        int dsizeint = 0;
        int alreadyint = 0;
        int allsecs = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void convert()
        {
            dspeednum = Convert.ToDouble(dspeed);
            dsizenum = Convert.ToDouble(dsize);
            alreadynum = Convert.ToDouble(already);
            if (dspeedunit == "m")
            {
                dspeednum = dspeednum * 1000;
            }
            else if (dspeedunit == "g")
            {
                dspeednum = dspeednum * 10000;
            }
            if (dsizeunit == "m")
            {
                dsizenum = dsizenum * 1000;
            }
            else if (dsizeunit == "g")
            {
                dsizenum = dsizenum * 10000;
            }
            if (alreadyunit == "m")
            {
                alreadynum = alreadynum * 1000;
            }
            else if (alreadyunit == "g")
            {
                alreadynum = alreadynum * 10000;
            }
            math();
        }
        public void math()
        {
            sectotal = (dsizenum - alreadynum) / dspeednum;
            allsecs = Convert.ToInt32(sectotal);
            mins = 60 / allsecs;
            sec = allsecs % 60;
            if (allsecs < 60)
            {
                mins = 0;
            }
            label11.Text = $"{mins} minutes and {sec} seconds";
            dsizeint = Convert.ToInt32(dsizenum);
            alreadyint = Convert.ToInt32(alreadynum);
            percent = dsizeint * alreadyint / 100000000;
            if (percent < 0)
            {
                percent = 0;
            }
            progressBar1.Value = percent;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dspeed = textBox2.Text;
            dspeedunit = textBox1.Text;
            dsize = textBox3.Text;
            dsizeunit = textBox4.Text;
            already = textBox5.Text;
            alreadyunit = textBox6.Text;
            convert();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
