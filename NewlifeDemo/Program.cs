using NewLife.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewlifeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            XTrace.UseConsole();
           
            Console.WriteLine("完成");
            Console.ReadKey();
        }

        public static void ConfigTest1()
        {
            var name = AppSet.Current.ServiceName;//读取配置
            AppSet.Current.ServiceName = "TestName";//设置配置
            AppSet.Current.Save();//配置保存，有异步方法，程序中动态进行
           
            while (true)
            {
                XTrace.WriteLine(AppSet.Current.ServiceName);
                //休眠7000毫秒，重新获取
                System.Threading.Thread.Sleep(7000);
            }
        }
    }
}
