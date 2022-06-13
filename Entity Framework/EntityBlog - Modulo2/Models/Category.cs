
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityBlog.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]//is not null
        [MaxLength(80)]//Define tamnho maximo
        [Column("Name", TypeName = "NVARCHAR")]
        public string Name { get; set; }
        [Column("Slug", TypeName = "VARCHAR")]

        public string Slug { get; set; }
    }
}