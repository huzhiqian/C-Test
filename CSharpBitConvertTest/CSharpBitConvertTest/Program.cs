using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBitConvertTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int ivalue = 17463114;
            double dValue = 55.65;

            try
            {
                byte[] convertBytes = BitConverter.GetBytes(ivalue);
                byte[] cDoubleByte = BitConverter.GetBytes(dValue);

                Console.WriteLine("****************转化成字符串******************");
                string istr = BitConverter.ToString(convertBytes,0,convertBytes.Length);
                Console.WriteLine($"整型_字符数据：{istr}");

                string dstr = BitConverter.ToString(cDoubleByte,0, cDoubleByte.Length);
                Console.WriteLine($"浮点_字符数据：{dstr}");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
}
