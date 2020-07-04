using System;
using System.Collections.Generic;
using System.Text;
using Template.Application.Interfaces;
using Template.Application.ViewModels;
using Template.Domain.Entities;
using Template.Domain.Interfaces;

namespace Template.Application.Services
{
    public class UserService: IUserService
    {

        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public List<UserViewModel> Get()
        {
            List<UserViewModel> _userViewModels = new List<UserViewModel>();

            IEnumerable<User> _users = this.userRepository.GetAll();

            foreach (var item in _users)            
                _userViewModels.Add(new UserViewModel { Id = item.Id, Email = item.Email, Name = item.Name });
            
            return _userViewModels;
        }

        public bool Post(UserViewModel userViewModel)
        {
            User _user = new User
            {
                Id = Guid.NewGuid(),
                Email = userViewModel.Email,
                Name = userViewModel.Name
            };

            this.userRepository.Create(_user);

            return true;
        }

    }
}
