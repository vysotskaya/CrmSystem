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
    public class ClientRepository : IClientRepository
    {
        private readonly DbContext _dbContext;

        public ClientRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Client> GetAll()
        {
            var clients = _dbContext.Set<ClientDbModel>().ToList();
            var mappedClients = clients.Select(t => Mapper.DynamicMap<ClientDbModel, Client>(t));
            return mappedClients;
        }

        public Client GetById(int key)
        {
            var client = _dbContext.Set<ClientDbModel>().FirstOrDefault(t => t.Id == key);
            return Mapper.DynamicMap<ClientDbModel, Client>(client);
        }

        public void Update(Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
