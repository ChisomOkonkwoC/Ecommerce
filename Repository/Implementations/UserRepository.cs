using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IReadWriteToJson _dbContext;
        private readonly string userFile = "Users.json";

        public UserRepository(IReadWriteToJson dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AddUser(User model)
        {
            try
            {

                return await _dbContext.WriteJson(model, userFile);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<List<User>> GetAllUsers()
        {
            return (List<User>)await _dbContext.ReadJson<User>(userFile);

        }

        public async Task<User> GetUserById(string Id)
        {
            List<User> users = (List<User>)await _dbContext.ReadJson<User>(userFile);
            if (users != null)
            {
                foreach (var user in users)
                {
                    if (user.Id == Id)
                    {
                        return user;
                    }
                }
            }

            return null;
        }


    }
}

