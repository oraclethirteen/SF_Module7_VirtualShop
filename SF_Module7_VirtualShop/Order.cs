using System;
using System.Collections.Generic;
using System.Threading;

namespace SF_Module7_VirtualShop
{
    class Order
    {
        public static void ShowOrder(ref Product[] order)
        {
            for (int i = 0; i < order.Length; i++)
            {
                Console.WriteLine(i + 1 + " [{0}] ID: {1}, Цена: {2}", order[i].ProductName, order[i].ProductID, order[i].ProductPrice);
            }
        }

        public static void OrderSuccess(ref Product[] order, ref string address, ref User user)
        {
            Random RandomID = new Random();

            Console.Clear();
            Console.WriteLine("\t- Информация о заказе -");
            Console.WriteLine("\nЗаказ №" + RandomID.Next(10000, 99999));
            DateTime datetime = DateTime.Now;
            Console.WriteLine("\nВремя заказа: {0}", datetime);
            Console.WriteLine();

            ShowOrder(ref order);

            double summ = 0;

            for (int i = 0; i < order.Length; i++)
            {
                summ += order[i].ProductPrice;
            }

            Console.WriteLine("\nСумма заказа: {0}", summ);

            Console.WriteLine("\n\t- Информация о заказчике -");
            Console.WriteLine("\nФИО: {0} {1} {2}", user.UserSecondName, user.UserFirstName, user.UserMiddleName);
            Console.WriteLine("Телефон: {0}", user.PhoneNumber);
            Console.WriteLine("Email: {0}", user.Email);
            Console.WriteLine("Адрес доставки: {0}", address);
            Console.WriteLine("\nОриентировочная дата доставки - {0}", DateTimeExtensions.DeliveryOrientTime(datetime).ToShortDateString());

            Payment.ChoosePayment(out int num);

            switch (num)
            {
                case 1:
                    CashPayment.CashPaymentType();
                    break;

                case 2:
                    CardPayment.CardPaymentType();
                    break;

                case 3:
                    PhonePayment.PhonePaymentType();
                    break;

                case 4:
                    CryptoPayment.CryptoPaymentType();
                    break;

                case 5:
                    CreditPayment.CreditPaymentType();
                    break;

                default:
                    Console.WriteLine("Выберите способ оплаты!");
                    break;
            }
        }
    }

    static class DateTimeExtensions
    {
        public static DateTime DeliveryOrientTime(this DateTime source)
        {
            DateTime today = DateTime.Now;
            return today.AddDays(2);
        }
    }
}
