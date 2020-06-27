using System;
using System.Collections.Generic;
using System.Text;
using Template.Domain.Entities;

namespace Template.Domain.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
    }
}
