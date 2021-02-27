using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            textBox4.Text = Klasa_glowna.hm_bombs.ToString();
            if (Klasa_glowna.act_lvl == 1)
                {
                    button2.Visible = false;
                    button3.Visible = false;
                    Application.DoEvents();
                    Update();
                }
                if (Klasa_glowna.act_lvl == 2)
                {
                    button2.Visible = true;
                    button3.Visible = false;
                }
                if (Klasa_glowna.act_lvl == 3)
                {
                    button3.Visible = true;
                }
            textBox2.Text = Klasa_glowna.cash.ToString();
            button6.Visible = false;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                lvl1 Gra1 = new lvl1();
                Gra1.Show();
                if(Klasa_glowna.act_lvl==2)
                {
                button2.Visible = true;
                Application.DoEvents();
                Update();
                this.Refresh();
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        static public void aktualizuj()
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = Klasa_glowna.hm_bombs.ToString();
            textBox2.Text = Klasa_glowna.cash.ToString();
            if (Klasa_glowna.act_lvl == 2)
            {
                button2.Visible = true;
                Application.DoEvents();
                Update();
                this.Refresh();
            }
            if (Klasa_glowna.act_lvl == 3)
            {
                button3.Visible = true;
                Application.DoEvents();
                Update();
                this.Refresh();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(Klasa_glowna.cash>=150)
            {
                Klasa_glowna.hm_bombs++;
                Klasa_glowna.cash -= 150;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(Klasa_glowna.cash>=300)
            {
                Klasa_glowna.hm_bombs++;
                Klasa_glowna.cash -= 300;
                button6.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lvl2 Gra2 = new lvl2();
            Gra2.Show();
            if (Klasa_glowna.act_lvl == 3)
            {
                button3.Visible = true;
                Application.DoEvents();
                Update();
                this.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lvl3 Gra3 = new lvl3();
            Gra3.Show();
            Application.DoEvents();
            Update();
        }
    }
}
