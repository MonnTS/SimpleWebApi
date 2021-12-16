using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace LAB_08.Models
{
    public class Pet
    {
        [Required]
        public int Id { get; set; }

        [NotNull]
        public string Name { get; set; }

        [NotNull]
        public int Age { get; set; }

        [NotNull]
        public string Type { get; set; }

        public string Owner { get; set; }
    }
}