using System;
using System.Collections.Generic;

namespace BE.Models;

public partial class Account
{
    public int AccountId { get; set; }

    public string UserName { get; set; } = null!;

    public string PassWord { get; set; } = null!;

    public int Status { get; set; }

    public string? Email { get; set; }

    public string? FullName { get; set; }

    public string? Location { get; set; }

    public string? Phone { get; set; }

    public int RoleId { get; set; }

    public string Token { get; set; } = null!;

    public int? IsDelete { get; set; }

    public int? StoreId { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual Store? Store { get; set; }
}
