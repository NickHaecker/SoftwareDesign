using System;

namespace ConsoleProgramm
{
    class Actor
    {
        public string actors_name { get; set; }
        public DateTime birthday { get; set; }
        public string nationality { get; set; }
        public Actor(string Name, DateTime Date, string Nation)
        {
            actors_name = Name;
            birthday = Date;
            nationality = Nation;
        }
    }
}
