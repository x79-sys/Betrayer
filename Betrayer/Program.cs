using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Betrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            init_screen();
            menu();
        }
        static void innit()
        {
            init_screen();
            menu();
        }

        static void betgui()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("▄▄▄▄· ▄▄▄ .▄▄▄▄▄▄▄▄   ▄▄▄·  ▄· ▄▌▄▄▄ .▄▄▄  ");
            Console.WriteLine("▐█ ▀█▪▀▄.▀·•██  ▀▄ █·▐█ ▀█ ▐█▪██▌▀▄.▀·▀▄ █·");
            Console.WriteLine("▐█▀▀█▄▐▀▀▪▄ ▐█.▪▐▀▀▄ ▄█▀▀█ ▐█▌▐█▪▐▀▀▪▄▐▀▀▄ ");
            Console.WriteLine("██▄▪▐█▐█▄▄▌ ▐█▌·▐█•█▌▐█ ▪▐▌ ▐█▀·.▐█▄▄▌▐█•█▌");
            Console.WriteLine("·▀▀▀▀  ▀▀▀  ▀▀▀ .▀  ▀ ▀  ▀   ▀ •  ▀▀▀ .▀  ▀");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void menu()
        {
            Console.WriteLine("[A] Minecraft");
            Console.WriteLine("[B] Proxy Checker");
            Console.WriteLine("[C] Exit");
            Console.ForegroundColor = ConsoleColor.Red;
            string choice = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (choice == "A" || choice == "a")
            {
                mc();
            }
        }
        static void mc()
        {
            init_screen();
            Console.WriteLine("Please type the email");
            Console.ForegroundColor = ConsoleColor.Red;
            string user = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please type the password");
            Console.ForegroundColor = ConsoleColor.Red;
            string pass = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            string result = auth.login(user, pass);
            init_screen();
            Console.WriteLine(result);
            retrun();
        }
        static void init_screen()
        {
            Console.Clear();
            betgui();
        }
        static void retrun()
        {
            Console.WriteLine("Would you like to return to the main menu? [Y/N]");
            string choice = Console.ReadLine();
            if(choice == "Y" || choice == "y")
            {
                innit();
            }
            else if(choice == "N" || choice == "n")
            {
                Console.WriteLine("Hope to see you soon :)");
                Thread.Sleep(500);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Not yes or no please try again :)");
                retrun();
            }
        }
    }
}
