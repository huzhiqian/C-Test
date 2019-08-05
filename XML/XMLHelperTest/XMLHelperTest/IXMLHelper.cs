using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;


namespace XMLHelperTest
{
    public interface IXMLHelper
    {

        /// <summary>
        /// 从本地读取XML文件
        /// </summary>
        /// <param name="path">XML文件完整路径</param>
        /// <returns></returns>
        bool LoadXMLFile(string path);

        /// <summary>
        /// 保存XML文件
        /// </summary>
        /// <param name="path">需要保存的路径</param>
        bool SaveXMLFile(string path);

        /// <summary>
        /// 创建一个新的XML文件
        /// </summary>
        /// <returns></returns>
        bool CreateXMLFile();

        /// <summary>
        /// 创建子节点
        /// </summary>
        /// <param name="xmlDoc">XML文档</param>
        /// <param name="parentNode">根节点</param>
        /// <param name="name">节点名称</param>
        /// <param name="value">节点值</param>
        void CreateChileNode(XmlDocument xmlDoc,XmlNode parentNode,string name,string value);

        /// <summary>
        /// 获取XML文档中的某个节点
        /// </summary>
        /// <param name="nodePath"></param>
        /// <returns></returns>
        XmlNode GetXMLSingleNode(string nodePath);
    }
}
