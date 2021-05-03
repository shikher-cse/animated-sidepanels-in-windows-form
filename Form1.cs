using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            panel4.Width = pictureBox2.Width / 2;
            panel4.Top = pictureBox2.Top;
        }


     
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            label3.Show();
            pictureBox1.Location = new Point(-1, -1);
            label4.Location = new Point(310, 553);
            label3.Location = new Point(3, -1);
        }

        private void picturebox(object sender, EventArgs e)   
        {
          
           
            if (panel1.Visible)
            {
                label3.Show();
                panel1.Hide();
                pictureBox1.Location = new Point(-1, -1);

            }
        else
            {
                label3.Hide();
                panel1.Show();
                pictureBox1.Location = new Point(92,0);
                
                

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

      
       

        private void label4_Click(object sender, EventArgs e)
        {

            if (panel2.Visible)
            {
                panel2.Hide();
                pictureBox1.Location = new Point(310, 589);

            }
            else
            {
                panel2.Show();
                pictureBox1.Location = new Point(310, 538);

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Height = button2.Height;
            panel3.Top = button2.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Height = button3.Height;
            panel3.Top = button3.Top;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel4.Width = pictureBox2.Width / 2;
            panel4.Top = pictureBox2.Top;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel4.Width = pictureBox3.Width / 2;
            panel4.Top = pictureBox3.Top;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel4.Width = pictureBox4.Width / 2;
            panel4.Top = pictureBox4.Top;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel4.Width = pictureBox5.Width / 2;
            panel4.Top = pictureBox5.Top;
        }
    }
}
