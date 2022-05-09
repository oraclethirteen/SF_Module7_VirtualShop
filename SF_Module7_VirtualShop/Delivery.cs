using System;
using System.Collections.Generic;
using System.Threading;

namespace SF_Module7_VirtualShop
{
    abstract class Delivery
    {
        public virtual string Description { get; set; }

        public static void ChooseDelivery(out int num)
        {
            Console.WriteLine("\nВыберите способ доставки:");
            Console.WriteLine("\nДоставка курьером - 1");
            Console.WriteLine("Доставка в точку выдачи - 2");
            Console.WriteLine("Самовывоз - 3\n");

            num = Convert.ToInt32(Console.ReadLine());
        }
    }

    class HomeDelivery : Delivery
    {
        private string description;

        public override string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = "Курьерская доставка до квартиры";
            }
        }

        public static void HomeDeliveryType(ref Product[] order, ref User user)
        {
            Console.WriteLine("\nВведите адрес доставки\n");

            string address = Console.ReadLine();
            Console.WriteLine();

            Order.OrderSuccess(ref order, ref address, ref user);
        }
    }

    class PickPointDelivery : Delivery
    {
        private string description;

        public override string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = "Доставка в пункт выдачи";
            }
        }

        public static void PickPointDeliveryType(ref Product[] order, ref User user)
        {
            Console.WriteLine("\nВыберите пункт выдачи\n");
            Console.WriteLine("г. Москва, Большой Николопесковский пер., д. 4, стр. 2 (м. Арбатская) - 1");
            Console.WriteLine("г. Москва, Лаврушинский переулок, д. 17, стр. 2 (м. Арбатская) - 2\n");

            int num = Convert.ToInt32(Console.ReadLine());

            string address = null;

            switch (num)
            {
                case 1:
                    address = "г. Москва, Большой Николопесковский пер., д. 4, стр. 2 (м. Арбатская) [Пункт выдачи]";
                    Order.OrderSuccess(ref order, ref address, ref user);
                    break;

                case 2:
                    address = "г. Москва, Лаврушинский переулок, д. 17, стр. 2 (м. Арбатская) [Пункт выдачи]";
                    Order.OrderSuccess(ref order, ref address, ref user);
                    break;

                default:
                    Console.WriteLine("Выберите адрес доставки!");
                    break;
            }
        }
    }

    class ShopDelivery : Delivery
    {
        private string description;

        public override string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = "Доставка в розничный магазин для самовывоза";
            }
        }

        public static void ShopDeliveryType(ref Product[] order, ref User user)
        {
            Console.WriteLine("\nВыберите магазин для самовывоза\n");
            Console.WriteLine("г. Москва, Комсомольский проспект, д. 24, стр. 1 (м. Фрунзенская) - 1");
            Console.WriteLine("г. Москва, проспект Мира, д. 29 (м. Проспект Мира) - 2\n");

            int num = Convert.ToInt32(Console.ReadLine());

            string address = null;

            switch (num)
            {
                case 1:
                    address = "г. Москва, Комсомольский проспект, д. 24, стр. 1 (м. Фрунзенская) [Самовывоз]";
                    Order.OrderSuccess(ref order, ref address, ref user);
                    break;

                case 2:
                    address = "г. Москва, проспект Мира, д. 29 (м. Проспект Мира) [Самовывоз]";
                    Order.OrderSuccess(ref order, ref address, ref user);
                    break;

                default:
                    Console.WriteLine("Выберите адрес доставки!");
                    break;
            }
        }
    }
}
