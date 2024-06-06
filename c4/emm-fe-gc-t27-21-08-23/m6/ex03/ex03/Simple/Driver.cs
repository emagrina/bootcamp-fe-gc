using ex03.Interface;

namespace ex03.Simple
{
    class Driver : IPerson
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DriverLicense License { get; set; }
    }
}

