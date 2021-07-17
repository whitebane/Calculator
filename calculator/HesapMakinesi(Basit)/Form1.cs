using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi_Basit_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            label2.Visible = false;
            label3.Visible = false;
            button1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
          
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (comboBox1.SelectedIndex==0)
            {
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label5.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";






            }

            else if (comboBox1.SelectedIndex == 1)
            {
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label5.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";

            }

            else if (comboBox1.SelectedIndex == 2)
            {
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label5.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";

            }

            else if (comboBox1.SelectedIndex==3)
            {
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label5.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, topla, cikar, carp, böl;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            if (comboBox1.SelectedIndex==0)
            {
                topla = s1 + s2;
                label5.Text = topla.ToString();
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                cikar = s1 - s2;
                label5.Text = cikar.ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                carp = s1 * s2;
                label5.Text = carp.ToString();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                böl = s1 / s2;
                label5.Text = böl.ToString();
            }

        }
    }
}
