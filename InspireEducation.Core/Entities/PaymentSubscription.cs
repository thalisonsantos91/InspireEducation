using InspireEducation.Core.Entities.Interfaces;
using InspireEducation.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspireEducation.Core.Entities
{
    public class PaymentSubscription : IEntityBase
    {
        public PaymentSubscription(DateTime processingDate, PaymentStatus status, int idUserSubscription, string paymentLink, string idExternalPayment, string message, decimal value, DateTime dueDate)
        {
            Id = Guid.NewGuid();
            ProcessingDate = DateTime.Now;
            Status = PaymentStatus.Pending;
            IdUserSubscription = idUserSubscription;
            Message = message;
            Value = value;
            DueDate = dueDate;
        }

        public Guid Id { get; private set; }
        public DateTime ProcessingDate { get; private set; }
        public PaymentStatus Status { get; private set; }
        public int IdUserSubscription { get; private set; }
        public string PaymentLink { get; private set; }
        public string IdExternalPayment { get; private set; }
        public string Message { get; private set; }
        public decimal Value { get; private set; }
        public DateTime DueDate { get; private set; }
        public UserSubscription UserSubscription { get; private set; }
    }
}
