using System;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Lab3_2 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> map = new Dictionary<int, string>()
            {
                [0] = "S001",
                [1] = "S002",
                [2] = "S001",
                [3] = "S009",
                [4] = "S005",
                [5] = "S005",
                [6] = "S007"



            };

            Console.WriteLine("Starting Dictionary");
            foreach (var item in map)
            {
                Console.WriteLine($"({item.Key} : {item.Value})");
            }

            List<string> uniqvall = new List<string>();
           
            //removing duplicates
            Console.WriteLine("Unique values: ");
            for (int i = 0; i < map.Count; i++)
            {
                if (!uniqvall.Contains(map[i]))  
                    uniqvall.Add(map[i]); 
            }

            Console.WriteLine(String.Join(",", uniqvall));

            Console.WriteLine(" ");
            Console.WriteLine("Result of serialization:");
            string jsonString = JsonSerializer.Serialize(uniqvall);
            File.WriteAllText("Dictionary.json", jsonString);  //serialization
            Console.WriteLine(jsonString);

        }
    }
}