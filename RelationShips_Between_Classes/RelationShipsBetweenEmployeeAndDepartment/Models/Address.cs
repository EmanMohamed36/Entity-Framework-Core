using Microsoft.EntityFrameworkCore;

namespace RelationShipsBetweenEmployeeAndDepartment.Models
{
    //[Owned()] // owned for any class
    public class Address
    {
        public int? BlockNo { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }

    }
}
