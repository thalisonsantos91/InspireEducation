using InspireEducation.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace InspireEducation.Core.Entities
{
    public class Subscription : IEntityBase
    {
        public Subscription(string name, TimeSpan duration)
        {
            Id = Guid.NewGuid();
            Name = name;
            Duration = duration;
            Active = true;
            CreatedAt = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public TimeSpan Duration { get; private set; }
        public bool Active { get; private set; }
        public DateTime CreatedAt { get; private set; }       
        public DateTime? UpdatedAt { get; private set; }
        public DateTime? InactivatedAt { get; private set; }
        public List<Course> Courses { get; private set;}


        public void Update(string name, TimeSpan duration)
        {
            Name = name;
            Duration = duration;
            UpdatedAt = DateTime.Now;
        }
        public void Delete()
        {
            Active = false;
            InactivatedAt = DateTime.Now;
        }
    }
}