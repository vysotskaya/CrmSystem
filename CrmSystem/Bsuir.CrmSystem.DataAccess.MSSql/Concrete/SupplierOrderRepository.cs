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
    public class SupplierOrderRepository : ISupplierOrderRepository
    {
        private readonly DbContext _dbContext;

        public SupplierOrderRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<SupplierOrder> GetAll()
        {
            var orders = _dbContext.Set<SupplierOrderDbModel>().ToList();
            var mappedOrders = orders.Select(t => Mapper.DynamicMap<SupplierOrderDbModel, SupplierOrder>(t));
            return mappedOrders;
        }

        public SupplierOrder GetById(int key)
        {
            var order = _dbContext.Set<SupplierOrderDbModel>().FirstOrDefault(t => t.Id == key);
            return Mapper.DynamicMap<SupplierOrderDbModel, SupplierOrder>(order);
        }

        public int Create(SupplierOrder entity)
        {
            SupplierOrderDbModel order = Mapper.DynamicMap<SupplierOrder, SupplierOrderDbModel>(entity);
            if (order != null)
            {
                _dbContext.Set<SupplierOrderDbModel>().Add(order);
                _dbContext.SaveChanges();
                return order.Id;
            }
            return 0;
        }

        public void Update(SupplierOrder entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SupplierOrder entity)
        {
            var order = _dbContext.Set<SupplierOrderDbModel>().Single(t => t.Id == entity.Id);
            _dbContext.Set<SupplierOrderDbModel>().Remove(order);
            _dbContext.SaveChanges();
        }
    }
}
