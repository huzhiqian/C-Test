﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：StopMachineState
//命名空间：StatePatternTest3.MotionSyatem
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/9 9:39:49
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace StatePatternTest3.MotionSyatem
{
   public class StopMachineState:State
    {

        #region 构造函数

        public StopMachineState()
        {
            motionState = MotionStateConstant.STOP;
        }



        #endregion


        #region 属性



        #endregion

        #region 公共方法

        public override void MotionStateHandle(MotionSYSContext context)
        {
            if (context.MotionState != MotionStateConstant.STOP)
            {
                Console.WriteLine("Stop Machine.");
                context.MotionState = MotionStateConstant.STOP;
            }           
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
