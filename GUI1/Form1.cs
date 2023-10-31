using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI1
{
    public partial class MinMax : Form
    {
        public MinMax()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            textBox1.Text = Properties.Settings.Default.a.ToString();
            textBox2.Text = Properties.Settings.Default.b.ToString();
            textBox3.Text = Properties.Settings.Default.c.ToString();
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0;
            string Out;
            try
            {
                a = Convert.ToInt32(this.textBox1.Text);
                b = Convert.ToInt32(this.textBox2.Text);
                c = Convert.ToInt32(this.textBox3.Text);
                Out = Logic.MinMax(a, b, c);
                Properties.Settings.Default.a = a;
                Properties.Settings.Default.b = b;
                Properties.Settings.Default.c = c;
                Properties.Settings.Default.Save();
            }
            catch (FormatException)
            {
                Out = "Введено не целое число";
            }

            label2.Text = Out;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label2.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MinMax_Load(object sender, EventArgs e)
        {

        }
    }
    public class Logic
    {
        public static string MinMax(int a, int b, int c)
        {
            string Out2;
            int max, proiz = 0;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            if (max > c)
            {
            }
            else
            {
                max = c;
            }
            if ((a == b) && (a == c) || (a == b) || (a == c) || (b == c))
            {
                Out2 = "Введите все различные числа";
            }
            else
            {
                Out2 = ("Произведение наименьших чисел равно = " + proiz.ToString());
            }
            proiz = (a * b * c) / max;

            return (Out2);
        }
    }
}
