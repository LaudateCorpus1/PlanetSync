using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlanetSync_Server.Data.Models
{
    public class Mod
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ulong Id { get; set; }

        [Required]
        public string ModId { get; set; }

        [Required]
        public User Owner { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string ModDescription { get; set; }

        public bool IsApproved { get; set; }

        [Required]
        public IEnumerable<ModFile> FileList { get; set; }
    }
}
