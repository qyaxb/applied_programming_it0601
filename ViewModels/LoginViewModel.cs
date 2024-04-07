﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Btec_Website.Models;

namespace Btec_Website.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }

       
        
    }
}