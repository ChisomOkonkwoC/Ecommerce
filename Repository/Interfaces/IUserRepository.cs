using ECommerce.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUserRepository
    {
        Task<bool> AddUser(User model);
        Task<List<User>> GetAllUsers();
        Task<User> GetUserById(string Id);
    }
}