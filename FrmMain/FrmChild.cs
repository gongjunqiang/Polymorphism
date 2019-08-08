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
    public partial class FrmChild : Form
    {
        public FrmChild(string name)
        {
            InitializeComponent();
            this.Text = name;
        }
        //3.创建委托
        public PassMesgdelegate passMesgdelegate = null;

        private void Button2_Click(object sender, EventArgs e)
        {
            passMesgdelegate(this.textBox1.Text,this.Text);
        }
    }
}
