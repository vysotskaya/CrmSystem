using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using Bsuir.CrmSystem.DataAccess.Entities;
using Bsuir.CrmSystem.DataAccess.Interfaces.Repositories;
using Bsuir.CrmSystem.DataAccess.MSSqlDbModel;

namespace Bsuir.CrmSystem.DataAccess.MSSql.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbContext _dbContext;

        public ProductRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Product> GetAll()
        {
            var products = _dbContext.Set<ProductDbModel>().ToList();
            var mappedProducts = products.Select(t => Mapper.DynamicMap<ProductDbModel, Product>(t));
            return mappedProducts;
        }

        public Product GetById(int key)
        {
            var product = _dbContext.Set<ProductDbModel>().FirstOrDefault(t => t.Id == key);
            return Mapper.DynamicMap<ProductDbModel, Product>(product);
        }

        public int Create(Product entity)
        {
            var product = Mapper.DynamicMap<Product, ProductDbModel>(entity);
            if (product != null)
            {
                _dbContext.Set<ProductDbModel>().Add(product);
                _dbContext.SaveChanges();
                return product.Id;
            }
            return 0;
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            var product = _dbContext.Set<ProductDbModel>().Single(t => t.Id == entity.Id);
            _dbContext.Set<ProductDbModel>().Remove(product);
            _dbContext.SaveChanges();
        }
    }
}
