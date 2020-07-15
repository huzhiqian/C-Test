using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;


//**********************************************
//文件名：StartMachineState
//命名空间：StatePatternTest3.MotionSyatem
//CLR版本：4.0.30319.42000
//内容：
//功能：
//文件关系：
//作者：胡志乾
//小组：
//生成日期：2020/7/9 9:38:57
//版本号：V1.0.0.0
//修改日志：
//版权说明：
//联系电话：18352567214
//**********************************************

namespace StatePatternTest3.MotionSyatem
{
   public class StartMachineState:State
    {

        #region 构造函数

        public StartMachineState()
        {
            motionState = MotionStateConstant.RUNNING;

        }



        #endregion


        #region 属性



        #endregion

        #region 公共方法

        public override void MotionStateHandle(MotionSYSContext context)
        {
          
            Thread.Sleep(100);
            Console.WriteLine("Machine Running");
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
