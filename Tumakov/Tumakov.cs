using System;

class Tumakov
{
    static void Main()
    {
        // Упражнение 4.1
        Console.WriteLine("       Упражнение 4.1");
        Console.WriteLine("Введите число:");
        string numberr = Console.ReadLine();
        int[] inMonthss = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (int.TryParse(numberr, out int dayOfYearr))
        {
            int monthh = 0;
            while (dayOfYearr > inMonthss[monthh])
            {
                dayOfYearr -= inMonthss[monthh];
                monthh++;
            }
            DateTime dayy = new DateTime(2026, monthh+1, dayOfYearr);
            Console.WriteLine(dayy);
        }

        //Упражнение 4.2
        Console.WriteLine("");
        Console.WriteLine("       Упражнение 4.2");
        Console.WriteLine("Введите число:");
        string number = Console.ReadLine();
        int[] inMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (int.TryParse(number, out int dayOfYear)) //преобразование строки в целое число
        {
            if (dayOfYear > 0 && dayOfYear < 366)
            {
                int month = 0;
                while (dayOfYear > inMonths[month])
                {
                    dayOfYear -= inMonths[month];
                    month++;
                }
                DateTime day = new DateTime(2025, month+1, dayOfYear);
                Console.WriteLine(day);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }

        // домашнее здание 4.1
        Console.WriteLine("");
        Console.WriteLine("       Домашнее здание 4.1");
        Console.WriteLine("Введите число:");
        string numberrr = Console.ReadLine();
        Console.WriteLine("Введите год:");
        string year = Console.ReadLine();
          
        if ((int.TryParse(numberrr, out int dayOfYearrr)) && (int.TryParse(year, out int yearrr)))//преобразование строки в целое число
        {
            if (dayOfYearrr > 0 && dayOfYearrr < 367 && (yearrr % 4 == 0 || yearrr % 400 == 0) && yearrr % 100 != 0)
            {
                int[] inMonthsss = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                int monthhh = 0;
                while (dayOfYearrr > inMonthsss[monthhh])
                {
                    dayOfYearrr -= inMonthsss[monthhh];
                    monthhh++;
                }
                DateTime dayyy = new DateTime(yearrr, monthhh + 1, dayOfYearrr);
                Console.WriteLine(dayyy);
            }
            else if (dayOfYearrr > 0 && dayOfYearrr < 367)
            {
                int[] inMonthsss = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                int monthhh = 0;
                while (dayOfYearrr > inMonthsss[monthhh])
                {
                    dayOfYearrr -= inMonthsss[monthhh];
                    monthhh++;
                }
                DateTime dayyy = new DateTime(yearrr, monthhh + 1, dayOfYearrr);
                Console.WriteLine(dayyy);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }

        }
    }
}


    


    
