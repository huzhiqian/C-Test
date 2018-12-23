﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace SerializeTest2
{
    [Serializable]
    public class MainObject : ISerializable
    {
        private int ivalue = 1;
        private double dvalue = 1.0;
        private string svalue = "123";
        private InnerObject m_innerObj;
        public MainObject()
        {
            m_innerObj = new InnerObject();
        }

        public MainObject(SerializationInfo info, StreamingContext context)
        {
            MessageBox.Show($"{DateTime.Now.ToString("HH:mm:ss.fff")}:Main 序列化开始");
            ivalue = info.GetInt32("ivalue");
            dvalue = info.GetDouble("dvalue");
            svalue = info.GetString("svalue");
            MessageBox.Show($"{DateTime.Now.ToString("HH:mm:ss.fff")}:加载InnerObj");
            m_innerObj = (InnerObject)info.GetValue("innerObject",typeof(InnerObject));
         
        }
        public int IntValue
        {
            get { return ivalue; }
            set
            {
                if (value != ivalue)
                {
                    ivalue = value;
                }
            }
        }


        public double DoubleValue
        {
            get { return dvalue; }
            set
            {
                if (dvalue != value)
                {
                    dvalue = value;
                }
            }
        }

        public string StringValue
        {
            get { return svalue; }
            set
            {
                if (svalue != value)
                {
                    svalue = value;
                }
            }
        }

        public InnerObject myInnerObj
        {
            get { return m_innerObj; }
            set
            {
                if (m_innerObj != value)
                {
                    m_innerObj = value;
                }
            }
        }
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ivalue", ivalue);
            info.AddValue("dvalue", dvalue);
            info.AddValue("svalue", svalue);
            info.AddValue("innerObject",m_innerObj);
        }
    }
}
