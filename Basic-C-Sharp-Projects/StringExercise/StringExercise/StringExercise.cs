using System;
using System.Text;

namespace StringExercise
{
    class StringExercise
    {
        static void Main(string[] args)
        {
            string a = "Di";
            string b = "n";
            string c = "go";

            Console.WriteLine(a + b + c);

            string word = a + b + c;

            Console.WriteLine(word.ToUpper());

            StringBuilder paragraph = new StringBuilder();

            paragraph.Append("\tHello. I am going to write a paragraph.\n");
            paragraph.Append("This will not be very long,\n");
            paragraph.Append("but long enough to be considered a paragraph.\n");
            paragraph.Append("I like mangos.\n");
            paragraph.Append("I also like strawberries.\n");
            paragraph.Append("I wish I had strawberries at home,\n");
            paragraph.Append("but I only have hamburger helper.");

            Console.WriteLine(paragraph);

            Console.Read();
        }
    }
}
