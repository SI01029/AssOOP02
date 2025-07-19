using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssOOP02
{
    #region Gender
    enum Gender
    {
        male,
        female
    } 
    #endregion


    #region Security Level
    enum SecurityLevel
    {
        guest,
        Developer,
        secertary,
        DBA
    } 
    #endregion

    internal class Employee
    {


        #region proberities
		public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel Securitylevel { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public Gender Gender { get; set; }
        #endregion

        #region Constructor
        public Employee(int id, string name, Gender gender, decimal salary, DateTime hireDate,
        SecurityLevel secLevel)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
            HireDate = hireDate;
            Securitylevel = secLevel;

        }

        #endregion

        #region ToString
        public override string ToString()
        {
            return $"Id : {Id} \nName : {Name} \nGender : {Gender} \nSalary : {Salary} \nHireDate : {HireDate:dd/MM/yyyy} \nSecuritylevel : {Securitylevel}";
        } 
        #endregion

    }
}
