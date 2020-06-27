using System;
using System.Collections.Generic;
using System.Text;
using Template.Application.ViewModels;

namespace Template.Application.Interfaces
{
    public interface IUserService
    {
        List<UserViewModel> Get();
    }
}
