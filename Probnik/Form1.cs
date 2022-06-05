using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" || textBox1.Text == "polzovatel")
            {
                if(textBox2.Text == "12345")
                {
                    Form f5 = new Form5();
                    f5.Show();
                    Hide();
                }
                if (textBox2.Text == "54321")
                {
                    Form2 f2 = new Form2();
                    f2.Show();
                    Hide();
                }
            }
            else 
            {
                MessageBox.Show("Не верный логин или пароль");
            }
        }
    }
}
