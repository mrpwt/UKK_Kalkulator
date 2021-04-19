﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kalkulator_Rafif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            LBLHasil.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan 2 harus Diisi !!!");
            }
            else
            {
                double a, b, c;
                a = double.Parse(this.textBox1.Text);
                b = double.Parse(this.textBox2.Text);
                c = a + b;
                this.LBLHasil.Text = c.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            LBLHasil.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan 2 harus Diisi !!!");
            }
            else
            {
                double a, b, c;
                a = double.Parse(this.textBox1.Text);
                b = double.Parse(this.textBox2.Text);
                c = a - b;
                this.LBLHasil.Text = c.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan 2 harus Diisi !!!");
            }
            else
            {
                double a, b, c;
                a = double.Parse(this.textBox1.Text);
                b = double.Parse(this.textBox2.Text);
                c = a * b;
                this.LBLHasil.Text = c.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan 2 harus Diisi !!!");
            }
            else
            {
                double a, b, c;
                a = double.Parse(this.textBox1.Text);
                b = double.Parse(this.textBox2.Text);
                c = a / b;
                this.LBLHasil.Text = c.ToString();
            }
        }

        private void LBLHasil_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || "-.,".Contains(e.KeyChar)) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || "-.,".Contains(e.KeyChar)) && e.KeyChar != (char)Keys.Back;
        }
    }
}
