using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LitoralGasEAgua.Models
{
    [Table("sale")]
    public class Sale
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("date")]
        public required DateTimeOffset Date { get; set; }

        [Column("seller_id")]
        public required int SellerId { get; set; }

        [Column("product_id")]
        public required int ProductId { get; set; }

        public Seller Seller { get; set; } = default!;
        public Product Product { get; set; } = default!;

    }
}
