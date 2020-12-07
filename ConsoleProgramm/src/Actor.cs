using System;

namespace ConsoleProgramm
{
    class Actor
    {
        public string actors_name { get; set; }
        public string birthday { get; set; }
        public string nationality { get; set; }
        public Actor(string Name, string Date, string Nation)
        {
            actors_name = Name;
            birthday = Date;
            nationality = Nation;
        }
    }
}
