using System.Collections.Generic;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.Models;
using RCMS.Services.Interfaces;

namespace RCMS.Services
{
    public class CategoryService :ServiceBase<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {
        }

        public IEnumerable<Category> GetCategorys()
        {
            return UnitOfWork.CategoryRepository.GetAll();
        }

        public Category GetCategory(int id)
        {
            return UnitOfWork.CategoryRepository.GetById(id);
        }

        public void CreateCategory(Category category)
        {
            UnitOfWork.CategoryRepository.Add(category);
        }

        public void SaveCategory()
        {
            UnitOfWork.Commit();
        }

        public void UpdateCategory(Category category)
        {
            UnitOfWork.CategoryRepository.Update(category);
        }

        public IEnumerable<Category> GetCategorysWithoutUnits()
        {
            throw new System.NotImplementedException();
        }
    }
}
