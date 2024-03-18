﻿using System;
using System.Collections.Generic;
using ASPNET.Models;

namespace ASPNET
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProduct(int id);
        void UpdateProduct(Product product);
    }
}
