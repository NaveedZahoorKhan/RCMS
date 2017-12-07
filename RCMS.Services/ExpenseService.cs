using System.Collections.Generic;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.Models;
using RCMS.Services.Interfaces;

namespace RCMS.Services
{
   public class ExpenseService : ServiceBase<Expense>, IExpenseService
    {
        public ExpenseService(IUnitOfWork unitOfWork, IRepository<Expense> repository) : base(unitOfWork, repository)
        {
        }

        public IEnumerable<Expense> GetExpenses()
        {
            return UnitOfWork.ExpenseRepository.GetAll();
        }

        public Expense GetExpensebyId(int id)
        {
            return UnitOfWork.ExpenseRepository.GetById(id);
        }

        public void CreateExpense(Expense expense)
        {
            UnitOfWork.ExpenseRepository.Add(expense);
        }

        public void CreateExpenses(IEnumerable<Expense> expenses)
        {
            UnitOfWork.ExpenseRepository.AddRange(expenses);
        }

        public void UpdateExpense(Expense expense)
        {
            UnitOfWork.ExpenseRepository.Update(expense);
        }

        public IEnumerable<Expense> GetExpensebyUnitId(int id)
        {
            return null;
        }

        public Expense GetExpensebyCode(string code)
        {
            throw new System.NotImplementedException();
        }

        public void SaveExpense()
        {
            throw new System.NotImplementedException();
        }
    }
}
