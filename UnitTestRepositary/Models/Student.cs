﻿using System.Diagnostics.CodeAnalysis;

namespace UnitTestRepositary.Models
{
    [ExcludeFromCodeCoverage]
    public class Student
    {
        public string? Name { get; set; }

        public int Age { get; set; }

        public int Grade { get; set; }

        public bool Exceptional { get; set; }

        public bool HonorRoll { get; set; }

        public bool Passed { get; set; }
    }
}
