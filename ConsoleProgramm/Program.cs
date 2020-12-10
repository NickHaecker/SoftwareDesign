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
            // Console.WriteLine("Gib was ein");

            switch (Read())
            {
                case "1":
                    Ausgabe();
                    break;
                case "2":
                    Console.WriteLine("Nach welchem Schauspieler suchst du?");
                    string name = Console.ReadLine();
                    Ausgabe(name);
                    break;
                case "3":
                    Console.WriteLine("Nach welchem Film suchst du?");
                    string film = Console.ReadLine();
                    AusgabeMovie(film);
                    break;
                default:
                    Ausgabe();
                    break;
            }
        }
        public static string Read()
        {
            Console.WriteLine("Gib was ein");
            string s = Console.ReadLine();
            return s;
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
        public static void Ausgabe(string name)
        {
            for (var i = 0; i < movies.Count; i++)
            {
                for (var j = 0; j < movies[i].actors.Count; j++)
                {
                    if (movies[i].actors[j] == name)
                    {
                        Console.WriteLine(movies[i].movie_name);
                    }
                }
            }
        }
        public static void AusgabeMovie(string name)
        {
            for (var i = 0; i < movies.Count; i++)
            {
                if (movies[i].movie_name == name)
                {
                    Console.WriteLine("Release: ", movies[i].release_year + "Box Office: ", movies[i].box_office);
                }
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
