using System;
using System.Collections.Generic;
using System.Threading;

namespace SF_Module7_VirtualShop
{
    class ShoppingCart
    {
        public static void ShoppingCartAdd()
        {
            Catalog.ShowCatalog(out Product[] catalog);

            int ProductID = 0;
            List<Product> order = new List<Product>();
            string YN = null;

            do
            {
                Thread.Sleep(500);
                Console.WriteLine("\nВведите < ID > товара, который желаете приобрести");
                Console.WriteLine();

                ProductID = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < catalog.Length; i++)
                {
                    if (ProductID == catalog[i].ProductID)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Товар [{0}] стоимостью {1} руб. успешно добавлен в корзину!", catalog[i].ProductName, catalog[i].ProductPrice);
                        order.Add(catalog[i]);
                    }
                }

                Console.WriteLine("\nЖелаете продолжить покупки? (Y | N)\n");

                YN = Console.ReadLine();

                if (YN == "Y" || YN == "y")
                {
                    YN = "Y";
                }
                else if (YN == "N" || YN == "n")
                {
                    YN = "N";
                }
            } while (YN == "Y" || YN == "y");

            Product[] orderoutput = order.ToArray();

            Console.Clear();
            Console.WriteLine("\t- К О Р З И Н А -\n");

            Order.ShowOrder(ref orderoutput);
            User.UserRegistration(out User user);

            Delivery.ChooseDelivery(out int num);

            switch (num)
            {
                case 1:
                    HomeDelivery.HomeDeliveryType(ref orderoutput, ref user);
                    break;

                case 2:
                    PickPointDelivery.PickPointDeliveryType(ref orderoutput, ref user);
                    break;

                case 3:
                    ShopDelivery.ShopDeliveryType(ref orderoutput, ref user);
                    break;

                default:
                    Console.WriteLine("Выберите тип доставки!");
                    break;
            }
        }
    }
}
