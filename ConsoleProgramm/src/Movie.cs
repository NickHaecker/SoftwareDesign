using System;
using System.Collections.Generic;

namespace ConsoleProgramm
{
    class Movie
    {
        public string movie_name { get; set; }
        public DateTime release_year { get; set; }
        public string director { get; set; }
        public List<Actor> actors { get; set; }
        public Movie(string Name, DateTime Date, string Director, List<Actor> Actors)
        {
            movie_name = Name;
            release_year = Date;
            director = Director;
            actors = Actors;
        }
    }
}
