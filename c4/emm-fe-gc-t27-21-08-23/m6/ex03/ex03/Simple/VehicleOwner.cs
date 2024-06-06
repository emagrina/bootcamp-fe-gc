using ex03.Interface;

namespace ex03.Simple
{
    class VehicleOwner : IPerson
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool HasInsurance { get; set; }
        public bool HasGarage { get; set; }
    }
}

