﻿using System;
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form uti = new Form5();
            uti.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form sinAnt = new Form2();
            sinAnt.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form gram = new Form3();
            gram.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form ort = new Form4();
            ort.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
