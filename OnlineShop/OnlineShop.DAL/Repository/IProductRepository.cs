﻿using OnlineShop.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.DAL.Repository
{
   public interface IProductRepository
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int ProductId);
        Product GetProductById(int ProductId);
        IEnumerable<Product> GetProducts();
    }
}