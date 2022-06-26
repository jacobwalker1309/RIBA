using System;
namespace RIBA_V2.Models
{
    public class OrderEncapsulationDto
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int OrderId { get; set; }
        public string OrderDescription { get; set; }
        public string OrderTime { get; set; }
        public int TotalCost { get; set; }

        // thought dto was appropriate given mvc
        // allows protection of data for foreign and primary keys etc
        // should take customer id out, but kept it here for understanding purposes
        // given the ticket
    }
}
