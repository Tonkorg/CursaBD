using System;
using System.Collections.Generic;

namespace CursaBD;

public partial class User
{
    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public long UserId { get; set; }

    public long PhoneNumber { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public long? UserType { get; set; }

}
