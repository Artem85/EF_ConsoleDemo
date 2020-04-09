using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoConsole.Entities
{
    class Movie
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        public int DirectorId { get; set; }
        public Director Director { get; set; }

        public ICollection<ActorMovie> ActorMovies { get; set; }
    }
}
