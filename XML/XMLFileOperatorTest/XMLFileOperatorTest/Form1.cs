using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLFileOperatorTest
{
    public partial class Form1 : Form
    {
        private XMLFileOperator.XMLFileOperator xmlOperator;

        public Form1()
        {
            InitializeComponent();

            xmlOperator = new XMLFileOperator.XMLFileOperator();
            contextMenuStrip1.Items[0].Click += TreeViewRefresh;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btn_CreateXMLFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "保存XML文件";
            saveFileDialog.Filter = "XML文件|*.xml";
            saveFileDialog.AutoUpgradeEnabled = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                xmlOperator.CreateFile(saveFileDialog.FileName);
            }
        }
        /// <summary>
        /// 打开XML文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "选择XML文件";
            openFileDialog.AutoUpgradeEnabled = true;
            openFileDialog.Filter = "XML文件|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = System.IO.Path.GetFullPath(openFileDialog.FileName);
                //MessageBox.Show(file);
                tbx_XMLFilePath.Text = file;
                xmlOperator.LoadXMLFile(file);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            xmlOperator.CreateChildNode(xmlOperator.XMLDocFile, xmlOperator.XMLRootNode, "name", "huzhiqian");
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(treeView1, e.X, e.Y);
            }
        }

        private void TreeViewRefresh(object sender, EventArgs e)
        {
            xmlOperator.ConvertXMLFileToTreeView(treeView1);
            treeView1.ExpandAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //List<System.Xml.XmlNode> nodeList = new List<System.Xml.XmlNode>();
            if (xmlOperator.XMLDocFile == null) return;
            //MessageBox.Show($"根节点名称：{xmlOperator.XMLDocFile.DocumentElement.Name}");
            GetAllChildNode(xmlOperator.XMLDocFile.DocumentElement, 0);
            
        }


        public void GetAllChildNode(System.Xml.XmlNode rootNode, int layer)
        {
            int layerIndex = layer;
            StringBuilder sb = new StringBuilder();
            for (int index = 0; index <= layerIndex - 1; index++)
                sb.Append(" ");
            sb.Append(rootNode.Name);
            //显示属性
            if (rootNode.Attributes != null && rootNode.Attributes.Count > 0)
            {
                foreach (System.Xml.XmlAttribute item in rootNode.Attributes)
                {
                    sb.Append(" ").Append(item.Name).Append("=").Append(item.Value);
                }
                listBox_NodeList.Items.Add(sb.ToString());
                listBox_NodeList.SelectedItem = sb.ToString();
            }
            if (rootNode.Value != null)
            {
                StringBuilder sb2 = new StringBuilder();
                for (int index = 0; index <= layerIndex; index++)
                    sb2.Append(" ");
                sb2.Append(rootNode.Value);
                listBox_NodeList.Items.Add(sb2.ToString());
                listBox_NodeList.SelectedItem = sb2.ToString();
            }

            if (!rootNode.HasChildNodes)
            {
                if (layerIndex > 0)
                    --layerIndex;
                return;
            }
            else
            {
                ++layerIndex;
            }
            System.Xml.XmlNodeList xmlNodeList = rootNode.ChildNodes;
            foreach (System.Xml.XmlNode xmlnode in xmlNodeList)
            {
                GetAllChildNode(xmlnode, layerIndex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox_NodeList.Items.Clear();

        }

    }
}
