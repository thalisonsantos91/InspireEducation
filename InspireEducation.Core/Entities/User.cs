using InspireEducation.Core.Entities.Interfaces;
using InspireEducation.Core.Enums;
using InspireEducation.Core.ValeuObject;
using System;

namespace InspireEducation.Core.Entities
{
    public class User : IEntityBase
    {
        public User(FullName fullName, string email, string password, DateTime birthDate, string document, string cellPhone, Role role, DateTime createdAt)
        {
            Id = Guid.NewGuid();
            FullName = fullName;
            Email = email;
            Password = password;
            BirthDate = birthDate;
            Document = document;
            CellPhone = cellPhone;
            Role = role;
            Active = true;
            CreatedAt = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public FullName FullName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Document { get; private set; }
        public string CellPhone { get; private set; }
        public Role Role { get; private set; }
        public bool Active { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }
        public DateTime? InactivatedAt { get; private set; }

        public void Update( string email, string cellPhone)
        {
            Email = email;
            CellPhone = cellPhone;
            UpdatedAt = DateTime.Now;
        }

        public void Delete()
        {
            Active =  false;
            InactivatedAt = DateTime.Now;
        }
    }
}
