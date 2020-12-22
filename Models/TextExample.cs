using Server.Data;
using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class TextExample : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(600, MinimumLength = 5)]
        public string Text { get; set; }
    }
}
