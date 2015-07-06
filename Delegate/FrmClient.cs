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
    public partial class FrmClient : Form
    {
        public delegate void SendValue(string value);
        public SendValue sendValue;
        public FrmClient()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (sendValue != null)
                sendValue(txtValue.Text);
            this.Hide();
        }
    }
}
