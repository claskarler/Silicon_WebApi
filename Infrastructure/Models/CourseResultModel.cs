﻿namespace Infrastructure.Models;

public class CourseResultModel
{
    public bool Succeeded { get; set; }
    public IEnumerable<CourseModel>? Courses { get; set; }

}
