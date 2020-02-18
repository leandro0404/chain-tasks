using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chain
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }       
        public Guid CompanyId { get; set; }    
        public StatusEnum Status { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<UserDevice> UserDevices { get; set; }

    }
    public class Device
    {
        public string DeviceKey { get; set; }
        public string Ip { get; set; }
        public string Time { get; set; }
        public string Version { get; set; }
        public string PersonCount { get; set; }
        public string FaceCount { get; set; }
        public StatusEnum Status { get; set; }
        public virtual ICollection<UserDevice> UserDevices { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

    }
    public class UserDevice
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string DeviceKey { get; set; }
        public Device Device { get; set; }
        public Guid? OwnerId { get; set; }
    }
    public class Task
    {
        public Guid TaskNo { get; set; }
        public string InterfaceName { get; set; }
        public string Command { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public StatusTaskEnum Status { get; set; }
        public string DeviceKey { get; set; }
        public virtual Device Device { get; set; }
        public Guid CompanyId { get; set; }
    }
    public class Company
    {
        public Guid CompanyId { get; set; }
        public string CompanyKey { get; set; }
        public string Name { get; set; }
        public StatusEnum Status { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
    public class Processed
    {
        public Guid TaskNo { get; set; }
        public string DeviceKey { get; set; }
        public string InterfaceName { get; set; }
        public string Command { get; set; }
        public string Msg { get; set; }
        public int Result { get; set; }
        public bool Success { get; set; }
        public string Data { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public Guid CompanyId { get; set; }
        public bool Received { get; set; } = false;
    }
    public enum StatusTaskEnum
    {
        [Description("Waiting")]
        Waiting = 0,
        [Description("Runnig")]
        Runnig = 1
    }


    public enum StatusEnum
    {
        [Description("Active")]
        Active = 0,
        [Description("Blocked")]
        Blocked = 1,
        [Description("Inactive")]
        Inactive = 2
    }
}
