using System;
using System.Collections.Generic;

namespace Person_CRUD.Models
{
    public partial class Person
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }
    }
}
