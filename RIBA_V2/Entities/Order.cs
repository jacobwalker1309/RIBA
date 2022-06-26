using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RIBA_V2.Entities
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string OrderDescription { get; set; }
        [Required]
        public int TotalCost { get; set; }
        public DateTime DateTime { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        // note that for TotalCost would use decimals or money
        // however due to time constaints used sqlite, which is
        // tempermental about decimal types, will fix for future improvements
    }
}
