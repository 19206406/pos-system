using System;
using System.Collections.Generic;

namespace User.Api.Common.Database.Entities;

public partial class User
{
    public Guid Id { get; set; }

    public string FullName { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string JobTitle { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? HashPassword { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<Session> Sessions { get; set; } = new List<Session>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}
