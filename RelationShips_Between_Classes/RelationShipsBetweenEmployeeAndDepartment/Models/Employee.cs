using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RelationShipsBetweenEmployeeAndDepartment.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(1,int.MaxValue,ErrorMessage ="Salary Must Be Positive Value")]
        public double Salary { get; set; }
        [Range(22,33,ErrorMessage ="Age Must Be Between 22 and 23")]
        public int Age { get; set; }

        #region Work Relationship (1 to many) -> take primary key of 1 as foreign key in many (Default RelationShip -> one to many)

        //Froiegn key By Convention
        [ForeignKey(nameof(WorkDepartment))]
        public int? DepartmentId { get; set; } //Type_OfNavigationProperty+Id
        // public int WorkDepartmentId { get; set; }//Name_OfNavigationProperty+Id

        // public int DepartmentDepartmentId { get; set; }//Type_OfNavigationProperty+PKOfPrincipleTable
        // public int WorkDepartmentDepartmentId { get; set; }//Name_OfNavigationProperty+PKOfPrincipleTable


        // Navigational property

        // public Department WorkDepartment { get; set; } // -> Default Total Participation
        [InverseProperty(nameof(Department.Employees))]
        public required Department WorkDepartment { get; set; } // ->Total Participation
        //public Department WorkDepartment { get; set; } = null!;// ->Total Participation

        //public Department? WorkDepartment { get; set; }// ->Optional Participation


        #endregion

        #region Manage Relation (1 to 1) -> take primary key of optional as foreing key in mandatory
        [InverseProperty(nameof(Department.Manger))]
        public Department? DepartmentToManage { get; set; }
        #endregion

        #region Address Relationship (1 to 1) Mandatory from both sides
        public Address Address { get; set; }
        #endregion
    }
}
