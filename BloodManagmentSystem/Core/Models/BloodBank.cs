using System.ComponentModel.DataAnnotations;

namespace BloodManagmentSystem.Core.Models
{
    public class BloodBank
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }
    }
}