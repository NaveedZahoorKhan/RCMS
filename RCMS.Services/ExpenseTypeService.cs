using System.Collections.Generic;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.Models;
using RCMS.Services.Interfaces;

namespace RCMS.Services
{
    public class ExpenseTypeService : ServiceBase<ExpenseType>, IExpenseTypeService
    {
        public ExpenseTypeService(IUnitOfWork unitOfWork, IRepository<ExpenseType> repository) : base(unitOfWork, repository)
        {
        }

        public IEnumerable<ExpenseType> GetExpenseTypes()
        {
            return UnitOfWork.ExpenseTypeRepository.GetAll();
        }

        public IEnumerable<ExpenseType> GetExpenseTypesWithoutUnits()
        {
            throw new System.NotImplementedException();
        }

        public ExpenseType GetExpenseType(int id)
        {
            return UnitOfWork.ExpenseTypeRepository.GetById(id);
        }

        public void CreateExpenseType(ExpenseType expenseType)
        {
            UnitOfWork.ExpenseTypeRepository.Add(expenseType);
        }

        public void UpdateExpenseType(ExpenseType expenseType)
        {
            UnitOfWork.ExpenseTypeRepository.Update(expenseType);
        }

        public void SaveExpenseType()
        {
           UnitOfWork.Commit();
        }
    }
}
