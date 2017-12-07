using System.Collections.Generic;
using RCMS.Models;

namespace RCMS.Services.Interfaces
{
    public interface IReceiveablesService: IService<Receiveables>
    {
        IEnumerable<Receiveables> GetReceiveabless();
        Receiveables GetReceiveables(int id);
        void CreateReceiveables(Receiveables receiveables);
        void UpdateReceiveables(Receiveables receiveables);
        void SaveReceiveables();
        void RefreshEntity(Receiveables receiveables);
        

    }
}
