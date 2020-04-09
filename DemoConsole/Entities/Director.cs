using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoConsole.Entities
{
    class Director
    {
        public int Id { get; set; }

        [Required]
        [Column("FullName", TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        public Movie Movie { get; set; }
    }
}
