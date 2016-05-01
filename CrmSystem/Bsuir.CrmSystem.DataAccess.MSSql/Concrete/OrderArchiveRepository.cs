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
    public class OrderArchiveRepository : IOrderArchiveRepository
    {
        private readonly DbContext _dbContext;

        public OrderArchiveRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<OrderArchive> GetAll()
        {
            var orderArchives = _dbContext.Set<OrderArchiveDbModel>().ToList();
            var mappedArchives = orderArchives.Select(t => Mapper.DynamicMap<OrderArchiveDbModel, OrderArchive>(t));
            return mappedArchives;
        }

        public OrderArchive GetById(int key)
        {
            var archive = _dbContext.Set<OrderArchiveDbModel>().FirstOrDefault(t => t.Id == key);
            return Mapper.DynamicMap<OrderArchiveDbModel, OrderArchive>(archive);
        }

        public int Create(OrderArchive entity)
        {
            var archive = Mapper.DynamicMap<OrderArchive, OrderArchiveDbModel>(entity);
            if (archive != null)
            {
                _dbContext.Set<OrderArchiveDbModel>().Add(archive);
                _dbContext.SaveChanges();
                return archive.Id;
            }
            return 0;
        }

        public void Update(OrderArchive entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(OrderArchive entity)
        {
            var archive = _dbContext.Set<OrderArchiveDbModel>().Single(t => t.Id == entity.Id);
            _dbContext.Set<OrderArchiveDbModel>().Remove(archive);
            _dbContext.SaveChanges();
        }
    }
}
