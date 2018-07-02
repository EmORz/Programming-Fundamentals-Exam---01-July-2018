using System;
using System.Collections.Generic;

namespace SoftUniExamResult
{
    class Result
    {
        public Result()
        {
        }
        public Result(string name, string language, int points)
        {
            Name = name;
            Language = language;
            Points = points;
        }

        public string Name { get; set; }
        public string Language { get; set; }
        public int Points { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Result> info = new List<Result>();
            Dictionary<string, List<Result>> dict = new Dictionary<string, List<Result>>();
            while (input != "exam finished")
            {

                string[] tokens = input.Split(new char[] {'-' }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length != 2)
                {
                    var name = tokens[0];
                    var language = tokens[1];
                    var points = int.Parse(tokens[2]);
                    if (!dict.ContainsKey(name))
                    {
                        Result students = new Result();
                       
                        students.Language = language;
                        students.Points = int.Parse(tokens[2]);
                        info.Add(students);
                        dict.Add(name, info);
                    }
                    else
                    {

                        Result st = new Result();
                        st.Language = language;
                        st.Points = points;
                        dict[name].Add(st);
                    }
                }
                else
                {
                    var name = tokens[0];
                    var banned = tokens[1];
                   

                    
                }


                input = Console.ReadLine();
            }
            Console.WriteLine("Results:");
            foreach (var item in dict)
            {

                Console.WriteLine(item.Key);
                foreach (var i in item.Value)
                {
                    Console.WriteLine(i.Language);
                }


            }
            // Console.WriteLine(string.Join("\n", tokens));
        }
    }
}

