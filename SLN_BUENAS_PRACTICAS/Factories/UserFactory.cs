using SLN_BUENAS_PRACTICAS.Models;

namespace SLN_BUENAS_PRACTICAS.Factories
{
    public static class UserFactory
    {
        public static User CreateUser(string name, string email)
        {
            return new User
            {
                Id = Guid.NewGuid(),
                Name = name,
                Email = email
            };
        }
    }
}
