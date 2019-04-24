using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlanetSync_Server.Data.Models
{
    public class ModFile
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ulong Id { get; set; }

        [Required]
        public Mod Owner { get; set; }

        [Required]
        public string Path { get; set; }
    }
}
