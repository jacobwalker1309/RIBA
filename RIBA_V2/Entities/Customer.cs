using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RIBA_V2.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        // Customer -> one to many for -> Orders -> one to many for OrderDetails
        // went outside the scope fo what was required as logically
        // an order can have many items
        // thought it added to the complexity of the task and made it more real world
    }
}
