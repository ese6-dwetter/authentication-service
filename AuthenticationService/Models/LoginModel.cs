﻿using System.ComponentModel.DataAnnotations;

namespace AuthenticationService.Models
{
    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string TokenId { get; set; }
    }
}