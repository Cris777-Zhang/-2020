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
using System.IO;

namespace AddressList
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string path = @"..\..\";
        public string personid;//成员变量，联系人的ID
        public bool interner = false;//成员变量，用来判断是新建还是修改联系人
        public Form3 (bool b)//构造函数，主要用来添加联系人的初始化
        {
            InitializeComponent();
            ReadList(path + @"List.xml", comboBox3);
            interner = b;

        }
        public Form3(string s)//构造函数，读取联系人
        {
            InitializeComponent();
            ReadList(path + @"List.xml", comboBox3);
            personid = s;
            ReadPerson(path + @"AddressList.xml");
            ShowPicture(personid);
        }

       
        private void ReadList(string XmlPath,ComboBox comboBox)//读取所有分组
        {
            XmlDocument xd = new XmlDocument();
            xd.Load(XmlPath);
            XmlNodeList nodelist = xd.SelectSingleNode("list").ChildNodes;
            foreach(XmlNode xn in nodelist)
            {
                XmlElement xe = (XmlElement)xn;
                comboBox.Items.Add(xe.InnerText);
            }

        }
        private void ReadPerson(string XmlPath)//读取选定的联系人信息
        {
            DataSet dataset = new DataSet();
            dataset.ReadXml(XmlPath);
            int id = Convert.ToInt32(personid);
            textBox1.Text = dataset.Tables["PersonList"].Rows[id - 1][1].ToString();//姓名
            dateTimePicker1.Text = dataset .Tables["PersonList"].Rows[id-1][2].ToString();//出生时间
            textBox2.Text = dataset.Tables["PersonList"].Rows[id - 1][3].ToString();//电话
            textBox3.Text = dataset.Tables["PersonList"].Rows[id - 1][4].ToString();//Emial
            textBox4.Text = dataset.Tables["PersonList"].Rows[id - 1][5].ToString();//QQ
            comboBox2.Text = dataset.Tables["PersonList"].Rows[id - 1][6].ToString();//性别
            textBox5.Text = dataset.Tables["PersonList"].Rows[id - 1][7].ToString();//地址
            textBox6.Text = dataset.Tables["PersonList"].Rows[id - 1][8].ToString();//详细信息
            comboBox3.Text = dataset.Tables["PersonList"].Rows[id - 1][9].ToString();//所在分组
        }
        private void ShowPicture(string str)//显示照片
        {
            if(!Directory .Exists(path + @"Picture"))
            {
                Directory.CreateDirectory(path + @"Picture");
                
            }
            string[] files = Directory.GetFiles(path + @"Picture");
            foreach(string file in files)
            {
                string filename = Path.GetFileName(file);

                if(filename == str + ".jpg")//读取照片
                {
                    using (FileStream fs = new FileStream(path + @"Picture\" + filename, FileMode.Open, FileAccess.Read))
                    {
                        pictureBox1.Image = Image.FromStream(fs);
                        fs.Close();
                    }
                     
                }
                if(filename == str + ".txt")//读取照片说明
                {
                    textBox7.Text = "";
                    using (StreamReader sr=new StreamReader (path + @"Picture\"+filename ))
                    {
                        while (sr.Peek() > 1)
                  	{
                            string strres = sr.ReadLine();          //读取一行
                            textBox7.AppendText(strres + "\r\n");
                        }
                    }
                }
            }
        }
        private void SavePicture(string str)//保存照片
        {
            if (!Directory.Exists(path + @"Picture"))//创建文件夹
            {
                Directory.CreateDirectory(path + @"Picture");
                return;
            }
            if (File.Exists(path + @"Picture\" + str + ".jpg"))//判断是否有照片，如果有销毁
            {
                File.Delete(path + @"Picture\" + str + ".jpg");
            }
            if(File .Exists (path + @"Picture\" + str + ".txt"))//判断是否有照片说明，如果有销毁
            {
                File.Exists(path + @"Picture\" + str + ".txt");
            }
            try
            {
                pictureBox1.Image.Save(path + @"Picture\" + str + ".jpg",System.Drawing .Imaging .ImageFormat.Jpeg );//写入照片

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FileStream fs = new FileStream(path + @"Picture\" + str + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sr = new StreamWriter(fs);
            sr.Flush();
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            sr.Write(textBox7.Text);
            sr.Flush();
            sr.Close();

            
        }
           
        private void button1_Click(object sender, EventArgs e)//保存
        {
            DataSet dataset = new DataSet();
            dataset.ReadXml(path + @"\AddressList.xml");
            if(interner)
            {
                DataRow myrow = dataset.Tables["PersonList"].NewRow();
                Form1.allPersonNum++;
                myrow["ID"] = Form1.allPersonNum.ToString();
                myrow["姓名"] = textBox1.Text.Trim().ToString();
                myrow["出生时间"] = dateTimePicker1.Text.Trim().ToString();
                myrow["电话"] = textBox2.Text.Trim().ToString();
                myrow["Email"] = textBox3.Text.Trim().ToString();
                myrow["QQ"] = textBox4.Text.Trim().ToString();
                myrow["性别"] = comboBox2.Text.ToString();
                myrow["地址"] = textBox5.Text.Trim().ToString();
                myrow["备注"] = textBox6.Text.Trim().ToString();
                myrow["所在分组"] = comboBox3.Text.ToString();
                dataset.Tables["PersonList"].Rows.Add(myrow);
                 
            }
            else
            {
                int id = Convert.ToInt32(personid);
                dataset.Tables["PersonList"].Rows[id - 1][1] = textBox1.Text.Trim();
                dataset.Tables["PersonList"].Rows[id - 1][2] = dateTimePicker1.Text.Trim();
                dataset.Tables["PersonList"].Rows[id - 1][3] = textBox2.Text.Trim();
                dataset.Tables["PersonList"].Rows[id - 1][4] = textBox3.Text.Trim();
                dataset.Tables["PersonList"].Rows[id - 1][5] = textBox4.Text.Trim();
                dataset.Tables["PersonList"].Rows[id - 1][6] = comboBox2.Text;
                dataset.Tables["PersonList"].Rows[id - 1][7] = textBox5.Text.Trim();
                dataset.Tables["PersonList"].Rows[id - 1][8] = textBox6.Text.Trim();
                dataset.Tables["PersonList"].Rows[id - 1][9] = comboBox3.Text;
            }
            dataset.WriteXml(path + @"\AdressList");
            SavePicture(personid);
            MessageBox.Show("保存成功");
            this.Close();
                                                   
        }

        private void button2_Click(object sender, EventArgs e)//取消
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)//添加照片
        {
            try
            {
                openFileDialog1.RestoreDirectory = true;//设置一个值确认对话框关闭前还原目录
                openFileDialog1.DefaultExt = "jpg";//默认文件扩展名
                openFileDialog1.Filter = "Jpeg文件(*.jpg)|*.jpg|gif文件(*.gif)|*.gif|bmp文件(*.bmp)|*.bmp";//筛选文件扩展名
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Image image = new Bitmap(openFileDialog1.FileName);
                    pictureBox1.Image = image;
                }
            }
            finally
            {
                openFileDialog1.Dispose();
            }
        }

        private void textBox7_Click(object sender, EventArgs e)//点击添加照片说明
        {
            textBox7.ReadOnly = false;
        }
    }
}
