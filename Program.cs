using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace practicforwxam
{
    internal class Program
    {
        static void task1()
        {
            Console.WriteLine("enter 3 dogoit num");
            int num = int.Parse(Console.ReadLine());
            int hounderd = num / 100;
            int tens = num % 100 / 10;
            int ones = num % 10;
             if (tens == hounderd && ones ==tens)
            {
                Console.WriteLine("equel");
            }
            else
            {
                Console.WriteLine("not eqoul");
            }

        }
        static void task2()
        {
            Console.WriteLine("enter 3 digit num");
            int num = int.Parse(Console.ReadLine());
            int houndeds = num / 100;
            int tens = num % 100 / 10;
            int ones = num % 10;
            
            if (ones - tens == 1 && tens - houndeds ==1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        static void task3()
        {
            Console.WriteLine("what is your max amount?");
            int MaxAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("how muhc right now?");
            int amount = int.Parse(Console.ReadLine());
            double x = 0.15;

            if (amount <= MaxAmount * x)
            {
                Console.WriteLine("fill fuel");
            }
        }
        static void task4()
        {
            Console.WriteLine("what is your time?");
            int time = int.Parse(Console.ReadLine());

            if (time <=50)
            {
                Console.WriteLine("a");
            }
            else if (time > 50 && time <= 60)
            {
                Console.WriteLine("b");
            }
            else
            {
                Console.WriteLine("c");
            }

        }
        static void task5()
        {
            Console.WriteLine("enter 8 digit num");
            int num = int.Parse(Console.ReadLine());
            int day = num / 1000000;
            int month = num % 1000000 / 10000;
            int year = num % 10000; 
            Console.WriteLine("the year is " + year + "the month is " + month + "the day is " + day);

            if (month <=5 && month >= 3)
            {
                Console.WriteLine("spring");
            }
            else if (month <= 8 && month >= 6)
            {
                Console.WriteLine("summer");
            }
            else if (month <= 11 && month >= 9)
            {
                Console.WriteLine("ATTUOM");
            }
            else
            {
                Console.WriteLine("winter");
            }

        }
        static void task6()
        {
            Console.WriteLine("how much did you buy?");
            int amount = int.Parse(Console.ReadLine());
            int price = 48;

            if (amount > 100)
            {
                price = 43;
            }

            Console.WriteLine("your total price is: " + (price * amount));

        }
        static void task7()
        {
            Console.WriteLine("name?");
            string name = Console.ReadLine();
            Console.WriteLine("amount road");
            int numroad = int.Parse(Console.ReadLine());
            int price = numroad * 30;

            if (numroad > 8)
            {
                price = price - 10;
            }
            Console.WriteLine("your total price" + name + "is: "+ price);
        }
        static void task8()
        {
            Console.WriteLine("how much did you oreder?");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("price?");
            double pricepermeal = double.Parse(Console.ReadLine());
            double price = pricepermeal * amount;

            if (amount >50)
            {
                price = price - pricepermeal * 2;
            }

            Console.WriteLine("yout total price is:" + price);
        }
        static void task9()
        {
            Console.WriteLine("enter a char");
            char x = char.Parse(Console.ReadLine());

            if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u' || x == 'A' || x == 'E' || x == 'I' || x == 'O' || x == 'U')
            {
                if (x == 'A' || x == 'E' || x == 'I' || x == 'O' || x == 'U')
                {
                    Console.WriteLine("UPPERCASE");
                }
                else
                {
                    Console.WriteLine("LOWERCASE");
                }
            
            }
            else
            {
                Console.WriteLine("normal");
            }
            
            

        }
        static void task10()
        {
            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("how many day did you miss?");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("yout name is " + name + "and you miss" + day + "this month");

            if (day > 5)
            {
                Console.WriteLine("warning");
            }
            else if (day == 0)
            {
                Console.WriteLine("exlenet");
            }
        }
        static void task11()
        {
            Console.WriteLine("name");
            string name = Console.ReadLine();
            Console.WriteLine("amount");
            int amount = int.Parse(Console.ReadLine());
            int priceperone = 100;
            int totalprice = amount * priceperone;

            if (amount > 5)
            {
                Console.WriteLine("GIFT");
            }

            Console.WriteLine("your total price " + name + "is" + totalprice);
        }
        static void task12()
        {
            Console.WriteLine("the name of the factory?");
            string factory = Console.ReadLine();
            Console.WriteLine("how many wheel?");
            int wheel = int.Parse(Console.ReadLine());

            if (wheel > 4)
            {
                Console.WriteLine("hevy");
                Console.WriteLine(factory);
                
            }
            else if (wheel == 2)
            {
                Console.WriteLine("two");
                Console.WriteLine(factory);
            }
            else if (wheel < 1)
            {
                Console.WriteLine("error");
                Console.WriteLine(factory);
            }
            else
            {
                Console.WriteLine("have a good day");
            }
        }
        static void task13()
        {
            Console.WriteLine("age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("amount?");
            int amount = int.Parse(Console.ReadLine());
            int price = 0;

            if (age <= 18)
            {
                price = 40;
                Console.WriteLine("youth");
            }
            else
            {
                price = 60;
                Console.WriteLine("adult");
            }

            int totalprice = price * amount;
            Console.WriteLine("your total price is " + totalprice);
        }
        static void task14()
        {
            Console.WriteLine("point fot 1?");
            int point1 = int.Parse(Console.ReadLine());
            Console.WriteLine("point for 2?");
            int point2 = int.Parse(Console.ReadLine()); 

            if (point1 > point2)
            {
                Console.WriteLine(point1);
                Console.WriteLine(point1 - point2);
            }
            else
            {
                Console.WriteLine(point2);
                Console.WriteLine(point2 - point1);
            }
           
        }
        static void task15()
        {
            Console.WriteLine("ehat is the price?");
            double price = double.Parse(Console.ReadLine());

            if (price < 150)
            {
                Console.WriteLine("eclwnt price");
            }
            else if (price >= 150 && price <= 250)
            {
                Console.WriteLine("deecent price");
            }
            else
            {
                Console.WriteLine("bad price");
            }

            Console.WriteLine("thank you for using our program");
        }
        static void task16()
        {
            Console.WriteLine("amount");
            int amount = int.Parse(Console.ReadLine());

            if (amount > 30)
            {
                Console.WriteLine("great");
            }
            else if ( amount <= 30 && amount >= 20)
            {
                Console.WriteLine("big group");
            }
            else if (amount < 20 && amount >= 10)
            {
                Console.WriteLine("noraml");
            }
            else
            {
                Console.WriteLine("meed pepole");
            }
            Console.WriteLine("akauifbiabbiyafbaufbaj");
            
        }
        static void charpractic()
        {
            Console.WriteLine("enter 3 digit");
            char digit1 = char.Parse(Console.ReadLine());
            char digit2 = char.Parse(Console.ReadLine());
            char digit3 = char.Parse(Console.ReadLine());
            Console.WriteLine((digit1 - '0') * 100 + (digit2 - '0') * 10 + (digit3 - '0'));
        }
        static void task17()
        {
            bool stage;
            bool teacher;
            bool light;
            int actor;
            int reharsel;
            double budget;
            string result = "no good";
            Console.WriteLine("is the stage ready?");
            stage = bool.Parse(Console.ReadLine());
            Console.WriteLine("is their theacher?");
            teacher = bool.Parse(Console.ReadLine());
            Console.WriteLine("light?");
            light = bool.Parse(Console.ReadLine());
            Console.WriteLine("actor?");
            actor = int.Parse(Console.ReadLine());
            Console.WriteLine("reharsel?");
            reharsel = int.Parse(Console.ReadLine());
            Console.WriteLine("busget?");
            budget = double.Parse(Console.ReadLine());

            if (light == true && teacher == true && actor % 2 ==1 && reharsel % 45 == 0)
            {
                result = "good";
            }
            Console.WriteLine("the show is" + result);

            
        }
       static void task18()
        {
            Console.WriteLine("enter a num");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 ==0)
            {
                Console.WriteLine("even");
            }
            else if (num % 2 ==1)
            {
                Console.WriteLine("odd");
            }
            else
            {
                Console.WriteLine("zero");
            }
        }
        static void task19()
        {
            Console.WriteLine("amount?");
            double amount = double.Parse(Console.ReadLine());
            double price = 0;

            if (amount <= 300)
            {
                price = 0.5;
            }
            else if (amount > 300 && amount <= 600)
            {
                price = 0.7;    
            }
            else
            {
                price = 1;
            }

            Console.WriteLine("are you a businees?");
            bool buisness = bool.Parse(Console.ReadLine());
            double add1 = 0.15;
            double add2 = 0.05;

            if (buisness == true)
            {
                price = price + price * add1;
            }
            else
            {
                price = price + price * add2;
            }
            Console.WriteLine("your total price is" + (price * amount));
        }
        static void task20()
        {
            Console.WriteLine("what type of ride?");
            string ride = Console.ReadLine();
            Console.WriteLine("ehat are you?");
            string type = Console.ReadLine();
            double price = 0;
            double disscount1 = 0.2;
            double disscount2 = 0.3;


            if (ride == "city")
            {
                price = 6;
            }
            else
            {
                price = 12;
            }
            if (type == "student")
            {
                price = price - price * disscount1;
            }
            else if (type == "pens")
            {
                price = price - price * disscount2;
            }
            Console.WriteLine(price);
        }
        static void task21()
        {
            double price = 0;
            Console.WriteLine("age?");
            int age = int.Parse(Console.ReadLine());

            if (age <= 18)
            {
                price = 120;
                Console.WriteLine("school");
                bool school = bool.Parse(Console.ReadLine());
                if (school == true)
                {
                    double disscount1 = 0.2;
                    price = price - price * disscount1;
                }
            }
            else if (age > 18 && age <= 60)
            {
                price = 180;
                Console.WriteLine("vip?");
                bool vip = bool.Parse(Console.ReadLine());

                if (vip == true)
                {
                    double add2 = 0.3;
                    price = price + price * add2;
                }
            }
            else
            {
                price = 150;
                Console.WriteLine("pens?");
                bool pens = bool.Parse(Console.ReadLine());

                if (pens == true)
                {
                    double disscount2 = 0.15;
                    price = price - price * disscount2;
                }
            }
            Console.WriteLine(price);
        }
        static void task22()
        {
            Console.WriteLine("noraml room?");
            bool type = bool.Parse(Console.ReadLine());
            double price = 0;

            if (type == true)
            {
                price = 400;
            }
            else
            {
                price = 700;
            }
            Console.WriteLine("wekeend?");
            bool wekeend = bool.Parse(Console.ReadLine());
            if (wekeend == true)
            {
                double add = 0.1;
                price = price + price * add;
            }
            Console.WriteLine("member?");
            bool member = bool.Parse(Console.ReadLine());
            if (member == true)
            {
                double disscount = 0.15;
                price = price - price * disscount;
            }
            Console.WriteLine(price);
        }
        static void task23()
        {
        double price = 0;
        Console.WriteLine("age?");
        int age = int.Parse(Console.ReadLine());

            if (age <= 12)
            {
                price = 50;
                Console.WriteLine("is it shabat?");
                bool shabat = bool.Parse(Console.ReadLine());

                if (shabat == true)
                {
                    int add = 10;
                    price = price + price + add;
                }
            }
            else if (age > 12 && age <= 17)
            {
                price = 70;
                Console.WriteLine("memeber?");
                bool member = bool.Parse (Console.ReadLine());
                if (member == true)
                {
                    double disscount = 0.2;
                    price = price - price * disscount;
                }
            }
            else
            {
                price = 100;
                Console.WriteLine("VIP?");
                bool vip = bool.Parse(Console.ReadLine());

                if (vip == true)
                {
                    double add = 0.3;
                    price = price + price * add;
                }
            }
            Console.WriteLine(price);
        }
        static void task24()
        {
            double price = 0;
            Console.WriteLine("age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("sport car?");
            bool cartype = bool.Parse(Console.ReadLine());

            if (age <= 24)
            {
                price = 600;

                if (cartype == true)
                {
                    double add1 = 0.25;
                    price = price + price * add1;
                }  
            }
            else if (age > 24 && age <= 50)
            {
                price = 450;
                Console.WriteLine("did you crashed last year?");
                bool crash = bool.Parse(Console.ReadLine());
                if (crash == true)
                {
                    double add2 = 0.2;
                    price = price + price * add2;
                }
            }
            else
            {
                price = 400;
                if (cartype == false)
                {
                    double disscount = 0.1;
                    price = price - price * disscount;
                }
            }
            Console.WriteLine(price);
        }
        static void task25()
        {
            Console.WriteLine("enter a num");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 ==0)
            {
                if (num % 4 ==0)
                {
                    Console.WriteLine("even devided by 4");
                }
                else
                {
                    Console.WriteLine("even, but not devided by 4");
                }
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        static void task26()
        {
            Console.WriteLine("enter user name");
            string username = Console.ReadLine();
             if (username == "admin")
            {
                Console.WriteLine("enter a pssword:");
                string password = Console.ReadLine();
                if (password == "1234")
                {
                    Console.WriteLine("access acsepted");
                }
                else  
                {
                    Console.WriteLine("wrong password");
                }
            }
             else
            {
                Console.WriteLine("user name does not exticted");
            }
        }
        static void task27()
        {
            Console.WriteLine("what is the temp?");
            double temp = double.Parse(Console.ReadLine());

            if (temp > 0)
            {
                if (temp > 100)
                {
                    Console.WriteLine("hot");
                }
                else
                {
                    Console.WriteLine("noraml");
                }
            }
            else
            {
                Console.WriteLine("ice");
            }
       }
        static void Task28()
        {
            Console.WriteLine("enter a char");
            char x = char.Parse(Console.ReadLine());

            if ( x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u' || x == 'A' || x == 'E' || x == 'I' || x == 'O' || x == 'U')
            {
                if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
                {
                    Console.WriteLine("voeles small");
                }
                else
                {
                    Console.WriteLine("vowles big");
                }
            }
            else
            {
                Console.WriteLine("noraml");
            }
        }
        static void task29()
        {
            Console.WriteLine("enter the time");
            int hour = int.Parse(Console.ReadLine());

            if (hour < 12)
            {
                if (hour < 6)
                {
                    Console.WriteLine("night");
                }
                else
                {
                    Console.WriteLine("morning");
                }
            }
            else if (hour >= 12)
            {
                if (hour < 18)
                {
                    Console.WriteLine("day");
                }
                else
                {
                    Console.WriteLine("evening");
                }
            }
        }









        static void Main(string[] args)
        {
            //task1();
            //task2();
            //task3();
            //task4();
            //task5();
            //task6();
            //task7();
            //task8();
            //task9();
            //task10();
            //task11();
            //task12();
            //task13();
            //task14();
            //task15();
            //task16();
            //charpractic();
            //task17();
            //task18();
            //task19();
            //task20();
            //task21();
            //task22();
            //task23();
            //task24();
            //task25();
            //task26();
            //task27();
            //Task28();
            //task29();
;        }
                
    }
}
