using System.Collections.Generic;
using RCMS.Models;

namespace RCMS.Services.Interfaces
{
    public interface IProductUnitService :IService<ProductUnit>
    {
        IEnumerable<ProductUnit> GetProductUnits();
        IEnumerable<ProductUnit> GetProductUnitsWithoutUnits();
        ProductUnit GetProductUnit(int id);
        void CreateProductUnit(ProductUnit productUnit);
        void UpdateProductUnit(ProductUnit productUnit);
        void SaveProductUnit();
        void RefreshEntity(ProductUnit productUnit);
    }
}