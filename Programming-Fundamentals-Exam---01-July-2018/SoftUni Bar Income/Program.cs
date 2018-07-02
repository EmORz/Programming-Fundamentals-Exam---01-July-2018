using System;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToDo
            Regex reg = new Regex(@"[^|$%.]*?%([A-Z][a-z]+)%[^|$%.]*?<([A-Za-z]+)>[^.|$%]*?\|(\d+)\|[^.|$%]*?(\d+\.?\d*)\$");
            string input = Console.ReadLine();
            var totalIncome = 0.0;

            while (input != "end of shift")
            {

                if (reg.IsMatch(input))
                {
                    Match extrudeData = reg.Match(input);
                    var name = extrudeData.Groups[1].Value;
                    var product = extrudeData.Groups[2].Value;
                    var count = int.Parse(extrudeData.Groups[3].Value);
                    var price = double.Parse(extrudeData.Groups[4].Value);
                    //For each valid line print on the console: "{customerName}: {product} - {totalPrice}"
                    Console.WriteLine($"{name}: {product} - {price*count:f2}");
                    totalIncome += (price*count);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");

        }
    }
}
