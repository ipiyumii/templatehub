﻿using System.ComponentModel.DataAnnotations;

namespace boilerplate_app.Application.DTOs
{
    public class UserDto
    {
        [Required] public string? Username { get; set; }
        [Required] public string? FullName { get; set; }
        [Required] public string? Email { get; set; }
        [Required] public string? Password { get; set; }
    }
}
