using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Xml;
using System.IO;
using System.Windows.Forms;


//**********************************************
//文件名：XMLFileOperator
//命名空间：XMLFileOperatorTest.XMLFileOperator
//CLR版本：4.0.30319.42000
//内容：
//功能：XML文件操作类
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2019/4/28 20:53:00
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace XMLFileOperatorTest.XMLFileOperator
{
    class XMLFileOperator : IXMLHelper
    {
        private XmlDocument xmlDocFile;

        private XmlNode rootNode;
        private string xmlFilePath;
        #region 构造函数

        public XMLFileOperator()
        {

        }



        #endregion


        #region 属性

        /// <summary>
        /// XML文件
        /// </summary>
        public XmlDocument XMLDocFile
        {
            get { return xmlDocFile; }
        }

        /// <summary>
        /// XML文件根节点
        /// </summary>
        public XmlNode XMLRootNode
        {
            get { return rootNode; }
        }


        #endregion

        #region 公共方法

        /// <summary>
        /// 保存XML文件
        /// </summary>
        /// <param name="savePath"></param>
        public void SaveXMLFile(string savePath)
        {
            try
            {
                if (xmlDocFile == null)
                    throw new NullReferenceException("XML文件为空，保存出错！");

                xmlDocFile.Save(savePath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 加载XML文件
        /// </summary>
        /// <param name="fileName">XML文件路径</param>
        public void LoadXMLFile(string fileName)
        {
            //判断文件是不是xml文件
            if (!(fileName.EndsWith(".xml") || fileName.EndsWith(".XML")))
                throw new NotSupportedException("文件格式不对，请选择XML文件!");
            //判断文件是否存在
            if (!System.IO.File.Exists(fileName))
                throw new FileNotFoundException(string.Format("文件{0}不存在！", fileName));

            try
            {
                xmlDocFile = new XmlDocument();
                xmlDocFile.Load(fileName);
                rootNode = xmlDocFile.DocumentElement;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 创建XML文件
        /// </summary>
        /// <param name="path">文件路径</param>
        public void CreateFile(string path)
        {
            xmlFilePath = path;
            xmlDocFile = new XmlDocument();
            //创建类型声明节点    
            XmlNode node = xmlDocFile.CreateXmlDeclaration("1.0", "utf-8", "");
            xmlDocFile.AppendChild(node);
            //创建根节点，创建XML文件必须有根节点
            XmlElement root = xmlDocFile.CreateElement("Root");
            xmlDocFile.AppendChild(root);
            rootNode = root;
            SaveXMLFile(path);
        }

        /// <summary>
        /// 创建XML子节点
        /// </summary>
        /// <param name="xmlDoc">XML文档</param>
        /// <param name="parentNode">父节点</param>
        /// <param name="name">节点名称</param>
        /// <param name="value">节点值</param>
        public void CreateChildNode(XmlDocument xmlDoc, XmlNode parentNode, string name, string value)
        {
            XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, name, null);
            node.InnerText = value;
            parentNode.AppendChild(node);
        }


        /// <summary>
        /// 将XML文件转换成TreeView
        /// </summary>
        /// <param name="treeView">treeView控件</param>
        public void ConvertXMLFileToTreeView(TreeView treeView)
        {
            if (xmlDocFile == null) return;
            //Clear treeview
            treeView.Nodes.Clear();
          
            if (rootNode != null)
                XMLToTreeview( treeView.Nodes, rootNode);
        }
        #endregion

        #region 私有方法

        private void XMLToTreeview( TreeNodeCollection treeRootNodes, XmlNode xmlRootNode)
        {
            TreeNode treeNode = new TreeNode();
            if (xmlRootNode.Attributes != null && xmlRootNode.Attributes.Count > 0)
            {
                StringBuilder sb = new StringBuilder(xmlRootNode.Name);
                foreach (System.Xml.XmlAttribute item in xmlRootNode.Attributes)
                {
                    sb.Append(" ").Append(item.Name).Append("=").Append(item.Value);
                }
                treeNode = treeRootNodes.Add(sb.ToString());

            }
            else
            {
               if(xmlRootNode.NodeType!= XmlNodeType.Text)
                treeNode = treeRootNodes.Add(xmlRootNode.Name);
            }
            if (xmlRootNode.Value != null)
            {
                treeNode= treeRootNodes.Add(string.Format("Value:{0}", xmlRootNode.Value));
            }
            if (!xmlRootNode.HasChildNodes)
            {
                return;
            }

            System.Xml.XmlNodeList xmlNodeList = xmlRootNode.ChildNodes;
            foreach (System.Xml.XmlNode xmlnode in xmlNodeList)
            {
                    XMLToTreeview( treeNode.Nodes, xmlnode);
            }
        }

        #endregion

        #region 委托



        #endregion

        #region 事件



        #endregion
    }
}
