using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
   
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> studentNote = new Dictionary<string, int>();
            Dictionary<string, int> studentLanguage = new Dictionary<string, int>();

            while (input != "exam finished")
            {

                string[] tokens = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var language = tokens[1];
                
                if (tokens.Length !=2)
                {                    
                    var points = int.Parse(tokens[2]);
                    if (!studentLanguage.ContainsKey(language))
                    {
                        studentLanguage.Add(language, 0);
                    }
                    studentLanguage[language]++;
                    if (!studentNote.ContainsKey(name))
                    {
                        studentNote.Add(name, points );                        
                    }
                    else
                    {
                        if (studentNote[name]<points)
                        {
                            studentNote[name] = points;
                        }
                    }
                }
                else
                {
                    studentNote.Remove(name);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Results:");
            foreach (var item in studentNote.OrderByDescending(x => x.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine(item.Key+" | "+item.Value); 
            }
            Console.WriteLine("Submissions:");
            foreach (var item in studentLanguage.OrderByDescending(x => x.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine(item.Key + ": "+item.Value);       
            }

        }
    }
}


