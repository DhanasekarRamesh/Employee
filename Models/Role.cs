using System;
using System.Collections.Generic;

namespace employee_management_api.Models
{
    public partial class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public sbyte Status { get; set; }
        public DateOnly CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateOnly? LastUpdatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
    }
}
