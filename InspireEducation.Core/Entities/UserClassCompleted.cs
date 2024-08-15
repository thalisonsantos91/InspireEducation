using InspireEducation.Core.Entities.Interfaces;
using System;

namespace InspireEducation.Core.Entities
{
    public class UserClassCompleted : IEntityBase
    {
        public UserClassCompleted(int idUser, int idLessonVideo, DateTime endDate, int note)
        {
            Id = Guid.NewGuid();
            IdUser = idUser;
            IdLessonVideo = idLessonVideo;
            EndDate = DateTime.Now; 
            Note = note;
        }

        public Guid Id { get; private set; }
        public int IdUser { get; private set; }
        public int IdLessonVideo { get; private set; }
        public DateTime EndDate { get; private set; }
        public int Note { get; private set; }
        public User User { get; set; }
        public VideoLesson VideoLesson { get; set; }
    }
}