using System.ComponentModel.DataAnnotations;

namespace DockerDotnetSqlExample.Models
{
    public class Food
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Restaurant { get; set; }
    }
}