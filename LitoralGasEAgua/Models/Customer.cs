using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LitoralGasEAgua.Models
{
    [Table("customer")]
    public class Customer
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public required string Name { get; set; }

        [Column("age")]
        public required int Age { get; set; }

        [Column("cpf")]
        public required string Cpf { get; set; }

        [Column("email")]
        public required string Email { get; set; }

        [Column("phone_number")]
        public required string PhoneNumber { get; set; }

        [Column("status")]
        public required string Status { get; set; }

        [Column("address_id")]
        public required int AddressId { get; set; }
    }
}
