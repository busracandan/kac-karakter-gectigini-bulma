using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kaç_karakter_geçtığını_bulan_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    int ks;
        //    ks = textBox1.Text.Length;
        //    textBox2.Text = ks.ToString();
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int ks;
            ks = textBox1.Text.Length;
            textBox2.Text = ks.ToString();

        }
    }
}
