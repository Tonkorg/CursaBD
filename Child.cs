using System;
using System.Collections.Generic;

namespace CursaBD;

public partial class Child
{
    public long ChildrenId { get; set; }

    public string Name { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Sex { get; set; } = null!;

    public int? Age { get; set; } = null!;

    public string Sens { get; set; }

    public long ParensId { get; set; }

    public int Otr { get; set; }
}
