using System;
using System.ComponentModel.DataAnnotations;

namespace TaskTimeTracker.DTOs;

public class UserDto
{
    public Guid Id { get; set; }

    [Required]
    [StringLength(256)]
    public string UserName { get; set; }

    [Required]
    [StringLength(256)]
    public string Email { get; set; }

    public string Role { get; set; }
}
