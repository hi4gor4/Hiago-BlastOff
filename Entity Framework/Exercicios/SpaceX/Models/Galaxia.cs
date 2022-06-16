
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Spacex.Models
{

    [Table("Galaxia")]
    public class Galaxia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string Nome { get; set; }
        [Required]
        public decimal Massa { get; set; }
        [Required]
        public decimal Tamanho { get; set; }
        [Required]
        public string  Tipo { get; set; }


    }
}