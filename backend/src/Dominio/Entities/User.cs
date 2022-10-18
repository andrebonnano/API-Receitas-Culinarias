using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        public User(bool active, int accessLevel, string email, string firstName, string lastName, DateTime birthDate, string password)
        {
            Active = active;
            AccessLevel = accessLevel;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Password = password;
        }

        public Guid UserId { get; private set; } = Guid.NewGuid();
        public DateTime RegistrationDate { get; private set; } = DateTime.Now;
        public bool Active { get; private set; }
        public int AccessLevel { get; private set; }
        public string Email { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Password { get; private set; }
    }
}
