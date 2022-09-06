using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class User
    {
        public User(Guid userId, DateTime registrationDate, DateTime lastAccess, bool active, int accessLevel, string email, string firstName, string lastName, DateTime birthDate, string password)
        {
            UserId = userId;
            RegistrationDate = registrationDate;
            LastAccess = lastAccess;
            Active = active;
            AccessLevel = accessLevel;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Password = password;
        }

        public Guid UserId { get; private set; }
        public DateTime RegistrationDate { get; private set; }
        public DateTime LastAccess { get; private set; }
        public bool Active { get; private set; }
        public int AccessLevel { get; private set; }
        public string Email { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Password { get; private set; }
    }
}
