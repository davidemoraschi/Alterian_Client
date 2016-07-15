using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COMSERVERLib;

namespace Alterian_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IConnection oConn = new COMSERVERLib.SyConnection();
            IObject oSess = oConn.get_System("Test", "SYSTEM", "PASWORD") ;
        }
    }
}
