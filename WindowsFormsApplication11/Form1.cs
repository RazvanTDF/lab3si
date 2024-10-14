using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        ConversionHandler myConverter = new ConversionHandler();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
        
        }
        private void buttonVerify_Click(object sender, EventArgs e)
        {

        }

        private void buttonCompute_Click_1(object sender, EventArgs e)
        {
            MACHandler mh = new MACHandler(comboBoxMAC.Text);
            byte[] mac = mh.ComputeMAC(myConverter.StringToByteArray(textBoxPlain.Text), myConverter.StringToByteArray(textBoxKey.Text));
            textBoxMAC.Text = myConverter.ByteArrayToString(mac);
            textBoxMACHEX.Text = myConverter.ByteArrayToHexString(mac);
        }

        private void buttonVerify_Click_1(object sender, EventArgs e)
        {
            MACHandler mh = new MACHandler(comboBoxMAC.Text);

            if
        (mh.CheckAuthenticity(myConverter.StringToByteArray(textBoxPlain.Text),
        myConverter.HexStringToByteArray(textBoxMACHEX.Text), myConverter.StringToByteArray(textBoxKey.Text)) == true)
            {
                System.Windows.Forms.MessageBox.Show("MAC OK !!!");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("MAC NOT OK !!!");
            }
        }

        private void buttonHash_Click(object sender, EventArgs e)
        {
            MACHandler mh = new MACHandler(comboBoxMAC.Text);
            byte[] hash = mh.ComputeHash(myConverter.StringToByteArray(textBoxPlain.Text));
            textBox1.Text = myConverter.ByteArrayToString(hash);
        }
    }
}
