using System;
using System.Collections.Generic;

namespace ASP.NET_Core_Api.Models
{
    public partial class Logs
    {
        public int? UserId { get; set; }
        public float Measurement { get; set; }
        public string MeasurementType { get; set; }
        public string DeviceName { get; set; }
        // ? means it can also be NULL
        public DateTime? LogDate { get; set; }
}
}
