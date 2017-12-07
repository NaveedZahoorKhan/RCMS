using System;
using System.Collections.Generic;
using System.ComponentModel;
using RCMS.Models;

namespace RCMS.Services.Interfaces
{
    public interface IItemService : IService<Item>
    {

        IEnumerable<Item> GetItems();
        IEnumerable<Item> GetItemsWithoutUnits();
        Item GetItem(int id);
        void CreateItem(Item Item);
        void UpdateItem(Item Item);
        void SaveItem();
        void RefreshEntity(Item Item);

    }
}
