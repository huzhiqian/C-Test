﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.ComponentModel.Composition;


//**********************************************
//文件名：Engineer
//命名空间：SimpleMEFDemo
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2019/5/10 22:02:59
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace SimpleMEFDemo
{
    [Export(typeof(IWorkService))]
   public class Engineer:IWorkService
    {

        #region 构造函数

        public Engineer()
        {

        }



        #endregion


        #region 属性


        public string WorkName { get; set; }


        #endregion

        #region 公共方法

        public void DoWork()
        {
            Console.WriteLine("Engineer Do Something");
        }

        public string GetWorkName()
        {
            return WorkName;
        }

        #endregion

        #region 私有方法



        #endregion

        #region 委托



        #endregion

        #region 事件



        #endregion
    }
}
