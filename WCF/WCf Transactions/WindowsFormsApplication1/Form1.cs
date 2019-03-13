using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IserviceClient client = new IserviceClient();
                client.upload();
                MessageBox.Show("All is well!!!");
            }
            catch 
            {
                MessageBox.Show("Some error occured...");
            }         
        }
    }
}
