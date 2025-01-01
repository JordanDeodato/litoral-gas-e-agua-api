﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LitoralGasEAgua.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("name")]
        public required String Name { get; set; }

        [Column("description")]
        public required String Description { get; set; }

        [Column("brand_id")]
        public required int BrandId { get; set; }

        public Brand Brand { get; set; } = default!;

    }
}