using SLN_BUENAS_PRACTICAS.Interfaces;
using SLN_BUENAS_PRACTICAS.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SLN_BUENAS_PRACTICAS.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = new List<User>();

        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

        public User GetUserById(Guid id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void RemoveUser(Guid id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _users.Remove(user);
            }
        }
    }
}
