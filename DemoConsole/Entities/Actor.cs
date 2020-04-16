using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoConsole.Entities
{
    class Actor
    {
        public int Id { get; set; }

        [Column("FullName", TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "tinyint")]
        public int Age { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        [NotMapped]
        public bool AcademyWinner => Awards?.Count > 0;

        public ICollection<Award> Awards { get; set; }
        public ICollection<ActorMovie> ActorMovies { get; set; }
    }
}
