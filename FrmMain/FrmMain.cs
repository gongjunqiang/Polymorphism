using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public void PassMesg(string msg, string childName)
        {
            this.textBox1.Text += $"来自{childName}的消息{msg}\r\n";
           
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                FrmChild frmChild = new FrmChild($"子窗体{i+1}");
                frmChild.passMesgdelegate = PassMesg;
                 frmChild.Show();
            }
        }
    }


    public delegate void PassMesgdelegate(string msg, string childName);
}
