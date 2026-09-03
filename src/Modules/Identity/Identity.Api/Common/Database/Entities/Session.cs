using System;
using System.Collections.Generic;

namespace User.Api.Common.Database.Entities;

public partial class Session
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string TokenHash { get; set; } = null!;

    public string? DeviceInfo { get; set; }

    public string? IpAddress { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime ExpiresAt { get; set; }

    public DateTime? RevokedAt { get; set; }

    public Guid? ReplacedById { get; set; }

    public virtual ICollection<Session> InverseReplacedBy { get; set; } = new List<Session>();

    public virtual Session? ReplacedBy { get; set; }

    public virtual User User { get; set; } = null!;
}
