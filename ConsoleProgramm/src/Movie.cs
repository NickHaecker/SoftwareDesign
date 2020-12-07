using System;
using System.Collections.Generic;

namespace ConsoleProgramm
{
    class Movie
    {
        public string movie_name { get; set; }
        public int release_year { get; set; }

        public Int64 box_office { get; set; }
        public string director { get; set; }
        public List<string> actors { get; set; }
        public Movie(string Name, int Date, Int64 Box, string Director, List<string> Actors)
        {
            movie_name = Name;
            release_year = Date;
            box_office = Box;
            director = Director;
            actors = Actors;
        }
    }
}
