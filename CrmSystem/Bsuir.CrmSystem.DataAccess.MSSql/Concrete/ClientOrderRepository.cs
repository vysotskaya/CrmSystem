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
    public class ClientOrderRepository : IClientOrderRepository
    {
        private readonly DbContext _dbContext;

        public ClientOrderRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ClientOrder> GetAll()
        {
            var orders = _dbContext.Set<ClientOrderDbModel>().ToList();
            var mappedOrders = orders.Select(t => Mapper.DynamicMap<ClientOrderDbModel, ClientOrder>(t));
            return mappedOrders;
        }

        public ClientOrder GetById(int key)
        {
            var order = _dbContext.Set<ClientOrderDbModel>().FirstOrDefault(t => t.Id == key);
            return Mapper.DynamicMap<ClientOrderDbModel, ClientOrder>(order);
        }

        public int Create(ClientOrder entity)
        {
            ClientOrderDbModel order = Mapper.DynamicMap<ClientOrder, ClientOrderDbModel>(entity);
            if (order != null)
            {
                _dbContext.Set<ClientOrderDbModel>().Add(order);
                _dbContext.SaveChanges();
                return order.Id;
            }
            return 0;
        }

        public void Update(ClientOrder entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ClientOrder entity)
        {
            var order = _dbContext.Set<ClientOrderDbModel>().Single(t => t.Id == entity.Id);
            _dbContext.Set<ClientOrderDbModel>().Remove(order);
            _dbContext.SaveChanges();
        }
    }
}
