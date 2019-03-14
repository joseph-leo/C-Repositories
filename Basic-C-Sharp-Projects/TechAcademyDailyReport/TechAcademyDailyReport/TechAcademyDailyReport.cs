using System;

namespace ConsoleApp3
{
    class TechAcademyDailyReport
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("");
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumInput = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumInput);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string helpNeededInput = Console.ReadLine();
            bool helpNeeded = Convert.ToBoolean(helpNeededInput);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string info = Console.ReadLine();
            Console.WriteLine("Is there any other feeback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study?");
            string hoursInput = Console.ReadLine();
            int hours = Convert.ToInt32(hoursInput);
            Console.WriteLine("");
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}

