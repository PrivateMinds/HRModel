using System;
using System.ComponentModel.DataAnnotations;
namespace HRModel
{
#nullable enable
    public class viewActiveEmployees_HRapp
    {
        [Key]
        public string EmpID { get; set; } //  HRAdminWebApp
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int PositionID { get; set; }
        public string JobTitle { get; set; }
        public string Mid { get; set; }
        public string Extension { get; set; }
        public string AltDayPhone { get; set; }
        public string IndSupSSN { get; set; }
        public string IndirectGroup { get; set; }       
        public string TXCode { get; set; }
        public string SSN { get; set; }
        public string FTE { get; set; }
        public int FringeCat { get; set; }
        public decimal CHSFTE { get; set; }
        public decimal GHCFTE { get; set; }
        public decimal Rate { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public int PANJobNo { get; set; }
        public string Grade { get; set; }
        public int IntranetAccess { get; set; }
        public string Email { get; set; }
        public string? Status { get; set; }
        public string JobStatus { get; set; }

        public DateTime StatusDate { get; set; }
        public string Keycard { get; set; }
        public int PDAccess { get; set; }
        public string SupLast { get; set; }
        public string SupFirst { get; set; }
        public string IndSupFirst { get; set; }
        public string IndSupLast { get; set; }
        public int IsUnion { get; set; }

        public int GHP { get; set; }
        public string Exempt { get; set; }
        public int JobCode { get; set; }
        public string BargainingUnit { get; set; }
        public string HomeDept { get; set; }
        public string Schedule { get; set; }

        public int Step { get; set; }
        public int EpicCareAccess { get; set; }
        public DateTime EpicCareDate { get; set; }
        public int HIPAATraining { get; set; }
        public DateTime HIPAATrDate { get; set; }
        public int BloodbornePathogenTr { get; set; }

        public DateTime BBPTrDate { get; set; }
        public int ConfidentialityAgreement { get; set; }
        public DateTime ConfAgrDate { get; set; }
        public int InventionPatentAgreement { get; set; }
        public DateTime InvPatAgrDate { get; set; }
        public int ConflictInterestAckn { get; set; }

        public DateTime ConflictInterestDate { get; set; }
        public int DataOffSiteAgreement { get; set; }
        public DateTime DataOffSiteAgrDate { get; set; }
        public string Key { get; set; }
        public string EMP_LabDistFlag { get; set; }
        public string UserID { get; set; }

        public string GHCUserID { get; set; }
        public string PANPositionNo { get; set; }
        public int Faculty { get; set; }
        public DateTime BirthDate { get; set; }
        public string LDTCoordinator { get; set; }
        public string SupEmpID { get; set; }

        public string SupEmail { get; set; }
        public string HREmpID { get; set; }
        public string EmployeeStatus { get; set; }
        public string SupLastName { get; set; }
        public string SupFirstName { get; set; }

    }
}

      