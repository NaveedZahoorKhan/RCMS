using System.Collections.Generic;
using System.Threading.Tasks;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.DAL.Repositories.Interfaces;
using RCMS.Models;
using RCMS.Services.Interfaces;

namespace RCMS.Services
{
    public class ReceiveablesService: ServiceBase<Receiveables>, IReceiveablesService
    {
        public ReceiveablesService(IUnitOfWork unitOfWork, IRepository<Receiveables> repository) : base(unitOfWork, repository)
        {
        }

        public IEnumerable<Receiveables> GetReceiveabless()
        {
            return UnitOfWork.ReceiveablesRepository.GetAll();
        }

        public IEnumerable<Receiveables> GetReceiveablessWithoutUnits()
        {
            throw new System.NotImplementedException();
        }

        public Receiveables GetReceiveables(int id)
        {
            return UnitOfWork.ReceiveablesRepository.GetById(id);
        }

        public void CreateReceiveables(Receiveables Receiveables)
        {
            UnitOfWork.ReceiveablesRepository.Add(Receiveables);
        }

        public void UpdateReceiveables(Receiveables Receiveables)
        {
            UnitOfWork.ReceiveablesRepository.Update(Receiveables);
        }

        public void SaveReceiveables()
        {
            UnitOfWork.Commit();

        }

    }
}
