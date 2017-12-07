using System.Collections.Generic;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.Models;
using RCMS.Services.Interfaces;

namespace RCMS.Services
{
    public class PaymentService : ServiceBase<Payment>, IPaymentService
    {
          public PaymentService(IUnitOfWork unitOfWork, IRepository<Payment> repository) : base(unitOfWork, repository)
        {
        }

        public IEnumerable<Payment> GetPayments()
        {
            return UnitOfWork.PaymentRepository.GetAll();
        }

        public IEnumerable<Payment> GetPaymentsWithoutUnits()
        {
            throw new System.NotImplementedException();
        }

        public Payment GetPayment(int id)
        {
            return UnitOfWork.PaymentRepository.GetById(id);
        }

        public void CreatePayment(Payment Payment)
        {
            UnitOfWork.PaymentRepository.Add(Payment);
        }

        public void UpdatePayment(Payment Payment)
        {
            UnitOfWork.PaymentRepository.Update(Payment);
        }

        public void SavePayment()
        {
            UnitOfWork.Commit();
            
        }
    }
}
