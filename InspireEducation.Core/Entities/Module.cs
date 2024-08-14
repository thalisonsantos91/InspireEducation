using InspireEducation.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspireEducation.Core.Entities
{
    public class Module : IEntityBase
    {
        public Module(string name, string description, int courseId)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            CourseId = courseId;
            Active = true;
            CreatedAt = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public int CourseId { get; set; }
        public string Description { get; private set; }
        public bool Active { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }
        public DateTime? InactivatedAt { get; private set; }
        public List<VideoLesson> VideoLessons { get; set; }
        public Course Course { get; set; }



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
