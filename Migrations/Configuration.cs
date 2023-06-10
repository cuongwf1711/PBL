namespace PBL.Migrations
{
    using PBL.DTO;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<HMSDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(HMSDB context)
        {
            context.Roles.AddOrUpdate(new Role[] 
            {
                new Role { RoleId = 1, Name = "Admin" },
                new Role { RoleId = 2, Name = "Receptionist", Permisssion = "BookRoom,Payment,Customer" },
            });
            context.Accounts.AddOrUpdate(new Account[]
            {
                new Account
                {
                    PersonId = 123456,
                    PhoneNumber = "0905123456",
                    Password = "bcb15f821479b4d5772bd0ca866c00ad5f926e3580720659cc80d39c9d09802a",
                    RoleId = 1,
                    Name = "Nguyen Van Quan Ly",
                    Birthday = new DateTime(1995, 05, 21),
                    Email = "ruivalien@gmail.com"
                },
                new Account
                {
                    PersonId = 654321,
                    PhoneNumber = "0905654321",
                    Password = "bcb15f821479b4d5772bd0ca866c00ad5f926e3580720659cc80d39c9d09802a",
                    RoleId = 2,
                    Name = "Le Van Le Tan",
                    Birthday = new DateTime(2000, 05, 19),
                    Email = "cuongnguyen171103@gmail.com"
                }
            }); ;
            context.Lates.AddOrUpdate(new Late[]
            {
                new Late { LateId = 1, Name = "Late 12h - 15h", FeeLate = 0.3m },
                new Late { LateId = 2, Name = "Late 15h - 18h", FeeLate = 0.5m },
                new Late { LateId = 3, Name = "Late after 18h", FeeLate = 1 },
            });
            context.Vouchers.AddOrUpdate(new Voucher[]
            {
                new Voucher { VoucherId = 1, Code = "Voucher20%", Discount = 0.2m, Quantity = 5 },
                new Voucher { VoucherId = 2, Code = "Voucher50%", Discount = 0.5m, Quantity = 2 },
            });
            context.Services.AddOrUpdate(new Service[]
            {
                new Service { ServiceId = 1, Name = "Massage", Price = 100 },
                new Service { ServiceId = 2, Name = "Visit city by electric car", Price = 200 },
                new Service { ServiceId = 3, Name = "Buffet morning", Price = 300 },
                new Service { ServiceId = 4, Name = "Buffet lunch", Price = 400 },
                new Service { ServiceId = 5, Name = "Buffet dinner", Price = 500 },
                new Service { ServiceId = 6, Name = "Play golf", Price = 600 },
                new Service { ServiceId = 7, Name = "Transfer car", Price = 700 },
            });
            context.TypeRooms.AddOrUpdate(new TypeRoom[]
            {
                new TypeRoom { TypeRoomId = 1, Name = "VIP" },
                new TypeRoom { TypeRoomId = 2, Name = "Standard" },
            });
            context.Rooms.AddOrUpdate(new Room[]
            {
                new Room { RoomId = 101, Capacity = 1, Price = 500, TypeRoomId = 1},
                new Room { RoomId = 102, Capacity = 2, Price = 600, TypeRoomId = 2},
                new Room { RoomId = 103, Capacity = 4, Price = 900, TypeRoomId = 1},
            });
        }
    }
}
