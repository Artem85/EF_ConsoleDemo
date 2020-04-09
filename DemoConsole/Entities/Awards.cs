using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.Entities
{
    class Awards
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
