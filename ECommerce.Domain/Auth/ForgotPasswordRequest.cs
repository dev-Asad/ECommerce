﻿using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain.Auth
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
