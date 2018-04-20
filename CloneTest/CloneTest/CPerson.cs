﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


//**********************************************
//文件名：CPerson
//命名空间：CloneTest
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2018/4/18 17:25:10
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace CloneTest
{
    [Serializable]
    class CPerson:ICloneable
    {

        private CJob myJob;
        #region 构造函数

        public CPerson(int job_id,string job_nname)
        {
            myJob = new CJob() {
                JobName = job_nname,
                WorkID=job_id
            };
        }

        #endregion


        #region 属性

        public int ID { get; set; } = 0;

        public string Name { get; set; } = "";

        public CJob MyJob
        {
            get { return myJob; }
        }

        /// <summary>
        /// 浅拷贝
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// 返回当前对象的浅拷贝副本
        /// </summary>
        /// <returns></returns>
        public CPerson ShallowClone()
        {
            return Clone() as CPerson;
        }


        public CPerson DeepClone()
        {
            using (Stream objectStream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(objectStream,this);
                objectStream.Seek(0,SeekOrigin.Begin);
                return formatter.Deserialize(objectStream) as CPerson;
            }
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
