using System;
using System.Collections.Generic;

namespace employee_management_api.Data.Entity
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? FatherName { get; set; }
        public DateOnly? Dob { get; set; }
        public string? Mobile { get; set; }
        public string? MobileAlternate { get; set; }
        public string? EmailPersonal { get; set; }
        public string? EmailOfficial { get; set; }
        public DateOnly? Doj { get; set; }
        public int? Desigination { get; set; }
        public string PermanentAddress { get; set; } = null!;
        public string PermanentCity { get; set; } = null!;
        public int PermanentState { get; set; }
        public string? CurrentAddress { get; set; }
        public string? CurrentCity { get; set; }
        public int? CurrentState { get; set; }
        public DateOnly? Dor { get; set; }
        public string? Remarks { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public sbyte Status { get; set; }
        public DateOnly CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateOnly? LastUpdatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
    }
}
