using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64Encoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.Default.GetBytes(textBox1.Text);
            textBox2.Text = Convert.ToBase64String(bytes);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] outputb = Convert.FromBase64String(textBox2.Text);
                textBox1.Text = Encoding.Default.GetString(outputb);
            }
            catch
            {
                textBox1.Text = "非法的Base64文本";
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }
    }
}
