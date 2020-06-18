using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猜题
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            Console.WriteLine("请输入一个数");
            int b = Convert.ToInt32(Console.ReadLine());
            while(a!=b)
            {
                if(b>a)
                {
                    Console.WriteLine("你猜大了,请重新输入");
                    int c = Convert.ToInt32(Console.ReadLine());
                    b = c;
                }
                else
                {
                    Console.WriteLine("你猜小了,请重新输入");
                    int d = Convert.ToInt32(Console.ReadLine());
                    b = d;
                }
            }
            Console.WriteLine("你猜对了");
            Console.ReadKey();
        }
        //{
        //    int a = 100;
        //    Console.WriteLine("请输入一个数");
        //    int b = Convert.ToInt32(Console.ReadLine());

        //    if (b < a)
        //    {
        //        while (b < a)
        //        {
        //            Console.WriteLine("你猜小了,请重新输入");
        //            int c = Convert.ToInt32(Console.ReadLine());
        //            b = c;
        //            if (b > a)
        //            {
        //                while (b > a)
        //                {
        //                    Console.WriteLine("你猜大了,请重新输入");
        //                    int d = Convert.ToInt32(Console.ReadLine());
        //                    b = d;
        //                }
        //            }
        //            if (a == b)
        //            {
        //                Console.WriteLine("你猜对了");
        //                Console.ReadKey();
        //            }
        //        }
        //    }
        //    if (b > a)
        //    {
        //        while (b >a)
        //        {
        //            Console.WriteLine("你猜小了,请重新输入");
        //            int c = Convert.ToInt32(Console.ReadLine());
        //            b = c;
        //            if (b < a)
        //            {
        //                while (b <a)
        //                {
        //                    Console.WriteLine("你猜大了,请重新输入");
        //                    int d = Convert.ToInt32(Console.ReadLine());
        //                    b = d;
        //                }
        //            }
        //            if (a == b)
        //            {
        //                Console.WriteLine("你猜对了");
        //                Console.ReadKey();
        //            }
        //        }
        //    }

        //}
    }
}
