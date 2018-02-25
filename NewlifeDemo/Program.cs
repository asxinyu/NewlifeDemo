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
            while(true)
            {
                XTrace.WriteLine(AppSet.Current.ServiceName);
                //休眠7000毫秒，重新获取
                System.Threading.Thread.Sleep(7000);
            }
            Console.WriteLine("完成");
            Console.ReadKey();
        }
    }
}
