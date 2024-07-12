using System;

class Program
{
    // Function to print calendar of a given month and year
    static void PrintCalendar(int year, int month)
    {
        // Array of month names
        string[] monthNames = { "January", "February", "March", "April", "May", "June",
                                "July", "August", "September", "October", "November", "December" };

        // Print the header of the calendar
        Console.WriteLine($"    {monthNames[month - 1]} {year}");
        Console.WriteLine("Su Mo Tu We Th Fr Sa");

        // Get the day of the week for the first day of the month
        DateTime firstDayOfMonth = new DateTime(year, month, 1);
        int startDay = (int)firstDayOfMonth.DayOfWeek;

        // Print leading spaces for the first week
        for (int i = 0; i < startDay; i++)
        {
            Console.Write("   ");
        }

        // Print the days of the month
        int daysInMonth = DateTime.DaysInMonth(year, month);
        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write($"{day,2} ");

            // Move to the next line after Saturday
            if ((day + startDay) % 7 == 0)
            {
                Console.WriteLine();
            }
        }

        // Move to the next line after the last day of the month
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int year = 2024;
        int month = 7;

        PrintCalendar(year, month);
    }
}

