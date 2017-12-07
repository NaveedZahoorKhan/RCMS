using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using RCMS.DAL;
using RCMS.DAL.Classes;
using RCMS.DAL.Interfaces;

namespace RCMS.App.ViewModels
{
    public class BillingViewModel : BindableBase
    {
        private IUnitOfWork _unitOfWork;
        public BillingViewModel()
        {
            _unitOfWork = new UnitOfWork(new RcmsContext());
        }
    }
}
