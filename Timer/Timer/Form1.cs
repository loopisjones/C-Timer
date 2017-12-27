using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Timer
{
    public partial class Form1 : Form
    {
        int min;
        int sec;
        bool rn = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rn = true;
        }

        void run()
        {
            while (rn == true)
            {
                int tot = (min * 60) + sec;
                if (tot != 0)
                {
                    sec = sec - 1;
                    if(sec < 0)
                    {
                        sec = 59;
                        min = min - 1;
                    }




                    sleep(1);
                }
                textBox1.Text = Convert.ToString(sec);
                textBox2.Text = Convert.ToString(min);

            }

        }

        void sleep(int stw)
        {
            System.Threading.Thread.Sleep(stw*1000);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                min = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Error: Input Needs To Be a Integer");
            }
            textBox2.Text = Convert.ToString(min);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sec = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Error: Input Needs To Be a Integer");
            }
            textBox1.Text = Convert.ToString(sec);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rn = false;
        }
    }
}
