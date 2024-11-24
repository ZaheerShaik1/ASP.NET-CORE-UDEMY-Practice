using System;
using System.Collections.Generic;

namespace EntityFrameworlWEBAPI.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; } = null!;

    public string CourseCategory { get; set; } = null!;
}
