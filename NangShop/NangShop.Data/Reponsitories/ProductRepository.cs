﻿using NangShop.Data.Infrastructure;
using NangShop.Model.Models;

namespace NangShop.Data.Reponsitories
{
    public interface IProductRepository : IRepository<Product>
    {
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}