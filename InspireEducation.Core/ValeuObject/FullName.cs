using System;

namespace InspireEducation.Core.ValeuObject
{
    public class FullName
    {
        public FullName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new Exception("FirstName is Invalid!");

            if (string.IsNullOrWhiteSpace(lastName))
                throw new Exception("LastName is Invalid!");

            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }

    }
}
