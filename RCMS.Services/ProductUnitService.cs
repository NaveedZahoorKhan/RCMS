using System.Collections.Generic;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.Models;
using RCMS.Services.Interfaces;

namespace RCMS.Services
{
    public class ProductUnitService :ServiceBase<ProductUnit>, IProductUnitService
    {
        public ProductUnitService(IUnitOfWork unitOfWork, IRepository<ProductUnit> repository) : base(unitOfWork, repository)
        {
        }

        public IEnumerable<ProductUnit> GetProductUnits()
        {
            return UnitOfWork.ProductUnitsRepository.GetAll();
        }

        public IEnumerable<ProductUnit> GetProductUnitsWithoutUnits()
        {
            throw new System.NotImplementedException();
        }

        public ProductUnit GetProductUnit(int id)
        {
            return UnitOfWork.ProductUnitsRepository.GetById(id);
        }

        public void CreateProductUnit(ProductUnit productUnit)
        {
            UnitOfWork.ProductUnitsRepository.Add(productUnit);
        }

        public void UpdateProductUnit(ProductUnit productUnit)
        {
            UnitOfWork.ProductUnitsRepository.Update(productUnit);
        }

        public void SaveProductUnit()
        {
            UnitOfWork.Commit();
            
        }
    }
}