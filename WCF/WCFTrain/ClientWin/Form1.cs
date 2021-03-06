﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientWin.ServiceReference1;
using ServerWin;
using IGeeter = ServerWin.IGeeter;

namespace ClientWin
{
    public partial class Form1 : Form
    {
        private ServiceReference1.IGeeter client;
        public Form1()
        {
            InitializeComponent();
            client = new GeeterClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text = textBox1.Text;
                MessageBox.Show(client.Greet(text));
            }
            catch (TimeoutException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (FaultException<GreetFault> exception)
            {
                MessageBox.Show(exception.Detail.Message);
            }
            catch (FaultException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (CommunicationException commProblem)
            {
                MessageBox.Show($"CommunicationException: {commProblem.Message}");
            }

        }
    }
}
