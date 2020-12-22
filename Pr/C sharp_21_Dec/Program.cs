using C_sharp_21_Dec;
using System;
using System.Collections;
using System.Collections.Generic;



namespace Methods   
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("What is your name?");
            Person p1 = new Person
            {
                Name = Console.ReadLine(),
            };
            months custom_m =  months.January;


            Console.WriteLine("Give the number of your faourite month:");
            int  month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 1:
                     custom_m = months.January;
                        break;
                case 2:
                    custom_m = months.February;
                    break;
                case 3:
                    custom_m = months.March;
                    break;
                case 4:
                    custom_m = months.April;
                    break;
                case 5:
                    custom_m = months.May;
                    break;
                case 6:
                    custom_m = months.June;
                    break;
                case 7:
                    custom_m = months.July;
                    break;
                case 8:
                    custom_m = months.August;
                    break;
                case 9:
                    custom_m = months.September;
                    break;
                case 10:
                    custom_m = months.October;
                    break;
                case 11:
                    custom_m = months.November;
                    break;
                case 12:
                    custom_m = months.December;
                    break;

            }

            p1.month_2 = custom_m;
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.month_2);


        }
               
    }
}
