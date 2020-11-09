﻿using System.ComponentModel.DataAnnotations;

namespace SallyServer.Models
{
    /// <summary>
    /// Model to accept login parameters
    /// </summary>
    public class LoginUser
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(150, MinimumLength = 5)]
       // [RegularExpression] validates strings to make sure the casing is proper
        public string Password { get; set; }
    }
}
