using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data;
using System.Windows.Forms; 

namespace AddressList
{
    //建个新类，实现了对List和AddressList的XML文件的主要读、 写、修改和删除的功能，调用更方便
    class TreeXML
    {
        TreeView thetreeview;//定义一个成员变量
        XmlDocument xd;//定义一个XmlDocument
        public TreeXML()//构造函数
        {
            xd = new XmlDocument();
        }
        ~TreeXML()//析构函数，释放资源
        {

        }
        public void AddXmlNode(string Xmlfilepath,string Xmlnodename)//添加同级分组
        {
            xd.Load(Xmlfilepath);
            XmlNode root = xd.SelectSingleNode("list");//寻找根节点
            XmlElement xe = xd.CreateElement("组名");//创建组名节点
            xe.InnerText = Xmlnodename;
            root.AppendChild(xe);//添加到跟节点中
            xd.Save(Xmlfilepath);//保存文件
        }
        //将数据添加到TreeView
        public void XMLtoTree(string Xmlfilepath,TreeView Thetreeview)
        {
            thetreeview = Thetreeview;
            xd.Load(Xmlfilepath);
            XmlNode root = xd.SelectSingleNode("list");
            foreach(XmlNode subxmlnode in root .ChildNodes)//遍历所有子节点
            {
                if(subxmlnode.Name == "组名")//匹配符合名字的节点
                {
                    TreeNode treenode = new TreeNode();//实例化一个树节点
                    treenode.Text = subxmlnode.InnerText;//子节点串联值作为树节点名称
                    thetreeview.Nodes.Add(treenode);//将树节点添加到TreeView中
                }
            }

        }
        public void DelXmlNode(string Xmlfilepath, string Xmlnodename)//删除分组
        {
            xd.Load(Xmlfilepath);
            XmlNodeList nodelist = xd.SelectSingleNode("list").ChildNodes;//获取节点集合
            foreach (XmlNode xn in nodelist)//遍历所有子节点
            {
                XmlElement xe = (XmlElement)xn;
                if(xe.InnerText ==Xmlnodename)//判断名字匹配
                {
                    xe.ParentNode.RemoveChild(xe);
                    xd.Save(Xmlfilepath);
                }
            }
        }
        public void UpdeteXmlNode(string Xmlfilepath,string OldNodeNam ,string NewNodeName)//修改分组
        {
            xd.Load(Xmlfilepath);
            XmlNodeList nodelist = xd.SelectSingleNode("list").ChildNodes;
            foreach(XmlNode xn in nodelist)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.InnerText == OldNodeNam)//判断名字匹配
                {
                    xe.InnerText = NewNodeName;//修改组名
                    xd.Save(Xmlfilepath);
                }
            }

        }
        public DataTable GetPersonInfo(string Xmlfilepath,string Xmlnodename)//获得选中分组所在联系人的信息
        {
            DataTable datatable = new DataTable();//建立一个新表
            datatable.Columns.Add("ID", typeof(string));//添加列名
            datatable.Columns.Add("姓名", typeof(string));
            datatable.Columns.Add("出生时间", typeof(string));
            datatable.Columns.Add("电话", typeof(string));
            datatable.Columns.Add("Email", typeof(string));
            datatable.Columns.Add("QQ", typeof(string));
            datatable.Columns.Add("性别", typeof(string));
            datatable.Columns.Add("地址", typeof(string));
            datatable.Columns.Add("备注", typeof(string));
            xd.Load(Xmlfilepath);
            XmlNodeList nodelist = xd.SelectSingleNode("CONTENTS").ChildNodes;
            foreach(XmlNode xn in nodelist)//遍历寻找符合的节点
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute ("所在分组") == Xmlnodename)//判断名字是否匹配
                {
                    DataRow myrow = datatable.NewRow();//建立新的一行
                    myrow["ID"] = xe.ChildNodes.Item(0).InnerText;//获取行数据
                    myrow["姓名"] = xe.ChildNodes.Item(1).InnerText;
                    myrow["出生时间"] = xe.ChildNodes.Item(2).InnerText;
                    myrow["电话"] = xe.ChildNodes.Item(3).InnerText;
                    myrow["Email"] = xe.ChildNodes.Item(4).InnerText;
                    myrow["QQ"] = xe.ChildNodes.Item(5).InnerXml;
                    myrow["性别"] = xe.ChildNodes.Item(6).InnerXml;
                    myrow["地址"] = xe.ChildNodes.Item(7).InnerXml;
                    myrow["备注"] = xe.ChildNodes.Item(8).InnerXml;
                    datatable.Rows.Add(myrow);//将所得行添加到新表中
                    xd.Save(Xmlfilepath);

                }
            }
            return datatable;
        
        }
        //public void DelPerson(string PersonName, string Xmlfilepath)另外一种删除联系人的方法
        //{
        //    xd.Load(Xmlfilepath);
        //    XmlNodeList nodelist = xd.SelectSingleNode("CONTENTS").ChildNodes;
        //    foreach(XmlNode xn in nodelist)
        //    {
        //        XmlElement xe = (XmlElement)xn;
        //        if(xe.ChildNodes .Item (1).InnerText ==PersonName)
        //        {
        //            xe.RemoveChild(xe);
        //            xd.Save(Xmlfilepath);
        //        }
        //    }
        //}


    }
}
