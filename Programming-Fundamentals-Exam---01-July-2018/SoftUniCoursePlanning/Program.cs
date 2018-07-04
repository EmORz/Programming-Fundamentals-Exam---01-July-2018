using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            /*this version take only 66 points! => ToDo must be fix. zero tests are OK!*/
            List<string> sheduleLessons = Console.ReadLine().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> clearSpace = new List<string>();
            foreach (var item in sheduleLessons)
            {
                var temp = item.Trim();
                clearSpace.Add(temp);
            }

            string commands = Console.ReadLine();

            while (commands != "course start")
            {
                List<string> splitCommands = commands.Split(":".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                string command = splitCommands[0];
                if (command == "Add")
                {
                    string lessons = splitCommands[1];
                    if (!clearSpace.Contains(lessons))
                    {
                        clearSpace.Add(lessons);
                    }

                }
                else if (command == "Insert")
                {
                    //Insert:Arrays:0
                    string lessons = splitCommands[1];
                    var index = int.Parse(splitCommands[2]);
                    if (!clearSpace.Contains(lessons) && index >= 0 && index < clearSpace.Count)
                    {
                        clearSpace.Insert(index, lessons);
                    }
                }
                else if (command == "Remove")
                {
                    string lessons = splitCommands[1];
                    if (clearSpace.Contains(lessons))
                    {
                        clearSpace.Remove(lessons);
                    }
                }
                else if (command == "Swap")
                {
                    var first = splitCommands[1];
                    var second = splitCommands[2];

                    if (clearSpace.Contains(first) && clearSpace.Contains(second))
                    {
                        var indexFirst = clearSpace.IndexOf(first);
                        var indexSecond = clearSpace.IndexOf(second);
                        var lenght = clearSpace.Count();
                        clearSpace[indexFirst] = clearSpace[indexSecond];
                        clearSpace[indexSecond] = first;
                    }
                }
                else if (command == "Exercise")
                {
                    string lessons = splitCommands[1];
                    if (!clearSpace.Contains(lessons))
                    {
                        clearSpace.Add(lessons );  
                        clearSpace.Insert(clearSpace.IndexOf(lessons)-1,lessons + "-Exercise");   //+ "-Exercise"
                    }
                    else
                    {
                        clearSpace.Add(lessons + "-Exercise");   
                    }
                }
                commands = Console.ReadLine();
            }
            var count = 1;
            for (int i = 0; i < clearSpace.Count; i++)
            {
                Console.WriteLine($"{count}.{clearSpace[i]}");
                count++;
            }
        }
    }
}
