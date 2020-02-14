using System;
using System.Collections.Generic;

namespace Chain
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public ICollection<UserDevice> UserDevices { get; set; }
        public Company Company { get; set; }
    }
    public class Device
    {
        public Guid DeviceId { get; set; }
        public string Name { get; set; }
        public ICollection<UserDevice> UserDevices { get; set; }

        public ICollection<Task> Tasks { get; set; }

    }
    public class UserDevice
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid DeviceId { get; set; }
        public Device Device { get; set; }
        public bool Owner { get; set; }
    }
    public class Task
    {
        public Guid TaskId { get; set; }
    }
    public class Company
    {
        public Guid CompanyId { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
