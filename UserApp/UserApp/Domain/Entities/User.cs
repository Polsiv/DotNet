﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities
{
    public class User : EntityBase
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }

        [Required]
        public string Username { get; set; }
    }
}
