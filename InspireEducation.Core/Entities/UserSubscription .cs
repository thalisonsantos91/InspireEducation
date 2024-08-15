using InspireEducation.Core.Entities.Interfaces;
using InspireEducation.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspireEducation.Core.Entities
{
    public class UserSubscription : IEntityBase
    {
        public UserSubscription(int idUser, int idSubscription, Status status)
        {
            Id = Guid.NewGuid();
            IdUser = idUser;
            IdSubscription = idSubscription;
            Status = Status.Active;
            CreatedAt = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public int IdUser { get; private set; }
        public int IdSubscription { get; private set; }
        public Status Status { get; private set; }
        public User User { get; private set; }
        public Subscription Subscription { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? InactivatedAt { get; private set; }
        
        public void Expired(Status status)
        {
            status = Status.Disabled;
            InactivatedAt = DateTime.Now;
        }  
    }

}
