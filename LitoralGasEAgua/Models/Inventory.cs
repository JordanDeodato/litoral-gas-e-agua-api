using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LitoralGasEAgua.Models
{
    [Table("inventory")]
    public class Inventory
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("product_id")]
        public required int ProductId { get; set; }

        [Column("amount")]
        public required int Amount { get; set; }
    }
}
