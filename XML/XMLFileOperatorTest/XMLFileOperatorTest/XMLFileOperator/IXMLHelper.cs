 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace XMLFileOperatorTest.XMLFileOperator
{
    /// <summary>
    /// XML文件操作接口
    /// </summary>
   public interface IXMLHelper
    {
        /// <summary>
        /// 保存XML文件
        /// </summary>
        /// <param name="savePath">保存路径</param>
        void SaveXMLFile(string savePath);

        /// <summary>
        /// 加载XML文件
        /// </summary>
        /// <param name="fileName">文件全名</param>
        void LoadXMLFile(string fileName);

        /// <summary>
        /// 创建XML文件
        /// </summary>
        /// <param name="path">指定创建文件的路径</param>
        void CreateFile(string path);


        /// <summary>
        /// 创建子节点
        /// </summary>
        /// <param name="xmlDoc">XML文档</param>
        /// <param name="parentNode">根节点</param>
        /// <param name="name">子节点名称</param>
        /// <param name="value">节点值</param>
        void CreateChildNode(XmlDocument xmlDoc,XmlNode parentNode,string name,string value);


        /// <summary>
        /// 将XML文件转换成TreeView
        /// </summary>
        /// <param name="treeView">treeView控件</param>
        void ConvertXMLFileToTreeView(TreeView treeView);
        #region 事件


        #endregion
    }
}
