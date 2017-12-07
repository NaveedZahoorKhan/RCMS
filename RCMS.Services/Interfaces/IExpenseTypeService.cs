using System.Collections.Generic;
using RCMS.Models;

namespace RCMS.Services.Interfaces
{
    public interface IExpenseTypeService : IService<ExpenseType>
    {
        IEnumerable<ExpenseType> GetExpenseTypes();
        IEnumerable<ExpenseType> GetExpenseTypesWithoutUnits();
        ExpenseType GetExpenseType(int id);
        void CreateExpenseType(ExpenseType expenseType);
        void UpdateExpenseType(ExpenseType expenseType);
        void SaveExpenseType();
        void RefreshEntity(ExpenseType expenseType);
    }
}
