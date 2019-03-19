using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Number
            //do
            //    {
            //        Console.WriteLine("Pleae enter a number:");

            //        string answer = Console.ReadLine();

            //        string answer1 = "";
            //        double number;
            //        bool success = double.TryParse(answer, out number);

            //        if (success)
            //        {
            //            Console.WriteLine(PrintingStats(number));
            //        }
            //        else
            //        {
            //            Console.WriteLine("Your entered an invalid input. \n If you want to try again press Y, if you don't want press N");
            //            answer1 = Console.ReadLine();
            //        }
            //        if (answer1.ToLower() == "y")
            //        {
            //            continue;
            //        }
            //        else if (answer1.ToLower() == "n")
            //        {
            //            break;
            //        }
            //    } while (true);
            //}

            //public static string IsItPosOrNeg(double num)
            //{
            //    if (num < 0)
            //    {
            //        return "Your number is negative";
            //    }
            //    else
            //    {
            //        return "Your number is positive";
            //    }
            //}
            //public static string IsItEvenOrOdd(double num)
            //{
            //    if (num % 2 == 0)
            //    {
            //        return "Your number is even";
            //    }
            //    else
            //    {
            //        return "Your number is odd";
            //    }
            //}
            //public static string IsItIntOrDouble(double num)
            //{
            //    double number = Math.Floor(num);
            //    if (num > number)
            //    {
            //        return "Your number is decimal";
            //    }
            //    else
            //    {
            //        return "Your number is integer";
            //    }
            //}
            //public static string PrintingStats(double num)
            //{
            //    return $"Stats for number: {num}\n{IsItPosOrNeg(num)}\n{IsItEvenOrOdd(num)}\n{IsItIntOrDouble(num)}";

            #endregion
            #region LogIn
            Console.WriteLine("Please enter your username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your password: ");
            string password = Console.ReadLine();

            User[] usersArray = new User[5];

            usersArray[0] = new User(1, "Florent", "heyy");
            usersArray[1] = new User(2, "Vlatko", "you");
            usersArray[2] = new User(3, "Gurgica", "me");
            usersArray[3] = new User(4, "Bobi", "ne");
            usersArray[4] = new User(5, "Zlatko", "da");

            for (int i = 0; i < usersArray.Length; i++)
            {
                if (username == usersArray[i].Username && password == usersArray[i].Password)
                 {
                    Console.WriteLine(usersArray[i].Messages[0]);
                    break;
                }
                else if (username != usersArray[i].Username || password != usersArray[i].Password)
                { Console.WriteLine(usersArray[i].Messages[1]);
                    break;
                }
                else if (username == "" || password == "")
                {
                    Console.WriteLine(usersArray[i].Messages[2]);
                }
            }
            Console.ReadLine();

            #endregion
        }
    }
    }
