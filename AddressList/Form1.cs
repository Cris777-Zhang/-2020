using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AddressList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        DataSet dataset;
        public static string XmlPath;
        public static int allPersonNum;
        TreeXML tx = new AddressList.TreeXML();//实例化TreeXML类


        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)//退出系统
        {
            Application.Exit();
        }       

        private void 帮助HToolStripMenuItem_Click(object sender, EventArgs e)//帮助
        {
            Help form5 = new Help();
            form5.ShowDialog();
            form5.Dispose();
        }

        private void 添加联系人ToolStripMenuItem_Click(object sender, EventArgs e)//添加联系人
        {
            Form3 form3 = new Form3(true );
            form3.ShowDialog();
            读取联系人ToolStripMenuItem_Click(null, null);//重新刷新数据，读取联系人
            form3.Dispose();
        }

        private void 删除联系人ToolStripMenuItem_Click(object sender, EventArgs e)//删除联系人
        {
            DataGridViewSelectedRowCollection selectrow = dataGridView1.SelectedRows;
            if(selectrow .Count > 0)
            {
                DialogResult result = MessageBox.Show("确定要删除这些联系人吗？", "删除联系人", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);//删除做个警示判断
                if(result == DialogResult.Yes )
                {
                    foreach(DataGridViewRow Row in selectrow)
                    {
                        int i = Convert.ToInt32(Row.Cells["ID"].Value);
                        dataset = new DataSet();
                        dataset.ReadXml(@"..\..\AddressList.xml");
                        dataset.Tables["PersonList"].Rows[i].Delete();
                        dataset.WriteXml(@"..\..\AddressList.xml");
                        MessageBox.Show("删除成功");
                        读取联系人ToolStripMenuItem_Click(null, null);

                    }
                }
            }

       
        }

        private void 删除分组ToolStripMenuItem_Click(object sender, EventArgs e)//删除分组
        {

            if (treeView2.SelectedNode == null)
            {
                MessageBox.Show("请选择一个节点", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dResult = MessageBox.Show("确定要删除此节点所有内容吗？", "删除节点", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (dResult)
                {
                    case DialogResult.Yes:
                        
                        tx.DelXmlNode (@"..\..\List.xml", treeView2.SelectedNode.Text);
                        treeView2.SelectedNode.Remove();        //删除节点
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
        }

        private void 修改分组名称ToolStripMenuItem_Click(object sender, EventArgs e)//修改组
        {
            if(treeView2 .SelectedNode == null)//如果选中的为零，则重新选入
                { 
                MessageBox.Show("请选择要修改的节点！");
                return;
            }
            else
            {
                Form2 form2 = new Form2();
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    XmlPath = @"..\..\List.xml";
                    tx.UpdeteXmlNode(XmlPath, treeView2 .SelectedNode .Text , form2.textBox1 .Text );
                    treeView2.SelectedNode.Text = form2.textBox1.Text;                  
                    MessageBox.Show("修改成功！");

                }
                form2.Dispose();
            }
            
          
        }

        private void 读取联系人ToolStripMenuItem_Click(object sender, EventArgs e)//读取联系人
        {
            dataset = new DataSet();
            XmlPath = @"..\..\AddressList.xml";
            dataset.ReadXml(XmlPath, XmlReadMode.Auto);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dataset;
            dataGridView1.DataMember = "PersonList";
            allPersonNum = dataGridView1.RowCount;
            tssl2.Text = "通讯录总人数为：" + allPersonNum;

        }

        private void 添加同级分组ToolStripMenuItem_Click(object sender, EventArgs e)//添加同级分组
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog()==DialogResult.OK)
            {
                XmlPath = @"..\..\List.xml";
                string NodeName = form2.textBox1.Text.Trim();               
                tx.AddXmlNode(XmlPath, NodeName);
                tx.XMLtoTree(XmlPath, treeView2);
                MessageBox.Show("添加成功！");
                              
            }
            form2.Dispose();
           
        }

        private void 添加下级分组ToolStripMenuItem_Click(object sender, EventArgs e)//添加下级分组
        {

        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)//关于版本
        {
            AboutThis ab = new AboutThis();
            ab.ShowDialog();
            ab.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)//窗体加载
        {
            tssl1.Text = "当前时间：" + DateTime.Now.ToString();
            读取联系人ToolStripMenuItem_Click(null, null);//加载出所有联系人
            tx.XMLtoTree(@"..\..\List.xml", treeView2);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)//搜索联系人
        {
            //if(tsbox1 .Text .Trim() == "")另一种搜索方法
            //{
            //    MessageBox.Show("请输入要搜索的姓名");
            //    return;
            //}
            //DataGridViewRowCollection Rows = new DataGridViewRowCollection(dataGridView1 );
            //foreach (DataGridViewRow row in Rows)
            //{
            //    if(row .Cells [1].Value ==tsbox1.Text.Trim())
            //    {
            //        row.Selected = true;
            //    }
            //}
            dataset = new DataSet();
            dataset.ReadXml(@"..\..\AddressList.xml");
            DataView dv = dataset.Tables["PersonList"].DefaultView;//创建可以筛选的视图
            dv.RowFilter = "姓名='" + tsbox1 .Text.Trim() + "'";//筛选条件
            dataGridView1.DataSource = dv.ToTable();//视图转成数据表

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)//选中树节点某个分组
        {
            XmlPath = @"..\..\AddressList.xml";
            DataTable dt = new DataTable();
            dt=tx.GetPersonInfo(XmlPath, treeView2.SelectedNode.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//用户双击表中联系人，直接得到联系人详细信息
        {
            if(e.ColumnIndex >=0&&e.RowIndex >= 0)//判断触发的位置
            {
                string personid = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();//获取联系人的ID
                Form3 form3 = new Form3(personid);
                form3.ShowDialog();
            }

        }
    }
}
