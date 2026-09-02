using System;
using System.Collections.Generic;

namespace User.Api.Common.Database.Entities;

public partial class Permission
{
    public Guid Id { get; set; }

    public string PermissionName { get; set; } = null!;

    public string PermissionDescription { get; set; } = null!;

    public string Identifier { get; set; } = null!;

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}
