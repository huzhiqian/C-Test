﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using HalconDotNet;
using System.Windows;
using System.Runtime.Serialization;
using System.Windows.Forms;

//**********************************************
//文件名：CImageInfo
//命名空间：SerializeTest
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2018/4/25 9:49:33
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace CustomSerializationTest
{
    [Serializable]
   public class CImageInfo:ISerializable
    {

        public HObject ho_Image;
        private int _imageID = 0;
        private HTuple myValue = 10.2;
        #region 构造函数

        public CImageInfo()
        {
            MessageBox.Show(this.GetType().ToString()+"被构造");
        }

        public CImageInfo(SerializationInfo info, StreamingContext context)
        {
            ho_Image = (HObject)info.GetValue("ho_Image",typeof(HObject));
            ImageName= (string)info.GetValue("ImageName", typeof(string));
            ImageID= (int)info.GetValue("ImageID", typeof(int));
            CreateTime=(string)info.GetValue("CreateTime", typeof(string));
            SerializeType=(SerializeTypeEnum)info.GetValue("SerializeType", typeof(SerializeTypeEnum));
            MyValue= (HTuple)info.GetValue("MyValue", typeof(HTuple));
            MessageBox.Show("自定义序列化构造函数");
        }
        
        #endregion


        #region 属性
        
        public string ImageName { get; set; } = null;

        public int ImageID
        {
            get
            {
                return _imageID;
            }
            set
            {
                _imageID = value;
                          }
        }

        public string CreateTime { get; set; } = null;

        public SerializeTypeEnum SerializeType { get; set; } = SerializeTypeEnum.BIT;

        public HTuple MyValue
        {
            get
            {
                return myValue;
            }
            set
            {
                myValue = value;
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ho_Image", ho_Image,typeof(HObject));
            info.AddValue("ImageName",ImageName,typeof(string));
            info.AddValue("ImageID", ImageID,typeof(int));
            info.AddValue("CreateTime", CreateTime,typeof(string));
            info.AddValue("SerializeType", SerializeType,typeof(SerializeTypeEnum));
            info.AddValue("MyValue", MyValue,typeof(HTuple));
           
        }

        #endregion

        #region 公共方法



        #endregion

        #region 私有方法



        #endregion

        #region 委托



        #endregion

        #region 事件



        #endregion
    }
}
