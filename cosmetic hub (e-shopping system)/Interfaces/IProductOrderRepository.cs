﻿using cosmetic_hub__e_shopping_system_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cosmetic_hub__e_shopping_system_.Interfaces
{
    public interface IProductOrderRepository
    {
        void CreateProductOrder(ProductOrder order);
    }
}
