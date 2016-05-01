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
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly DbContext _dbContext;

        public ExpenseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Expense> GetAll()
        {
            var expenses = _dbContext.Set<ExpenseDbModel>().ToList();
            var mappedExpenses = expenses.Select(t => Mapper.DynamicMap<ExpenseDbModel, Expense>(t));
            return mappedExpenses;
        }

        public Expense GetById(int key)
        {
            var expense = _dbContext.Set<ExpenseDbModel>().FirstOrDefault(t => t.Id == key);
            return Mapper.DynamicMap<ExpenseDbModel, Expense>(expense);
        }

        public int Create(Expense entity)
        {
            var expense = Mapper.DynamicMap<Expense, ExpenseDbModel>(entity);
            if (expense != null)
            {
                _dbContext.Set<ExpenseDbModel>().Add(expense);
                _dbContext.SaveChanges();
                return expense.Id;
            }
            return 0;
        }

        public void Update(Expense entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expense entity)
        {
            var expense = _dbContext.Set<ExpenseDbModel>().Single(t => t.Id == entity.Id);
            _dbContext.Set<ExpenseDbModel>().Remove(expense);
            _dbContext.SaveChanges();
        }
    }
}
