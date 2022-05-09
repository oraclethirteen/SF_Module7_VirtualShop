using System;
using System.Collections.Generic;
using System.Threading;

namespace SF_Module7_VirtualShop
{
    class User
    {
        public string UserFirstName { get; set; }
        public string UserSecondName { get; set; }
        public string UserMiddleName { get; set; }
        public string UsertID { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public static void UserRegistration(out User User)
        {
            Console.WriteLine("\n\t- Регистрация нового пользователя- ");

            Console.Write("Имя: ");
            string UserFirstName = Console.ReadLine();

            Console.Write("Фамилия: ");
            string UserSecondName = Console.ReadLine();

            Console.Write("Отчество: ");
            string UserMiddleName = Console.ReadLine();

            Console.Write("\nНомер телефона: ");
            string PhoneNumber = Console.ReadLine();

            Console.Write("Email: ");
            string Email = Console.ReadLine();

            Random RandomID = new Random();

            string UsertID = "UID" + RandomID.Next(10000, 99999).ToString();

            User user = new User(UserFirstName, UserSecondName, UserMiddleName, UsertID, PhoneNumber, Email);

            User = user;
        }

        public User(string UserFirstName, string UserSecondName, string UserMiddleName, string UsertID, string PhoneNumber, string Email)
        {
            this.UserFirstName = UserFirstName;
            this.UserSecondName = UserSecondName;
            this.UserMiddleName = UserMiddleName;
            this.UsertID = UsertID;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
        }
    }
}
