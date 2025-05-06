using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tapshiriq_2_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);
            string netice = "";
            if (number > 0)
            {
                netice = "Müsbet ədəddir";
            }
            else if (number < 0)
            {
                netice = "Mənfi ədəddir";
            }
            else
            {
                netice = "Sıfırdır";
            }
            label1.Text = netice;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);
            string netice = "";
            if (number % 2 == 0)
            {
                netice = "Cüt ədəddir";

            }
            else
            {
                netice = "Tək ədəddir";
            }
            label1.Text = netice;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int eded = Convert.ToInt32(textBox1.Text);
            string netice = "";
            if (eded % 3 == 0 || eded % 4 == 0)
            {
                netice = "Bölünür";
            }
            else 
            {
                netice = "Bölünmür";
            }
            label1.Text = netice;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);
            string netice = "";
            if (number % 4 == 0 && number % 6 == 0)
            {
                netice = "4-ə və 6-ya bölünür ";

            }
            else if (number % 4 == 0)
            {
                netice = "4-ə bölünür";

            }
            else if (number % 6 == 0)
            {
                netice = "6-ya bölünür ";

            }
            else 
            {
                MessageBox.Show("Heç birinə bölünmür");
            }
            label1.Text = netice;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int bal = Convert.ToInt32(textBox1.Text);
            string netice = "";
            if (bal >= 0 && bal <= 100)
            {
                if (bal >= 0 && bal <= 50)
                {
                    netice = "F";
                }
                else if (bal >= 51 && bal <= 60)
                {
                    netice = "E";
                }
                else if (bal >= 61 && bal <= 70)
                {
                    netice = "D";
                }
                else if (bal >= 71 && bal <= 80)
                {
                    netice = "C";
                }
                else if (bal >= 81 && bal <= 90)
                {
                    netice = "B";
                }
                else if (bal >= 91 && bal <= 100)
                {
                    netice = "A";
                }
            }
            else
            {
                MessageBox.Show("Not Found");
            }
            label1.Text = netice;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double esas = Convert.ToDouble(textBox1.Text);
            double ode = 0;
            double ferq = 0;

            if (esas > 0 && esas < 300)
            {
                ferq = esas * 0.1;
            }
            else if (esas >= 301 && esas <= 500)
            {
                ferq = esas * 0.1;
            }
            else if (esas >= 501 && esas <= 700)
            {
                ferq = esas * 0.15;
            }
            else
            {
                ferq = esas + 0.2;
            }
             ode = esas - ferq;
             label1.Text = ode.ToString();
        }
    }
}

