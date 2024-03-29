﻿using System.ComponentModel.DataAnnotations;

namespace DecaBlogMVC.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        // [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }

        public IEnumerable<string> Errors { get; set; } = Array.Empty<string>();
    }
}