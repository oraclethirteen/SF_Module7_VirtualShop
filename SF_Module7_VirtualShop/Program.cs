using System;
using System.Collections.Generic;
using System.Threading;

namespace SF_Module7_VirtualShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t===== [ V I R T U A L   S H O P ] =====\n");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("\tДобро пожаловать в ВИРТУАЛЬНЫЙ МАГАЗИН !\n");
            Thread.Sleep(2000);

            Console.WriteLine("\n==================== К А Т А Л О Г ====================");

            ShoppingCart.ShoppingCartAdd();

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
