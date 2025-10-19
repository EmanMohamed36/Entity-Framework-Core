using System.ComponentModel.DataAnnotations.Schema;

namespace RelationShipsBetweenEmployeeAndDepartment.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public required string Name { get; set; }

        public DateOnly CreationDate { get; set; }

        #region Work Relationship (1 to many) -> take primary key of 1 as foreign key in many

        //public List<Employee> Employees { get; set; } = null!;
        [InverseProperty(nameof(Employee.WorkDepartment))]
        public List<Employee>? Employees { get; set; } //optional participation
        //public required  List<Employee> Employees { get; set; } //optional participation
        //public List<Employee> Employees { get; set; }//optional participation

        #endregion

        #region Manage Relation (1 to 1) -> take primary key of optional as foreing key in mandatory
        [ForeignKey(nameof(Manger))]
        public int MangerId { get; set; }

        [InverseProperty(nameof(Employee.DepartmentToManage))]
        public required Employee Manger { get; set; }
        #endregion

    }
}
