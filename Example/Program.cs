using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ВНИМАНИЕ. НЕ ЗАБУДЬТЕ УКАЗАТЬ АДРЕС ПОЧТОВОГО СЕРВЕРА, СУЩЕСТВУЮЩИЕ ИМЯ ПОЛЬЗОВАТЕЛЯ И ПАРОЛЬ!
             */
            // Pop3Lib.Client myPop3 = new Pop3Lib.Client("pop.yandex.ru", "логин", "пароль");
            Pop3Lib.Client myPop3 = new Pop3Lib.Client("pop.mail.ru", "bismarckxiv", "H>(CDpCxdiOBY=nt");

            Pop3Lib.MailItem m;
            while (myPop3.NextMail(out m))
            {
                Console.Write("Письмо от {0} с темой {1}", m.From, m.Subject);
                Console.WriteLine("Хотите его удалить (y/n)?");
                if (Console.ReadLine().ToLower().StartsWith("y"))
                {
                    // ставим текущему письму отметку об удалении
                    myPop3.Delete();
                    Console.WriteLine("Письмо помечено для удаления.");
                }
            }

            myPop3.Close();
            Console.ReadKey();
        }
    }
}
