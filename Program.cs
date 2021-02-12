using System;

namespace FashionStore
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalFashion = 0;
            int small = 2000;
            int medium = 4000;
            int large = 6000;

            start:
            Console.WriteLine("SELECT -\n1 - Small\n2 - Medium\n3 - Large\n");
            int UserChoice = int.Parse(Console.ReadLine());

            switch(UserChoice)
            {
                case 1:
                    TotalFashion += small;
                    break;
                case 2:
                    TotalFashion += medium;
                    break;
                case 3:
                    TotalFashion += large;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid", UserChoice);
                    goto start;
            }

        Decide:
            Console.WriteLine("Do You want to buy another Shoe - Yes / No");
            String userDecision = Console.ReadLine();//.ToUpper(); Use this format when using the if block

            switch(userDecision.ToUpper())
            {
                case "YES":
                    goto start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid. Please try again ...");
                    goto Decide;

            }

            //for(int i = 0; i < 1; i++)
            //{ 
            //if(userDecision == "YES")
            //{
            //    goto start;
            //}else if(userDecision == "NO")
            //{
            //        break;
            //}
            //}
            Console.WriteLine("Thank You for shopping with us");
            Console.WriteLine("Bill Amount = {0}", TotalFashion);
        }
    }
}
