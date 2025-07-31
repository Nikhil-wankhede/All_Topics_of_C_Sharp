using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Topics_of_C_Sharp
{
    internal class EnumExample
    {
        
        enum Months
        {
            January = 1,
            Feb,
            Mar,
            Apr,
            May,
            Jun,
            Jul,
            Aug,
            Sep,
            Oct,
            Nov = January,
            Dec
        }
        enum WeekDays
        {
            Sunday,
            Monday,
            Tuesday
        }
        enum Meal
        {
            Breakfast,
            Lunch,
            Dinner
        }
        public void Initialize_Enum_Example()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------------------- Enumerations -------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enumeration User-defined type restricts the user assigning a specified list of constants or values to a variable. It makes constant values more readable. If values are not assigned to enum members, then the compiler will assign integer values to each member starting with zero by default. The first member of an enum will be 0, and the value of each successive enum member is increased by 1.\r\n\r\nSyntax \r\n[access modifier] enum EnumName\r\n{\r\n\tEnum members\r\n}\r\n\r\nExample\r\nPublic enum Year\r\n{\r\n\tJan,\r\nFeb,\r\nMar,\r\nApril\r\n} \r\n");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.White;
            int m = 1;

            if (m == (int)Meal.Breakfast)
            {

            }
            var myMeal = Enum.ToObject(typeof(Meal), m);

            int weekDay = 10;

            switch (weekDay)
            {
                case (int)WeekDays.Sunday:

                    break;
                case (int)WeekDays.Monday:

                    break;
                case (int)WeekDays.Tuesday:

                    break;
            }
        }
    }
}
