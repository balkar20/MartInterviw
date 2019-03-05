﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var xval = int.Parse(textBox1.Text);
            var yval = int.Parse(textBox2.Text);

            var client = new CalcService.MultiplicatorClient("NetTcpBinding_IMultiplicator");

            label1.Text = client.GetMul(xval, yval).ToString();

            client.Close();
        }
    }
}
