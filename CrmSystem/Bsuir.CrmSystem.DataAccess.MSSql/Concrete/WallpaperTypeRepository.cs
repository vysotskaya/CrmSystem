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
    public class WallpaperTypeRepository : IWallpaperTypeRepository
    {
        private readonly DbContext _dbContext;

        public WallpaperTypeRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<WallpaperType> GetAll()
        {
            var types = _dbContext.Set<WallpaperTypeDbModel>().ToList();
            var mappedTypes = types.Select(t => Mapper.DynamicMap<WallpaperTypeDbModel, WallpaperType>(t));
            return mappedTypes;
        }

        public WallpaperType GetById(int key)
        {
            var type = _dbContext.Set<WallpaperTypeDbModel>().FirstOrDefault(t => t.Id == key);
            return Mapper.DynamicMap<WallpaperTypeDbModel, WallpaperType>(type);
        }
    }
}
