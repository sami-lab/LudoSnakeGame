using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Media;
namespace Ludo
{
    class Logics
    {
        public static int Rolldice(PictureBox p)
        {
            int dice = 0;
            Random r = new Random();
            dice = r.Next(1, 7);
            p.Image = Image.FromFile(@"" + dice + ".png");
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            return dice;
        }
        public static int move(ref int x, ref int y, int p, ref int dice, PictureBox px, Label l)
        {
            if (dice + p > 100)
            {
                l.Text = "Cannot move";
            }
            else
            {
                for (int i = 0; i < dice; i++)
                {
                    if (p == 10)
                    {
                        
                        y = 628;
                        x = 3;
                    }
                    else if (p == 20)
                    {
                        y = 551;
                        x = 3;
                    }
                    else if (p == 30)
                    {
                        y = 472;
                        x = 3;
                    }
                    else if (p == 40)
                    {
                        y = 396;
                        x = 3;
                    }
                    else if (p == 50)
                    {
                        y = 316;
                        x = 3;
                    }
                    else if (p == 60)
                    {
                        y = 239;
                        x = 3;
                    }
                    else if (p == 70)
                    {
                        y = 161;
                        x = 3;
                    }
                    else if (p == 80)
                    {
                        
                        y = 83;
                        x = 3;
                    }
                    else if (p == 90)
                    {
                        y = 3;
                        x = 3;
                    }
                    else
                    {
                        x += 99;
                    }
                    Thread.Sleep(50);
                    px.Location = new Point(x, y);
                    p++;
                    l.Text = p.ToString();
                }
            }
            return p;
        }
        public static int snackbite(ref int x, ref int y, ref int p,PictureBox p1)
        {
            SoundPlayer bite = new SoundPlayer(@"wrong click.wav");
            if (p == 34)
            {
                bite.Play();
                x =3;
                y = 707;
                p = 1;
            }
            else if (p == 25)
            {
                bite.Play();
                x = 403;
                y = 707;
                p = 5;
            }
            else if(p== 47)
            {
                bite.Play();
                x = 799; 
                y = 707;
                p = 9;
            }
            else if(p== 65)
            {
                bite.Play();
                x = 105;
                y = 318;
                p = 52;
            }
            else if (p == 99)
            {
                bite.Play();
                x = 800;
                y = 240;
                p = 69;
            }
            else if (p == 91)
            {
                bite.Play();
                x = 3;
                y = 239;
                p = 61;
            }
            else if(p == 87)
            {
                bite.Play();
                x = 599;
                y = 318;
                p = 57;
            }
            p1.Location = new Point(x, y);
            return p;
        }
        public static int ladder(ref int x, ref int y, ref int p, PictureBox p2)
        {
            SoundPlayer ladde = new SoundPlayer(@"rightselection_cut.wav");
            if (p == 3)
            {
                ladde.Play();
                y = 316;
                x = 3;
                p = 51;
            }
            else if (p == 6)
            {
                ladde.Play();
                x = 601;
                y = 550;
                p = 27;
            }
            else if(p == 20)
            {
                ladde.Play();
                x = 899;
                y = 240;
                p = 70;
            }
            else if (p == 36)
            {
                ladde.Play();
                x = 402;
                y = 318;
                p = 55;
            }
            else if(p == 68)
            {
                ladde.Play();
                x = 700;
                y = 5;
                p = 98;
            }
            else if (p == 63)
            {
                ladde.Play();
                x = 402;
                y = 7;
                p = 95;
            }

            p2.Location = new Point(x, y);
            return p;
        }
    }
}
