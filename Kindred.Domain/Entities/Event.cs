using Kindred.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Kindred.Domain.Entities
{
    public class Event
    {
        public int Id { get; set; }

        [EnumDataType(typeof(Category), ErrorMessage = "Будь ласка, вкажіть категорію")]
        public Category Category { get; set; }

        [Required(ErrorMessage = "Будь ласка, вкажіть заголовок")]
        [StringLength(100)]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Будь ласка, вкажіть місце")]
        [StringLength(100)]
        public string? Venue { get; set; }
        public DateTime? PublicationDate { get; set; }

        [StringLength(100)]
        public string? Description { get; set; }
    }
}
