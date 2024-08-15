using InspireEducation.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace InspireEducation.Core.Entities
{
    public class Course : IEntityBase
    {
        public Course( int subscriptionId, string name, string description, string cover, DateTime createdAt)
        {
            Id = Guid.NewGuid();
            SubscriptionId = subscriptionId;
            Name = name;
            Description = description;
            Cover = cover;
            Active = true;
            CreatedAt = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public int SubscriptionId { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Cover { get; private set; }
        public bool Active { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }
        public DateTime? InactivatedAt { get; private set; }
        public Subscription Subscription {  get; private set; }
        public List<Module> Module { get; set; }

        public void Update(string name, string description)
        {
            Name = name;
            Description = description;
            UpdatedAt = DateTime.Now;
        }

        public void Delete()
        {
            Active = false;
            InactivatedAt = DateTime.Now;
        }

    }
}
