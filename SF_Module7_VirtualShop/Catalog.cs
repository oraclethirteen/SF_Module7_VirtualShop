using System;
using System.Collections.Generic;
using System.Threading;

namespace SF_Module7_VirtualShop
{
    class Catalog
    {
        private static Product[] BuildCatalog()
        {
            List<Product> product = new List<Product>();

            Random RandomID = new Random();

            product.Add(new Product() { ProductName = "Mobile Phone", ProductDescription = "6.7" + '\u0022' + "(2778 x 1284) OLED 60 Гц, RAM 6 Гб, A14 Bionic, 512 Гб, 2 SIM, 3G / 4G LTE / 5G, iOS 14", ProductPrice = 249999.99, ProductID = RandomID.Next(10000, 99999) });
            product.Add(new Product() { ProductName = "Gaming Laptop", ProductDescription = "15.6" + '\u0022' + "(3840 x 2160) IPS, 120 Гц, RAM 32 Гб, Intel Core i9 (8x2.50 ГГц), NVIDIA GeForce RTX 3080 (16 ГБ), SSD 2Тб, Windows 10 Pro", ProductPrice = 599999.99, ProductID = RandomID.Next(10000, 99999) });

            Product[] catalog = product.ToArray();

            return catalog;
        }

        public static void ShowCatalog(out Product[] catalog)
        {
            catalog = BuildCatalog();

            foreach (Product product in catalog)
            {
                Console.WriteLine("\n[ {0} ] ID: {1} \n\n{2} \n\nЦЕНА: {3} руб.", product.ProductName, product.ProductID, product.ProductDescription, product.ProductPrice);
                Console.WriteLine("--------------------");
            }
        }
    }
}
