using System;
using System.Collections.Generic;

namespace employee_management_api.Models
{
    public partial class UserDocument
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DocumentId { get; set; }
        public string? Number { get; set; }
        public DateOnly? ExpiryDate { get; set; }
        public DateOnly CreatedDate { get; set; }
    }
}
