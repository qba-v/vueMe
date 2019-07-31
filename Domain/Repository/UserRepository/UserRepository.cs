using Domain.DAL;
using Domain.DTO;
using System;
using System.Collections.Generic;

namespace Domain.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private AppDbContext AppContext;
        public UserRepository(AppDbContext context) : base(context)
        {
        }


        public IEnumerable<User> GetAllUsers()
        {
            return AppContext.Users;
        }
    }
}
