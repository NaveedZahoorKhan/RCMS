using System.Collections.Generic;
using RCMS.Models;

namespace RCMS.Services.Interfaces
{
   public interface IExpenseService : IService<Expense>
    {
        IEnumerable<Expense> GetExpenses();
 //       Task<IEnumerable<Expense>> GetExpensesAsync();
        Expense GetExpensebyId(int id);

        void CreateExpense(Expense expense);
        void CreateExpenses(IEnumerable<Expense> expenses);
        void UpdateExpense(Expense expense);
        IEnumerable<Expense> GetExpensebyUnitId(int id);
        Expense GetExpensebyCode(string code);
        void RefreshEntity(Expense expense);
        void SaveExpense();
       
    }
}
