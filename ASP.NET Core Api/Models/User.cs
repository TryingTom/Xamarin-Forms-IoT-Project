using System;
using System.Collections.Generic;

namespace ASP.NET_Core_Api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public float? HeightCm { get; set; }
        public float? WeightKg { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public ICollection<Log> Logs { get; set; }
    }
}
