using System;
// using System.Web.Script.Serialization;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsoleProgramm
{
    class Program
    {
        public List<Actor> actors { get; set; }

        public List<Movie> movies { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // LoadJson();
            LoadMovies();
        }

        public static void LoadMovies()
        {
            // string dir = System.IO.Path.GetDirectoryName(
            //             System.Reflection.Assembly.GetExecutingAssembly().Location);
            using (StreamReader r = new StreamReader("movies.json"))
            {
                // string json = r.ReadToEnd();
                // List<Movie> items = JsonConvert.DeserializeObject<List<Movie>>(json);
                Console.WriteLine(r);
            }
        }

        // public static void LoadJson()
        // {
        //     // // List<Movie> items;
        //     // using (StreamReader r = new StreamReader("/src/movies.json"))
        //     // {
        //     //     string json = r.ReadToEnd();
        //     //   List<Movie> items = JsonConvert.DeserializeObject<List<Movie>>(json);
        //     // }
        //     // // return items;
        // }
    }
}
