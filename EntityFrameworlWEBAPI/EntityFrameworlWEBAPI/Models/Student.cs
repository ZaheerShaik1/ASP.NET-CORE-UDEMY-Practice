using System;
using System.Collections.Generic;

namespace EntityFrameworlWEBAPI.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Gender { get; set; } = null!;
}
