using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Visitel.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleNameInitial { get; set; }
        public string Address { get; set; }
        public string ApartmentNumber { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int Zip { get; set; }
        public string Phone { get; set; }
        public string AlternatePhone { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int EmploymentStatusId { get; set; }
        public string EmploymentStatus { get; set; }
        public int NumberOfVerifiedReference { get; set; }
        public int NumberOfDepartment { get; set; }
        public int MaritalStatus { get; set; }
        public decimal Payrate { get; set; }
        public int Title { get; set; }
        public int LicenseStatus { get; set; }
        public string ApplicationDate { get; set; }
        public string HireDate { get; set; }
        public string SignedJobDescriptionDate { get; set; }
        public string ReferenceVerificationDate { get; set; }
        public string OrientationDate { get; set; }
        public string PolicyOrProcedureSettlementDate { get; set; }
        public string AssignedTaskEvaluationDate { get; set; }
        public string CrimcheckDate { get; set; }
        public string RegistryDate { get; set; }
        public string LastEvaluationDate { get; set; }
        public string EndDateTwo { get; set; }
        public string Gender { get; set; }
        public Int16 RehireYesNo { get; set; }
        public string Comments { get; set; }
        public Int16 MailCheck { get; set; }
        public int ClientGroupId { get; set; }
        public string OIGDate { get; set; }
        public string OIGResult { get; set; }
        public string OIGReportedToStateDate { get; set; }
        public string ASGN_EMP_SSN { get; set; }
        public string SantraxEmployeeId { get; set; }
        public decimal SantraxCDSPayrate { get; set; }
        public string SantraxGPSPhone { get; set; }
        public string SantraxDiscipline { get; set; }
        public string SantraxStatus { get; set; }
        public string PayMethod { get; set; }
        public string PayrollNumber { get; set; }
        public string MyProperty { get; set; }
        public string VendorEmployeeId { get; set; }
        public string UpdateBy { get; set; }
        public string UpdateDate { get; set; }
        public int CompanyId { get; set; }
        public int UserId { get; set; }
    }
}