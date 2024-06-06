using System;
namespace ex02.Simple
{
    class DriverLicense
    {
        public required string ID { get; set; }
        public required string LicenseType { get; set; }
        public required string FullName { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}

