using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cosmetic_hub__e_shopping_system_.Models
{
    public class ProductOrderDetail
    {
        public int ProductOrderDetailId { get; set; }

        public int ProductOrderId { get; set; }
        
        public int ProductId { get; set; }

        public int Amount { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ProductPrice { get; set; }

        public virtual Product Product { get; set; }

        public virtual ProductOrder ProductOrder { get; set; }


    }
}
