using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Users
{
    public class User
    {
        public User(int accessLevel, string email)
        {
            UserId = Guid.NewGuid().ToString();
            RegistrationDate = DateTime.Now;
            Active = true;
            AccessLevel = accessLevel;
            Email = email;
        }

        public string UserId { get; private set; }
        public DateTime RegistrationDate { get; private set; }
        public bool Active { get; private set; }
        public int AccessLevel { get; private set; }
        public string Email { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Password { get; private set; }
    }
}
