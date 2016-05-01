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
    public class SupplierRepository : ISupplierRepository
    {
        private readonly DbContext _dbContext;

        public SupplierRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Supplier> GetAll()
        {
            var supplier = _dbContext.Set<SupplierDbModel>().ToList();
            var mappedSuppliers = supplier.Select(t => Mapper.DynamicMap<SupplierDbModel, Supplier>(t));
            return mappedSuppliers;
        }

        public Supplier GetById(int key)
        {
            var supplier = _dbContext.Set<SupplierDbModel>().FirstOrDefault(t => t.Id == key);
            return Mapper.DynamicMap<SupplierDbModel, Supplier>(supplier);
        }
    }
}
