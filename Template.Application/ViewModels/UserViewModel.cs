using System;
using System.ComponentModel.DataAnnotations;

namespace Template.Application.ViewModels
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
