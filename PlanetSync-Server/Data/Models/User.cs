using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanetSync_Server.Data.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ulong Id { get; set; }

        public string Username { get; set; }

        public string PasswordHash { get; set; }

        public bool IsAdmin { get; set; }
        public bool CanAddMods { get; set; }
    }
}