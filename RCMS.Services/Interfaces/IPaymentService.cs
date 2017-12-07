using System.Collections.Generic;
using RCMS.Models;

namespace RCMS.Services.Interfaces
{
    public interface IPaymentService : IService<Payment>
    {
        IEnumerable<Payment> GetPayments();
        IEnumerable<Payment> GetPaymentsWithoutUnits();
        Payment GetPayment(int id);
        void CreatePayment(Payment payment);
        void UpdatePayment(Payment payment);
        void SavePayment();
        void RefreshEntity(Payment payment);
    }
}
