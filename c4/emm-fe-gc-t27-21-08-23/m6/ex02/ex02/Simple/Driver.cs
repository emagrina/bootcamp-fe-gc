using System;
using ex02.Interface;

namespace ex02.Simple
{
    class Driver : IPerson
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public required DriverLicense License { get; set; }
    }
}

