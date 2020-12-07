using System;
using System.IO;
// using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsoleProgramm
{
    class Program
    {
        public static List<Actor> actors { get; set; }

        public static List<Movie> movies { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            Init();
            Console.WriteLine("Gib was ein");
            // switch (Console.ReadLine())
            // {
            //     case "1":
            //         Ausgabe();
            //         break;
            // default:
            //     Ausgabe();
            //     break;
            // }
            switch (Console.ReadLine())
            {
                case "a":
                    Ausgabe();
                    break;
                // case "s":
                //     Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                //     break;
                // case "m":
                //     Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                //     break;
                // case "d":
                //     Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                //     break;
                default:
                    Ausgabe();
                    break;
            }
        }
        public static string Read()
        {
            Console.WriteLine("Gib was ein");
            string String = Console.ReadLine();
            Console.WriteLine(String);
            return String;
        }
        public static void Init()
        {
            LoadMovies();
            LoadActors();
        }

        public static void Ausgabe()
        {
            foreach (Movie m in movies)
            {
                Console.WriteLine("release_year: " + m.release_year + ": box_office" + m.box_office);
            }
        }
        public static void LoadMovies()
        {
            using (StreamReader r = new StreamReader("./movies.json"))
            {
                string json = r.ReadToEnd();
                List<Movie> items = JsonConvert.DeserializeObject<List<Movie>>(json);
                movies = items;
            }
        }
        public static void LoadActors()
        {
            using (StreamReader r = new StreamReader("./actors.json"))
            {
                string json = r.ReadToEnd();
                List<Actor> items = JsonConvert.DeserializeObject<List<Actor>>(json);
                actors = items;
            }
        }
    }
}
