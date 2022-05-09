using System;
using System.Collections.Generic;
using System.Threading;

namespace SF_Module7_VirtualShop
{
    abstract class Payment
    {
        public virtual string Description { get; set; }

        public static void ChoosePayment(out int num)
        {
            Thread.Sleep(500);
            Console.WriteLine("\nВыберите способ оплаты");
            Console.WriteLine("\nНаличные - 1");
            Console.WriteLine("Карта - 2");
            Console.WriteLine("Счёт телефона - 3");
            Console.WriteLine("Криптовалюта - 4");
            Console.WriteLine("Кредит - 5\n");

            num = Convert.ToInt32(Console.ReadLine());
        }

        public static void PaymentPage()
        {
            Thread.Sleep(500);

            Console.WriteLine("\nПодключение модуля оплаты");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(". ");
                Thread.Sleep(500);
            }

            Console.WriteLine("\nПроверка сохраненных способов оплаты браузера");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(". ");
                Thread.Sleep(500);
            }

            Console.WriteLine("\nПлатёж получен");

            Thread.Sleep(500);

            Console.WriteLine("\n========================================");

            Console.WriteLine("\nПри получении заказа необходимо предъявить документ удостоверяющий личность");
        }
    }

    class CashPayment : Payment
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
                description = "Оплата наличными";
            }
        }

        public static void CashPaymentType()
        {
            Console.WriteLine("\nВы выбрали способ оплаты - наличные");
            Console.WriteLine("\nОжидайте уведомление о готовности в смс и по адресу электронной почты");
            Console.WriteLine("\nСпасибо за заказ!");
        }

    }

    class CardPayment : Payment
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
                description = "Оплата картой";
            }
        }

        public static void CardPaymentType()
        {
            Console.WriteLine("\nВы выбрали способ оплаты - карта");

            Payment.PaymentPage();

            Console.WriteLine("\nОжидайте уведомление о готовности в смс и по адресу электронной почты");

            Console.WriteLine("\nСпасибо за заказ!");
        }
    }

    class PhonePayment : Payment
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
                description = "Оплата со счета номера телефона";
            }
        }

        public static void PhonePaymentType()
        {
            Console.WriteLine("\nВы выбрали способ оплаты - счет номера телефона");

            Payment.PaymentPage();

            Console.WriteLine("\nОжидайте уведомление о готовности в смс и по адресу электронной почты");
            Console.WriteLine("\nСпасибо за заказ!");
        }
    }

    class CryptoPayment : Payment
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
                description = "Оплата криптовалютой";
            }
        }

        public static void CryptoPaymentType()
        {
            Console.WriteLine("\nВы выбрали способ оплаты - криптовалюта");

            Payment.PaymentPage();

            Console.WriteLine("\nОжидайте уведомление о готовности в смс и по адресу электронной почты");

            Console.WriteLine("\nСпасибо за заказ!");
        }
    }

    class CreditPayment : Payment
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
                description = "Оформление кредита";
            }
        }

        public static void CreditPaymentType()
        {
            Console.WriteLine("\nВы выбрали способ оплаты - кредит");
            Console.WriteLine("\nОформление кредита происходит по месту доставки, необходимо будет предъявить документ удостоверяющий личность");
            Console.WriteLine("\nОжидайте уведомление о готовности в смс и по адресу электронной почты");
            Console.WriteLine("\nСпасибо за заказ!");
        }
    }
}
