using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressList
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)//确定
        {
            if(textBox1 .Text .Trim() == "")
            {
                MessageBox.Show("请输入组名！");
                return;
            }
            this.DialogResult = DialogResult.OK;
            

        }

        private void button2_Click(object sender, EventArgs e)//取消
        {
            this.Close();
        }
    }
}
