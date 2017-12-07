using Prism.Mvvm;
using RCMS.DAL;
using RCMS.DAL.Infrastructure;
using RCMS.DAL.Infrastructure.Interfaces;

namespace RCMS.App.ViewModels
{
    public class BillingViewModel : BindableBase
    {
        private IUnitOfWork _unitOfWork;
        public BillingViewModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
           
        }
    }
}
