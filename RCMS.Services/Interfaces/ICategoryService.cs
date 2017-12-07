using System.Collections.Generic;
using RCMS.Models;

namespace RCMS.Services.Interfaces
{
    public interface ICategoryService :IService<Category>
    {
        IEnumerable<Category> GetCategorys();
        Category GetCategory(int id);
        void CreateCategory(Category category);
        void SaveCategory();
        void UpdateCategory(Category category);
        IEnumerable<Category> GetCategorysWithoutUnits();
        void RefreshEntity(Category category);




    }
}
