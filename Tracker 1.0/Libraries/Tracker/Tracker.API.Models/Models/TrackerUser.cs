using System;
using System.Collections.Generic;

namespace Tracker.API.Data.Models
{
    public partial class TrackerUser
    {
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; } = null!;
    }
}
