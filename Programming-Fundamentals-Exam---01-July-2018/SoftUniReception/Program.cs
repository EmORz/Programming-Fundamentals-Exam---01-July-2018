using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            var limitOfEmployeePerHour1 = int.Parse(Console.ReadLine());
            var limitOfEmployeePerHour2 = int.Parse(Console.ReadLine());
            var limitOfEmployeePerHour3 = int.Parse(Console.ReadLine());
            var totalStudents = long.Parse(Console.ReadLine());
            //
            var totalEmplForHour = limitOfEmployeePerHour1 + limitOfEmployeePerHour2 + limitOfEmployeePerHour3;
            var hours = 0;
            while (totalStudents > 0)
            {
                totalStudents -= totalEmplForHour;
                hours++;
                if (hours % 4 == 0)
                {
                    hours++;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
