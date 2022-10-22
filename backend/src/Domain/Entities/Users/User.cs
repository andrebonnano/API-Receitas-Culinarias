
namespace Domain.Entities.Users
{
    public class User
    {
        public User(int accessLevel, string email, string firstName, string lastName, string password)
        {
            UserId = Guid.NewGuid().ToString();
            RegistrationDate = DateTime.Now;
            Active = true;
            AccessLevel = accessLevel;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
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
