using System;
using System.Collections.Generic;

namespace CursaBD;

public partial class Employee
{
    public long EmployeeId { get; set; }

    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public long PhoneNumber { get; set; }

    public long Age { get; set; }

    public string? Exp { get; set; }

    public string Group { get; set; }
}
