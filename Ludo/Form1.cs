using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ludo
{
    public partial class Form1 : Form
    {
        int turn = 1; //Turns
        bool red = false;
        int x2 = 49, y2 = 707, q;//positions and locations of b
        bool green = false;
        int x = 3, y = 707, rolldice,p;
        System.Media.SoundPlayer click = new System.Media.SoundPlayer(@"lifeline_cut.wav");
        System.Media.SoundPlayer win = new System.Media.SoundPlayer(@"winning.wav");

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            click.Play();
            rolldice = Logics.Rolldice(pictureBox1);
            label2.Text = rolldice.ToString();
            if (green == true)
            {
               p =  Logics.move(ref x,ref y,p, ref rolldice, pictureBox4, label7);
            }
            #region First Turn
            if (label2.Text == "6" && green == false)
            {
                pictureBox2.Visible = false;
                pictureBox4.Visible = true;
                green = true;
                pictureBox4.Location = new Point(x, y);
                label7.Text = p.ToString();
                p++;
            } 
            #endregion
            if (p == 100)
            {
                win.Play();
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Visible = true;
                button4.Visible = true;
                label3.Visible = true;
                pictureBox6.Visible = true;
                return;
            }
            Logics.snackbite(ref x, ref y, ref p, pictureBox4);
            Logics.ladder(ref x, ref y, ref p, pictureBox4);
            label7.Text = p.ToString();

            if (rolldice == 6)
            {
                turn = 1;
            }
            else 
            {
                turn = 2;
                label4.Text = "Player" + turn + " Turn";
                label4.BackColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = true;
            }

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button2.Enabled= false;
                label4.Text = "Player" + turn + " Turn";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            click.Play();
            rolldice = Logics.Rolldice(pictureBox1);
            label2.Text = rolldice.ToString();
            if (red == true)
            {
                q = Logics.move(ref x2, ref y2, q, ref rolldice, pictureBox5, label10);
            }
            if (label2.Text == "6" && red == false)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = true;
                red = true;
                pictureBox5.Location = new Point(x2, y2);
                label10.Text = q.ToString();
                q++;
            }
            if (q == 100)
            {
                win.Play();
                button1.Enabled = false;
                button2.Enabled = false;
                label5.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                pictureBox6.Visible = true;
                return;
            }
            Logics.snackbite(ref x2, ref y2, ref q, pictureBox5);
            Logics.ladder(ref x2, ref y2, ref q, pictureBox5);
            label10.Text = q.ToString();
            if (rolldice == 6)
            {
                turn = 2;
            }
            else
            {
                turn = 1;
                label4.Text = "Player " + turn + " Turn";
                label4.BackColor = Color.Green;
                button2.Enabled = false;
                button1.Enabled = true;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            win.Stop();
            p = 0;
            q = 0;
            label3.Visible = false;
            label5.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


    }
}
