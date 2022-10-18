namespace TesteUnitario
{
    public class UserTest
    {
        public static ExpectectedUser expectedUser { get; set; } = new ExpectectedUser();

        public class ExpectectedUser
        {
            public bool Active { get; set; } = true;
            public int AccessLevel { get; set; } = 1;
            public string Email { get; set; } = "andre@bonnano.com.br";
            public string FirstName { get; set; } = "André";
            public string LastName { get; set; } = "Bonnano";
            public DateTime BirthDate { get; set; } = DateTime.Today;
            public string Password { get; set; } = "12345678@Andre";
        }

        public User user { get; set; } = new User(
                expectedUser.Active,
                expectedUser.AccessLevel,
                expectedUser.Email,
                expectedUser.FirstName,
                expectedUser.LastName,
                expectedUser.BirthDate,
                expectedUser.Password
            );

        [Fact]
        public void DeveCriarUsuario()
        {
            expectedUser.ToExpectedObject().ShouldMatch(user);
        }

        [Fact]
        public void NenhumCampoNulo()
        {
            //expectedUser.FirstName = null;

            Assert.NotNull(user.UserId);
            Assert.NotNull(user.RegistrationDate);
            Assert.NotNull(user.Active);
            Assert.NotNull(user.AccessLevel);
            Assert.NotNull(user.Email);
            Assert.NotNull(user.FirstName);
            Assert.NotNull(user.LastName);
            Assert.NotNull(user.BirthDate);
            Assert.NotNull(user.Password);
            Assert.NotNull(user.Password);
        }

        [Fact]
        public void NenhumCampoVazio()
        {
            Assert.NotEmpty(user.UserId.ToString());
            Assert.NotEmpty(user.RegistrationDate.ToString());
            Assert.NotEmpty(user.Active.ToString());
            Assert.NotEmpty(user.AccessLevel.ToString());
            Assert.NotEmpty(user.Email.ToString());
            Assert.NotEmpty(user.FirstName.ToString());
            Assert.NotEmpty(user.LastName.ToString());
            Assert.NotEmpty(user.BirthDate.ToString());
            Assert.NotEmpty(user.Password.ToString());
            Assert.NotEmpty(user.Password.ToString());
        }
    }
}