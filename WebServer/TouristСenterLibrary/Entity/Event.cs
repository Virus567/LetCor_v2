using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace TouristСenterLibrary.Entity
{
    public class Event
    {
        private static ApplicationContext db = ContextManager.db;
        public int ID { get; set; }
        [Required] public TypeEvent TypeEvent { get; set; }
        [Required] public DateTime DateTime { get; set; }
        [Required] public DateTime BusTime { get; set; }
        [Required] public EventUser User { get; set; }
        [Required] public School School { get; set; }
        [Required] public string Class { get; set; }
        [Required] public int PeopleAmount { get; set; }
        [Required] public double Price { get; set; }
        [Required] public double TravelSurcharge { get; set; }
        [Required] public double BusSupplement { get; set; }
        [Required] public double Discount { get; set; }
        [Required] public bool IsYourTransport { get; set; }
        [Required] public string Status { get; set; }
        [Required] public bool IsCash { get; set; }
        [Required] public double Prepayment { get; set; }
        [Required] public int AccompanyAmount { get; set; }
        [Required] public int IdType { get; set; }
        public DateTime CreateDate { get; set; }
        public string? ContractFilePath { get; set; }
        
        public enum EnumStatus
        {
            [Description("Активна")] active = 1,
            [Description("Внесен Аванс")] prepayment = 2,
            [Description("Оплачена")] payedFor = 3,
            [Description("Завершена")] сompleted = 4,
            [Description("Отменена")] canceled = 5
        }

        public Event()
        {
            CreateDate = DateTime.Now;
        }
        public bool Add() 
        {
            try
            {
                db.Event.Add(this);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool Update()
        {
            try
            {
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public class EventView
        {
            public int ID { get; set; }
            public string Date { get; set; }
            public string Time { get; set; }
            public string BusTime { get; set; }
            public string Status { get; set; }
            public string TypeEvent { get; set; }
            public string School { get; set; }
            public string Class { get; set; }
            public int PeopleAmount { get; set; }
            public double Price { get; set; }
            public double Discount { get; set; }
            public double BusSupplement { get; set; }
            public double TravelSurcharge { get; set; }
            public double TotalPrice { get; set; }
            public string? FIO { get; set; }
            public string? Address { get; set; }
            public string? Phone { get; set; }
            public double Prepayment { get; set; }
            public int AccompanyAmount { get; set; }
            public bool IsSchool { get; set; }
            public bool IsCash { get; set; }
            public bool IsYourTransport { get; set; }
            public int IdType { get; set; }
            public DateTime CreateDate { get; set; }
        }

        public static List<EventView> GetViews()
        {
            return db.Event.Select(e => new EventView()
            {
                ID = e.ID,
                Date = e.DateTime.ToString("d"),
                Time = e.DateTime.ToString("t"),
                BusTime = e.BusTime.ToString("t"),
                TypeEvent = e.TypeEvent.Name,
                School = e.School.Name,
                Class = e.Class,
                PeopleAmount = e.PeopleAmount,
                Status = e.Status,
                TotalPrice = e.Price * e.PeopleAmount - (e.PeopleAmount * e.Discount) + e.TravelSurcharge * e.PeopleAmount + e.BusSupplement,
                Price = e.Price,
                Discount = e.Discount,
                BusSupplement = e.BusSupplement,
                TravelSurcharge = e.TravelSurcharge,
                IsCash = e.IsCash,
                IsYourTransport = e.IsYourTransport,
                Prepayment = e.Prepayment,
                AccompanyAmount = e.AccompanyAmount,
                IsSchool = e.School.IsSchool,
                FIO = null,
                Address = null,
                Phone = null,
                IdType = e.IdType,
                CreateDate = e.CreateDate
            }).ToList();
        }
        public static EventView? GetViewByID(int id)
        {
            return db.Event.Include(e=>e.School)
                .Include(e=>e.User)
                .Include(e=>e.TypeEvent)
                .Where(e=>e.ID ==id).Select(e => new EventView()
                {
                    ID = e.ID,
                    Date = e.DateTime.ToString("d"),
                    Time = e.DateTime.ToString("t"),
                    BusTime = e.BusTime.ToString("t"),
                    TypeEvent = e.TypeEvent.Name,
                    School = e.School.Name,
                    Class = e.Class,
                    PeopleAmount = e.PeopleAmount,
                    Status = e.Status,
                    TotalPrice = e.Price * e.PeopleAmount - (e.PeopleAmount* e.Discount) + e.TravelSurcharge * e.PeopleAmount + e.BusSupplement,
                    Price = e.Price,
                    Discount = e.Discount,
                    BusSupplement = e.BusSupplement,
                    TravelSurcharge = e.TravelSurcharge,
                    FIO = $"{e.User.Surname} {e.User.Name} {e.User.Middlename}",
                    IsYourTransport = e.IsYourTransport,
                    IsCash = e.IsCash,
                    IsSchool = e.School.IsSchool,
                    Prepayment = e.Prepayment,
                    AccompanyAmount = e.AccompanyAmount,
                    Address = e.User.Address,
                    Phone = e.User.Phone,
                    IdType = e.IdType,
                    CreateDate = e.CreateDate
                }).FirstOrDefault();
        }

        public static Event? GetEventByID(int eventId)
        {
            return db.Event.Include(e=>e.User).Include(e=>e.School).Include(e=>e.TypeEvent)
                .Where(e => e.ID == eventId).FirstOrDefault();
        }
        public static int? GetLastIdType(int typeId)
        {
            return db.Event.Where(e=>e.TypeEvent.ID == typeId).OrderByDescending(e=>e.ID).Select(e=>e.IdType).FirstOrDefault();
        }
        
        public static List<string> GetPossibleStatuses(string str)
        {
            EnumStatus startStatus = GetEnumByDescription<EnumStatus>(str);
            List<string> list = new List<string>();
            foreach (EnumStatus status in Enum.GetValues(typeof(EnumStatus)))
            {
                if (status >= startStatus )
                {
                    list.Add(GetDescriptionByEnum(status));
                }
            }
            return list;
        }
        public static string GetDescriptionByEnum(Enum enumElement)
        {
            Type type = enumElement.GetType();

            MemberInfo[] memInfo = type.GetMember(enumElement.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }

            return enumElement.ToString();
        }
        public static T GetEnumByDescription<T>(string description) where T : Enum
        {
            foreach (var field in typeof(T).GetFields())
            {
                if (Attribute.GetCustomAttribute(field,
                        typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                {
                    if (attribute.Description == description)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (T)field.GetValue(null);
                }
            }
            throw new ArgumentException("Enum is not found!", nameof(description));
        }
    }
}
