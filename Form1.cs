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

namespace TavsanVsKaplumbaga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*pictureBox1.Left += 5;
            pictureBox2.Top += 5;
            label3.Text = "IMDAT IMDAAAAT";
            label4.Text = "KACMA SANA TECAVUZ EDECEM!!";

            if (pictureBox1.Left >= 300)
            {
                timer1.Stop();
                timer2.Start();
            }*/

            button1.Enabled = false;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while (pictureBox1.Left<500 | pictureBox2.Left<500)
            {

            
                int hareketR, hareketT;

                Random r = new Random();
               /* Random t = new Random();*/

                hareketR = r.Next(1, 5);
                hareketT = r.Next(1, 5);


                pictureBox1.Left += hareketR;
                pictureBox2.Left += hareketT;

                if (pictureBox1.Left>pictureBox2.Left) 
                {
                    label1.Text = "Tavsan onde";
                }

                if (pictureBox2.Left > pictureBox1.Left)
                {
                    label1.Text = "Rabbit onde";
                }

                if (pictureBox1.Left == pictureBox2.Left)
                {
                    label1.Text = "Berabere";
                }


            }



        }
    }
}
