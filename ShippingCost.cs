using System;


namespace ShippingCost
{
    class ShippingCost
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of your package?");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            if (weight <= 50.00m)
            {

                Console.WriteLine("What is the width of the package?");
                decimal width = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What is the height of the package?");
                decimal height = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What is the length of the package?");
                decimal length = Convert.ToDecimal(Console.ReadLine());

                decimal cornerDim = width + height + length;

                decimal shipCost = cornerDim * weight / 100.00m;

                string finalShipCost = $"{shipCost:C}";

                Console.WriteLine("");

                string answer = (cornerDim <= 50) ? finalShipCost : "Package too big to be shipped via Package Express.";

                Console.WriteLine(answer);

                Console.Read();
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Pacakge Express");
                Console.Read();
            }
        }
    }
}
