using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        int Complete();
    }
}
