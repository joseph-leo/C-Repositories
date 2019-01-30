using System;

namespace EnumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isDay = false;

            while (!isDay)
            {
                try
                {
                    Console.WriteLine("What day of the week is it today?");
                    string dayInput = Console.ReadLine().ToLower();
                    string dayCompare = char.ToUpper(dayInput[0]) + dayInput.Substring(1);

                    DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), dayCompare);
                    
                    Console.WriteLine("It is " + day);

                    isDay = true;
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                    isDay = false;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter a day of the week.\n");
                    isDay = false;
                }
            }
            Console.Read();
        }
        enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
