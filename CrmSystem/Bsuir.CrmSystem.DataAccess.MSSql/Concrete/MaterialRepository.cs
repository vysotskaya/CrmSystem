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
    public class MaterialRepository : IMaterialRepository
    {
        private readonly DbContext _dbContext;

        public MaterialRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Material> GetAll()
        {
            var materials = _dbContext.Set<MaterialDbModel>().ToList();
            var mappedMaterials = materials.Select(t => Mapper.DynamicMap<MaterialDbModel, Material>(t));
            return mappedMaterials;
        }

        public Material GetById(int key)
        {
            var material = _dbContext.Set<MaterialDbModel>().FirstOrDefault(t => t.Id == key);
            return Mapper.DynamicMap<MaterialDbModel, Material>(material);
        }
    }
}
