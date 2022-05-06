﻿using DMS.Entities;
using System;
using System.Collections.Generic;

namespace DMS.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DMS.Entities.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DMS.Entities.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.


            context.Studies.AddOrUpdate(new Study()
            {
                ID = 1,
                IsActive = true,
                StudyTitle = "آبیاری گیاهان دریایی"
            });

            context.EducationalCenters.AddOrUpdate(new EducationalCenter()
            {
                ID = 1,
                EducationalName = "دانشگاه آزاد اسلامی سنندج",
                IsActive = true
            });


            context.Students.AddOrUpdate(
                new Student
                {
                    StudentID = 1,
                    FullName = "فرشید محمدی",
                    StudentCode = "3782428218",
                    StudentTel = "09186620474",
                    NationalCode = "3782428218",
                    Birthday = new DateTime(1986, 05, 24),
                    FatherName = "یداله",
                    FatherTel = "09186620474",
                    HomeTel = "09186620474",
                    OtherName = "برادر",
                    OtherTel = "09186620474",
                    Img = null,
                    StudyID_FK = 1,
                    EducationalID_FK = 1,
                });

            context.TrafficTypes.AddOrUpdate(new TrafficType()
            {
                ID = 1,
                TrafficTypeTitle = "مهمان داخل شهر"
            }, new TrafficType()
            {
                ID = 2,
                TrafficTypeTitle = "مهمان شهرستان"
            });

            context.Dormitories.AddOrUpdate(new Dormitory()
            {
                ID = 1,
                DormitoryName = "خوابگاه دکترحسابی",
                Room = 50,
                Valence = 600
            });


            context.Rooms.AddOrUpdate(new Room()
            {
                RoomID = 1,
                DormitoryID_FK = 1,
                RoomCapacity = 12,
                RoomNumber = "1"
            });


            context.Destinations.AddOrUpdate(
                new Destination()
                {
                    ID = 1,
                    DestinationTitle = "منزل بستگان"

                }, new Destination()
                {
                    ID = 2,
                    DestinationTitle = "منزل دوستان",
                }, new Destination()
                {
                    ID = 3,
                    DestinationTitle = "سایر"
                });

            context.PanelInfos.AddOrUpdate(new PanelInfo()
            {
                Id = 1,
                SendNumber = "30007227001374",
                WarningReceiver = "09186620474",
                MinCredit = 12000,
                MidCredit = 50000,
                IsActive = true,
                Username = "aWF1YmlqYXI=",
                Password = "TTQyMjgwNTY="
            });

            context.AccessTables.AddOrUpdate(new AccessTable()
            {
                ID = 1,
                AccessTitle = "مدیر سیستم",

            }, new AccessTable()
            {
                ID = 2,
                AccessTitle = "ثبت و تغییراطلاعات",

            }, new AccessTable()
            {
                ID = 3,
                AccessTitle = "ثبت اطلاعات",

            });
            context.ApplicationUsers.AddOrUpdate(new ApplicationUser
            {
                UserID = 1,
                Username = "administrator",
                Password = "MTIzNDU2Nzg5",
                AccessID_FK = 1,
                Job = "مدیر سیستم",
                IsActive = true,

            }, new ApplicationUser
            {
                UserID = 2,
                Username = "manage",
                Password = "MTIzNDU2Nzg5",
                AccessID_FK = 2,
                Job = "کاربر ارشد",
                IsActive = true,
            }, new ApplicationUser
            {
                UserID = 3,
                Username = "user",
                Password = "MTIzNDU2Nzg5",
                AccessID_FK = 3,
                Job = "کاربر",
                IsActive = true,
            });


            base.Seed(context);
        }
    }
}
