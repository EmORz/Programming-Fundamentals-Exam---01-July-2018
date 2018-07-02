using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //ToDo
            Regex reg = new Regex(@"[^|$%.]*?%([A-Z][a-z]+)%[^|$%.]*?<([A-Za-z]+)>[^.|$%]*?\|(\d+)\|[^.|$%]*?(\d+\.?\d*)\$");
            string input = Console.ReadLine();

            while (input != "end of shift")
            {
                
                if (reg.Match(input))
                {
                    Match extrudeData = reg.Match(input);
                    var name = extrudeData.Groups[1].Value;
                    var product = "";
                    var count = int.Parse();
                    var price = double.Parse();
                    Console.WriteLine(name);
                }

                input = Console.ReadLine();
            }
        }
    }
}
