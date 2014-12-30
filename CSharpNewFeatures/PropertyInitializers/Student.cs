using System;

namespace PropertyInitializers
{
    public class Student
    {
        public Guid StudentId { get; } = Guid.NewGuid();
        public string FirstName { get; set; } = "Jalpesh";
        public string LastName { get; set; } = "Vadgama";
    }
}
