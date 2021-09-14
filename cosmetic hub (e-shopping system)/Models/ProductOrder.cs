using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cosmetic_hub__e_shopping_system_.Models
{
    public class ProductOrder
    {
        public int ProductOrderId { get; set; }

        public List<ProductOrderDetail> ProductOrderLines { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal ProductOrderTotal { get; set; }

        public DateTime ProductOrderPlaced { get; set; }
    }
}
