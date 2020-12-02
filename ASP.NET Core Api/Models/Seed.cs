using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Api.Models
{
    public class Seed
    {
        public static void SeedData(UserContext context)
        {
            // if there is no "User" in the database
            if (!context.User.Any())
            {
                // init some seed data
                var Logs = new List<Log>
                {
                    new Log { Id = 1, DeviceName = "ESP32-1", Measurement = 20, MeasurementType = "Celcius", LogDate = new DateTime(2001, 12, 25), UserId = 1 },
                    new Log { Id = 2, DeviceName = "ESP32-1", Measurement = 54, MeasurementType = "Humidity%", LogDate = new DateTime(2001, 12, 25), UserId = 1 },
                    new Log { Id = 3, DeviceName = "ESP32-2", Measurement = 15, MeasurementType = "Kg", LogDate = DateTime.Now, UserId = 2 },
                    new Log { Id = 4, DeviceName = "ESP32-3", Measurement = 70, MeasurementType = "Humidity%", LogDate = DateTime.Now, UserId = 3 }
                };

                var LogsForUser1 = new List<Log>();
                var LogsForUser2 = new List<Log>();
                var LogsForUser3 = new List<Log>();

                LogsForUser1.Add(Logs[0]);
                LogsForUser1.Add(Logs[1]);
                LogsForUser2.Add(Logs[2]);
                LogsForUser3.Add(Logs[3]);

                var Users = new List<User>
                {
                    new User { Id = 1, Email = "TestEmail1", Password = "TestPassword1", UserName = "TestUser1", HeightCm = 170, WeightKg = 80, DateOfBirth = new DateTime(2001, 12, 25), Logs = LogsForUser1 },
                    new User { Id = 2, Email = "TestEmail2", Password = "TestPassword2", UserName = "TestUser2", HeightCm = 182, WeightKg = 102, DateOfBirth = new DateTime(1992, 1, 5), Logs = LogsForUser2 },
                    new User { Id = 3, Email = "TestEmail3", Password = "TestPassword3", UserName = "TestUser3", HeightCm = 165, WeightKg = 50, DateOfBirth = new DateTime(2003, 2, 4), Logs = LogsForUser3 }
                };

                context.AddRange(Logs);
                context.AddRange(Users);

                context.SaveChanges();
            }
        }
    }
}
