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
    public partial class FrmClient2 : Form
    {
        public delegate void SendValue(string value);
        public SendValue sendValue;
        public FrmClient2()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (sendValue != null)
                sendValue(txtValue2.Text);
            this.Hide();
        }
    }
}
