using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Delegate
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void GetValueClient(string value)
        {
            txtValue.Text = value;
        }

        private void GetValueClient1(string value)
        {
            txtValue2.Text = value;
        }   
        private void btGet_Click(object sender, EventArgs e)
        {
            FrmClient client = new FrmClient();
            client.sendValue = new FrmClient.SendValue(GetValueClient);
            client.Show();
        }

        private void btGet2_Click(object sender, EventArgs e)
        {
            FrmClient2 client1 = new FrmClient2();
            client1.sendValue = new FrmClient2.SendValue(GetValueClient1);
            client1.Show();
        }
    }
}
