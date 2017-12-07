using System.Collections.Generic;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.Models;
using RCMS.Services.Interfaces;

namespace RCMS.Services
{
    public class ItemService : ServiceBase<Item>, IItemService
    {
        public ItemService(IUnitOfWork unitOfWork, IRepository<Item> repository) : base(unitOfWork, repository)
        {
        }

        public IEnumerable<Item> GetItems()
        {
            return UnitOfWork.ItemRepository.GetAll();
        }

        public IEnumerable<Item> GetItemsWithoutUnits()
        {
            throw new System.NotImplementedException();
        }

        public Item GetItem(int id)
        {
            return UnitOfWork.ItemRepository.GetById(id);
        }

        public void CreateItem(Item Item)
        {
            UnitOfWork.ItemRepository.Add(Item);
        }

        public void UpdateItem(Item Item)
        {
            UnitOfWork.ItemRepository.Update(Item);
        }

        public void SaveItem()
        {
            UnitOfWork.Commit();
        }
    }
}
