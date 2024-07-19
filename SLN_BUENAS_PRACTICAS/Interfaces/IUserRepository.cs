using SLN_BUENAS_PRACTICAS.Models;
using System.Collections.Generic;

namespace SLN_BUENAS_PRACTICAS.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(Guid id);
        void AddUser(User user);
        void RemoveUser(Guid id);
    }
}
