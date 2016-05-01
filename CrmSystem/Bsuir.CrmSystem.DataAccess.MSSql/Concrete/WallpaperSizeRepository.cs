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
    public class WallpaperSizeRepository : IWallpaperSizeRepository
    {
        private readonly DbContext _dbContext;

        public WallpaperSizeRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<WallpaperSize> GetAll()
        {
            var sizes = _dbContext.Set<WallpaperSizeDbModel>().ToList();
            var mappedSizes = sizes.Select(t => Mapper.DynamicMap<WallpaperSizeDbModel, WallpaperSize>(t));
            return mappedSizes;
        }

        public WallpaperSize GetById(int key)
        {
            var size = _dbContext.Set<WallpaperSizeDbModel>().FirstOrDefault(t => t.Id == key);
            return Mapper.DynamicMap<WallpaperSizeDbModel, WallpaperSize>(size);
        }
    }
}
