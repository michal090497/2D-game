﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class lvl2 : Form
    {
        public static PictureBox[] boxes;
        public static PictureBox[] buildings;
        public lvl2()
        {
            InitializeComponent();
            textBox4.Visible = false;
            textBox5.Visible = false;
            button3.Visible = false;
            //button
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            Klasa_glowna.damaged = 0;
            Klasa_glowna.damaged_procent = 0;
            Klasa_glowna.bombs_used = 0;
            textBox3.Text = Klasa_glowna.damaged_procent.ToString();
            textBox3.Text = textBox3.Text + " %";
            boxes = new PictureBox[349];
            for (int i = 0; i < 349; i++)
            {
                boxes[i] = new PictureBox();
                boxes[i].BackColor = Color.Green;
                if (i < 59)
                {
                    boxes[i].Location = new Point(i * 10, 352);
                    Application.DoEvents();
                    Update();
                }
                else if (i >= 59 && i < 118)
                {
                    boxes[i].Location = new Point((i - 59) * 10, 362);
                    Application.DoEvents();
                    Update();
                }
                else if (i >= 118 && i < 177)
                {
                    boxes[i].Location = new Point((i - 118) * 10, 372);
                    Application.DoEvents();
                    Update();
                }
                else if (i >= 177 && i < 236)
                {
                    boxes[i].Location = new Point((i - 177) * 10, 382);
                    Application.DoEvents();
                    Update();
                }
                else if (i >= 236 && i < 295)
                {
                    boxes[i].Location = new Point((i - 236) * 10, 392);
                    Application.DoEvents();
                    Update();
                }
                else if (i >= 295 && i < 349)
                {
                    boxes[i].Location = new Point((i - 295) * 10, 402);
                    Application.DoEvents();
                    Update();
                }
                boxes[i].Size = new Size(10, 10);
                boxes[i].Visible = true;
                this.Controls.AddRange(boxes);
                Application.DoEvents();
                Update();
            }
            buildings = new PictureBox[100];
            for (int i = 0; i < 100; i++)
            {
                buildings[i] = new PictureBox();
                buildings[i].BackColor = Color.Black;
                if (i >= 0 && i < 6)
                {
                    buildings[i].Location = new Point(240, 292 + (i * 10));
                    Application.DoEvents();
                    Update();
                }
                if (i >= 6 && i < 12)
                {
                    buildings[i].Location = new Point(250, 292 + ((i - 6) * 10));
                    Application.DoEvents();
                    Update();
                }
                if (i >= 12 && i < 16)
                {
                    buildings[i].Location = new Point(260, 312 + ((i - 12) * 10));
                    Application.DoEvents();
                    Update();
                }
                if (i >= 16 && i < 20)
                {
                    buildings[i].Location = new Point(270, 312 + ((i - 16) * 10));
                    Application.DoEvents();
                    Update();
                }
                if (i >= 20 && i < 26)
                {
                    buildings[i].Location = new Point(280, 292 + ((i - 20) * 10));
                    Application.DoEvents();
                    Update();
                }
                if (i >= 26 && i < 32)
                {
                    buildings[i].Location = new Point(290, 292 + ((i - 26) * 10));
                    Application.DoEvents();
                    Update();
                }
                if (i >= 32 && i < 36)
                {
                    buildings[i].Location = new Point(300, 312 + ((i - 32) * 10));
                    Application.DoEvents();
                    Update();
                }
                if (i >= 36 && i < 40)
                {
                    buildings[i].Location = new Point(310, 312 + ((i - 36) * 10));
                    Application.DoEvents();
                    Update();
                }
                if (i >= 40 && i < 45)
                {
                    buildings[i].Location = new Point(320, 302 + ((i - 40) * 10));
                    Application.DoEvents();
                    Update();
                }
                if (i >= 45 && i < 50)
                {
                    buildings[i].Location = new Point(330, 302 + ((i - 45) * 10));
                    Application.DoEvents();
                    Update();
                }
                if (i >= 50 && i < 55)
                {
                    buildings[i].Location = new Point(340, 302 + ((i - 50) * 10));
                    Application.DoEvents();
                    Update();
                }
                if (i >= 55 && i < 60)
                {
                    buildings[i].Location = new Point(350, 302 + ((i - 55) * 10));
                    Application.DoEvents();
                    Update();
                }
                if (i >= 60 && i < 70)
                {
                    buildings[i].Location = new Point(360, 252 + ((i - 60) * 10));
                    Application.DoEvents();
                    Update();
                }
                if (i >= 70 && i < 80)
                {
                    buildings[i].Location = new Point(370, 252 + ((i - 70) * 10));
                    Application.DoEvents();
                    Update();
                }
                buildings[i].Size = new Size(10, 10);
                buildings[i].Visible = true;
                this.Controls.AddRange(buildings);
                Application.DoEvents();
                Update();
            }
            this.textBox1.Visible = false;
            button4.Visible = false;
            //button5.Visible = false;
            //button6.Visible = false;
            //button7.Visible = false;
            //button8.Visible = false;
            pictureBox2.Visible = false;
            //pictureBox3.Visible = false;
            //pictureBox4.Visible = false;
            //pictureBox5.Visible = false;
            //pictureBox6.Visible = false;
            //pictureBox7.Visible = false;
            Klasa_glowna.bombs_used = 0;
        }

        private void lvl2_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            button6.Visible = true;
            pictureBox1.BackColor = Color.Transparent;
            Application.DoEvents();
            Update();
            while (true)
            {

                while (this.pictureBox1.Location.X == 12)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.samolot1;
                    for (int i = 12; i < 474; i++)
                    {
                        if (Klasa_glowna.wsp_pict_boxa != 0)
                        {
                            i = Klasa_glowna.wsp_pict_boxa;
                            Klasa_glowna.wsp_pict_boxa = 0;
                        }
                        Klasa_glowna.strona = 0;
                        System.Threading.Thread.Sleep(1);
                        this.pictureBox1.Location = new Point(i, 12);
                        Application.DoEvents();
                        Update();
                    }
                }
                while (this.pictureBox1.Location.X == 473)
                {
                    pictureBox1.Image = Properties.Resources.samolot2;
                    for (int i = 473; i > 11; i--)
                    {
                        if (Klasa_glowna.wsp_pict_boxa != 0)
                        {
                            i = Klasa_glowna.wsp_pict_boxa;
                            Klasa_glowna.wsp_pict_boxa = 0;
                        }
                        Klasa_glowna.strona = 1;
                        System.Threading.Thread.Sleep(1);
                        this.pictureBox1.Location = new Point(i, 12);
                        this.pictureBox2.Location = new Point(i, 12);
                        //this.pictureBox3.Location = new Point(i, 12);
                        //this.pictureBox4.Location = new Point(i, 12);
                        Application.DoEvents();
                        Update();
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            this.textBox1.Visible = true;
            pictureBox2.Visible = true;
            Klasa_glowna.bombs_used++;
            //pictureBox5.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Location = new Point(pictureBox1.Location.X + 40, 62);
            for (int i = 62; i < 401; i++)
            {
                if (Klasa_glowna.a == 1)
                {
                    Klasa_glowna.a = 0;
                    break;
                }
                this.pictureBox2.Location = new Point(pictureBox2.Location.X, i);
                Klasa_glowna.WspX_wybuchu1 = pictureBox2.Location.X;
                if (Klasa_glowna.strona == 0)
                {
                    if (pictureBox1.Location.X < 473)
                    {
                        this.pictureBox1.Location = new Point(Klasa_glowna.WspX_wybuchu1 - 102 + i, pictureBox1.Location.Y);
                        Application.DoEvents();
                        Update();
                    }
                }
                else if (Klasa_glowna.strona == 1)
                {
                    if (pictureBox1.Location.X > 12)
                    {
                        this.pictureBox1.Location = new Point(Klasa_glowna.WspX_wybuchu1 + 22 - i, pictureBox1.Location.Y);
                        Application.DoEvents();
                        Update();
                    }
                }
                Klasa_glowna.wsp_pict_boxa = pictureBox1.Location.X;
                if (pictureBox2.Location.Y > 200)
                {
                    if (pictureBox2.Location.X >= 220 && pictureBox2.Location.X <= 380)
                    {
                        for (int j = 0; j < 80; j++)
                        {
                            if (buildings[j].Visible == true)
                            {
                                if ((pictureBox2.Location.X <= buildings[j].Location.X + 10 && pictureBox2.Location.X >= buildings[j].Location.X) || (pictureBox2.Location.X + 20 >= buildings[j].Location.X && pictureBox2.Location.X <= buildings[j].Location.X))
                                {
                                    if (pictureBox2.Location.Y == buildings[j].Location.Y - 20)
                                    {

                                        for (int k = 0; k < 80; k++)
                                        {
                                            if ((buildings[k].Location.X <= pictureBox2.Location.X + 50) && (buildings[k].Location.X + 10 >= pictureBox2.Location.X - 30) && (buildings[k].Location.Y <= pictureBox2.Location.Y + 50) && (buildings[k].Location.Y + 10 >= pictureBox2.Location.Y - 30))
                                            {
                                                buildings[k].Visible = false;
                                            }
                                            if (k == 79)
                                            {
                                                for (int l = 0; l < 349; l++)
                                                {
                                                    if ((boxes[l].Location.X <= pictureBox2.Location.X + 50) && (boxes[l].Location.X + 10 >= pictureBox2.Location.X - 30) && (boxes[l].Location.Y <= pictureBox2.Location.Y + 50) && (boxes[l].Location.Y + 10 >= pictureBox2.Location.Y - 30))
                                                    {
                                                        boxes[l].Visible = false;
                                                    }
                                                }
                                                for (int m = 0; m < 80; m++)
                                                {
                                                    if (m<78 && buildings[79-m].Visible == false && buildings[78-m].Visible == true && buildings[79-m].Location.X == buildings[78-m].Location.X)
                                                    {
                                                        buildings[78-m].Visible = false;
                                                    }
                                                    if (buildings[m].Visible == false)
                                                    {
                                                        Klasa_glowna.damaged++;
                                                    }
                                                }
                                                Klasa_glowna.damaged_procent = (Klasa_glowna.damaged * 100) / 80;
                                                textBox3.Text = Klasa_glowna.damaged_procent.ToString();
                                                textBox3.Text = textBox3.Text + " %";
                                                Klasa_glowna.damaged = 0;
                                                Klasa_glowna.a = 1;
                                                if (Klasa_glowna.bombs_used != Klasa_glowna.hm_bombs)
                                                {
                                                    button6.Visible = true;
                                                }
                                                if (Klasa_glowna.damaged_procent == 100)
                                                {
                                                    Klasa_glowna.damaged = 0;
                                                    Klasa_glowna.damaged_procent = 0;
                                                    Klasa_glowna.bombs_used = 0;
                                                    Klasa_glowna.cash += 100;
                                                    if (Klasa_glowna.act_lvl < 3)
                                                    {
                                                        Klasa_glowna.act_lvl++;
                                                    }
                                                    textBox4.Visible = true;
                                                    System.Threading.Thread.Sleep(3000);
                                                    this.Hide();
                                                }
                                                break;
                                            }
                                        }
                                    }

                                }
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 349; j++)
                        {
                            if (boxes[j].Visible == true)
                            {
                                if ((pictureBox2.Location.X <= boxes[j].Location.X + 10 && pictureBox2.Location.X >= boxes[j].Location.X) || (pictureBox2.Location.X + 20 >= boxes[j].Location.X && pictureBox2.Location.X <= boxes[j].Location.X))
                                {
                                    if (pictureBox2.Location.Y == boxes[j].Location.Y - 20)
                                    {

                                        for (int k = 0; k < 80; k++)
                                        {
                                            if ((buildings[k].Location.X <= pictureBox2.Location.X + 50) && (buildings[k].Location.X + 10 >= pictureBox2.Location.X - 30) && (buildings[k].Location.Y <= pictureBox2.Location.Y + 50) && (buildings[k].Location.Y + 10 >= pictureBox2.Location.Y - 30))
                                            {
                                                buildings[k].Visible = false;
                                            }
                                            if (k == 79)
                                            {
                                                for (int l = 0; l < 349; l++)
                                                {
                                                    if ((boxes[l].Location.X <= pictureBox2.Location.X + 50) && (boxes[l].Location.X + 10 >= pictureBox2.Location.X - 30) && (boxes[l].Location.Y <= pictureBox2.Location.Y + 50) && (boxes[l].Location.Y + 10 >= pictureBox2.Location.Y - 30))
                                                    {
                                                        boxes[l].Visible = false;
                                                    }
                                                }
                                                for (int m = 0; m < 80; m++)
                                                {
                                                    if (m < 78 && buildings[79 - m].Visible == false && buildings[78 - m].Visible == true && buildings[79 - m].Location.X == buildings[78 - m].Location.X)
                                                    {
                                                        buildings[78 - m].Visible = false;
                                                    }
                                                    if (buildings[m].Visible == false)
                                                    {
                                                        Klasa_glowna.damaged++;
                                                    }
                                                }
                                                Klasa_glowna.damaged_procent = (Klasa_glowna.damaged * 100) / 80;
                                                textBox3.Text = Klasa_glowna.damaged_procent.ToString();
                                                textBox3.Text = textBox3.Text + " %";
                                                Klasa_glowna.damaged = 0;
                                                Klasa_glowna.a = 1;
                                                if (Klasa_glowna.bombs_used != Klasa_glowna.hm_bombs)
                                                {
                                                    button6.Visible = true;
                                                }
                                                if (Klasa_glowna.damaged_procent == 100)
                                                {
                                                    Klasa_glowna.damaged = 0;
                                                    Klasa_glowna.damaged_procent = 0;
                                                    Klasa_glowna.bombs_used = 0;
                                                    Klasa_glowna.cash += 100;
                                                    if (Klasa_glowna.act_lvl < 3)
                                                    {
                                                        Klasa_glowna.act_lvl++;
                                                    }
                                                    textBox4.Visible = true;
                                                    System.Threading.Thread.Sleep(3000);
                                                    this.Hide();
                                                }
                                                break;
                                            }
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
                Application.DoEvents();
                Update();
            }
            pictureBox2.Visible = false;
            this.textBox1.Visible = false;
            if (Klasa_glowna.damaged_procent != 100 && Klasa_glowna.bombs_used == Klasa_glowna.hm_bombs)
            {
                button6.Visible = false;
                Klasa_glowna.damaged = 0;
                Klasa_glowna.damaged_procent = 0;
                Klasa_glowna.bombs_used = 0;
                textBox5.Visible = true;
                System.Threading.Thread.Sleep(3000);
                this.Hide();
            }
        }
    }
}
