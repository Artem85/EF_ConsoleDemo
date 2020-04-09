using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.Entities
{
    class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<Awards> Awards { get; set; }
        public ICollection<ActorMovie> Actors { get; set; }
    }
}
