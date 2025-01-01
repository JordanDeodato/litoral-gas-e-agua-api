using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LitoralGasEAgua.Models
{
    [Table("brand")]
    public class Brand
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public required String Name { get; set; }

        [Column("description")]
        public required String Description { get; set; }
    }
}
