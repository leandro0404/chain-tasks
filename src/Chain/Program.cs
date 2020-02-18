using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chain
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            context.Database.EnsureCreated();

            //context.Company.Add(new Company()
            //{
            //    CompanyKey = "1",
            //    Name = "biomtech",
            //    Users = new List<User> {
            //    new User(){
            //    Name = "leandro silveira"  }

            //}
            //});

            //var user = context.User.Include("Company").First();


            //var device = new Device()
            //{
            //    DeviceKey = "84E0F4211455607A",
            //    FaceCount = "",
            //    PersonCount = "",
            //    Ip = "",
            //    Version = "",
            //    Time = "",

            //};

            //var userDevice = new UserDevice
            //{
            //    Device = device,
            //    User = user,

            //};

            //var list = new List<UserDevice>();
            //list.Add(userDevice);

            //user.UserDevices = list;



            //context.SaveChanges();



            Console.WriteLine("Hello World!");
        }
    }

}
