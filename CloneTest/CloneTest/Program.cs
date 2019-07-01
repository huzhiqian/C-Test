﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloneTest
{
    class Program
    {
        /*测试名称：深拷贝和浅拷贝测试
         * 目的：测试浅拷贝和深拷贝的区别
         * 
         * 
         * 测试结果：浅拷贝--浅拷贝会将对象的所有值类型的数据全部拷贝到新的对象中重新创建的值类型上，
         *                特殊的，string类型的值也会被拷贝过去。而对象上的引用类型只是拷贝其中的引用地址（指针）
         *         深拷贝--深拷贝会将对象的所有数据完全拷贝并重新赋值到新的对象中。
         * 
         * 
         */

        static void Main(string[] args)
        {
            try
            {
                CPerson p1 = new CPerson(11, "管理")
                {
                    ID=321084,
                    Name="胡志乾"
                };
                CPerson p2 = new CPerson(50, "工程师")
                {
                    ID=55687,
                    Name="pz"
                };

                CPerson p3 = p1.ShallowClone();     //浅拷贝对象
                CPerson p4 = p2.DeepClone();

                Console.WriteLine($"--p1--,ID:{p1.ID},Name:{p1.Name},JobID:{p1.MyJob.WorkID},JobName:{p1.MyJob.JobName}");
                Console.WriteLine($"--p2--,ID:{p2.ID},Name:{p2.Name},JobID:{p2.MyJob.WorkID},JobName:{p2.MyJob.JobName}");
                Console.WriteLine($"--p3--,ID:{p3.ID},Name:{p3.Name},JobID:{p3.MyJob.WorkID},JobName:{p3.MyJob.JobName}");
                Console.WriteLine($"--p4--,ID:{p4.ID},Name:{p4.Name},JobID:{p4.MyJob.WorkID},JobName:{p4.MyJob.JobName}");


                Console.WriteLine("************修改原始对象******************");

                p1.ID = 222;
                p1.Name = "胡志乾2";
                p1.MyJob.JobName = "系统工程师";

                p2.ID = 3333;
                p2.Name = "胡志乾3";
                p2.MyJob.JobName = "软件工程师";

                Console.WriteLine($"--p1--,ID:{p1.ID},Name:{p1.Name},JobID:{p1.MyJob.WorkID},JobName:{p1.MyJob.JobName}");
                Console.WriteLine($"--p3--,ID:{p3.ID},Name:{p3.Name},JobID:{p3.MyJob.WorkID},JobName:{p3.MyJob.JobName}");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"--p2--,ID:{p2.ID},Name:{p2.Name},JobID:{p2.MyJob.WorkID},JobName:{p2.MyJob.JobName}");
                Console.WriteLine($"--p4--,ID:{p4.ID},Name:{p4.Name},JobID:{p4.MyJob.WorkID},JobName:{p4.MyJob.JobName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
                        Console.ReadLine();
        }
    }
}
