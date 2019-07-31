using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetAllUsers();     
    }
}
