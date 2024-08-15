using InspireEducation.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace InspireEducation.Core.Entities
{
    public class VideoLesson : IEntityBase
    {
        public VideoLesson(string name, string description, string linkVideo, TimeSpan duration, int moduloId)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            LinkVideo = linkVideo;
            Duration = duration;
            ModuleId = moduloId;
            Active = true;
            CreatedAt = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool Active { get; private set; }
        public string LinkVideo { get; private set; }
        public int ModuleId { get; set; }
        public TimeSpan Duration { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }
        public DateTime? InactivatedAt { get; private set; }
        public List<UserClassCompleted> UserClassCompleted { get; set; }
        public Module Module { get; set; }

        public void Delete()
        {
            Active = false;
            InactivatedAt = DateTime.Now;
        }   

        public void Update(string name, string description, string linkVideo)
        {
            Name = name;
            Description = description;
            LinkVideo = linkVideo;
            UpdatedAt = DateTime.Now;
        }

       
    }


}