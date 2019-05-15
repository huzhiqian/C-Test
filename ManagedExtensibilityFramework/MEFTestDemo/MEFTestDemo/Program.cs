using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MEFTestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CTest testObj = new CTest(System.Environment.CurrentDirectory);

            var mObj = testObj.GetClass("{D8CD4E3B-0427-47B6-B467-5C146F3C721F}");

            if (mObj != null)
            {
                mObj.WriteLog("Test");
            }
            Console.ReadLine();
        }
    }
}
