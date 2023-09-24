using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace TouristСenterLibrary.Entity;

public class Charter
{
    private static ApplicationContext db = ContextManager.db;
    public int ID { get; set; }
    [Required] public EventUser User { get; set; }
    [Required] public string Charterer { get; set; }
    [Required] public string ChartererAddress { get; set; }
    [Required] public DateTime DateStart { get; set; }
    [Required] public DateTime DateFinish { get; set; }
    [Required] public int PeopleAmount { get; set; }
    [Required] public double Price { get; set; }
    [Required] public Transport Transport { get; set;}
    [Required] public Driver Driver { get; set;}
    [Required] public string StartRoutePoint { get; set; }
    [Required] public string FinishRoutePoint { get; set; }
    [Required] public List<RoutePoint> MiddleRoutePoints { get; set; }
    public string? Inn { get; set; } 
    [Required] public string Status { get; set; }
    [Required] public bool isAddedPeople { get; set; }
    [Required] public List<Children> ChildrenList { get; set; }
    [Required] public List<People> PeopleList { get; set; }
    public DateTime CreateDate { get; set; }
    public string? NotificationFilePath { get; set; }
    public string? ContractFilePath { get; set; }
    public string? RouteProgramFilePath { get; set; }
    public string? PeopleFilePath { get; set; }

    public Charter()
    {
        CreateDate = DateTime.Now;
        isAddedPeople = false;
    }
    
    public bool Add() 
    {
        try
        {
            db.Charter.Add(this);
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
    
    public class CharterView
        {
            public int ID { get; set; }
            public string Date { get; set; }
            public string Time { get; set; }
            public string DateFinish { get; set; }
            public string TimeFinish { get; set; }
            public string StartRoutePoint { get; set; }
            public List<RoutePoint> MiddlePoints { get; set; }
            public List<string> MiddleRoutePoints { get; set; }
            public string FinishRoutePoint { get; set; }
            public string Driver { get; set; }
            public string? Inn { get; set; }
            public string Status { get; set; }
            public string Charter { get; set; }
            public string CharterAddress { get; set; }
            public string Transport { get; set; }
            public int PeopleAmount { get; set; }
            public double Price { get; set; }
            public List<Children>ChildrenList { get; set; }
            public List<People> PeopleList { get; set; }

            public List<string> Childrens { get; set; }
            public List<string> Peoples { get; set; }
            public string? FIO { get; set; }
            public string? Address { get; set; }
            public string? Phone { get; set; }
            public string? NotificationFilePath { get; set; }
            public DateTime CreateDate { get; set; }
        }

        public static List<CharterView> GetViews()
        {
            return db.Charter
                .Include(c=>c.Transport)
                .Include(c=>c.Driver)
                .Include(c=>c.MiddleRoutePoints).Select(e => new CharterView()
            {
                ID = e.ID,
                Date = e.DateStart.ToString("d"),
                Time = e.DateStart.ToString("t"),
                DateFinish = e.DateFinish.ToString("d"),
                TimeFinish = e.DateFinish.ToString("t"),
                Charter = e.Charterer,
                CharterAddress = e.ChartererAddress,
                Transport = e.Transport.Brand,
                Driver =e.Driver.GetShortName(),
                StartRoutePoint = $"{e.DateStart.ToString("d")} {e.DateStart.ToString("t")} {e.StartRoutePoint}",
                FinishRoutePoint = $"{e.DateFinish.ToString("d")} {e.DateFinish.ToString("t")} {e.FinishRoutePoint}",
                PeopleAmount = e.PeopleAmount,
                Inn = e.Inn,
                MiddleRoutePoints = new List<string>(),
                Status = e.Status,
                Price = e.Price,
                FIO = null,
                Address = null,
                Phone = null,
                NotificationFilePath = e.NotificationFilePath,
                CreateDate = e.CreateDate
            }).ToList();
            
        }
        
        public static List<Event.EventView> GetEventViews()
        {
            return db.Charter.Select(e => new Event.EventView()
            {
                ID = e.ID,
                Date = e.DateStart.ToString("d"),
                Time = e.DateStart.ToString("t"),
                TypeEvent = "Фрахтование",
                School = e.Charterer,
                Class = "",
                Price = e.Price,
                PeopleAmount = e.PeopleAmount,
                Status = e.Status,
                CreateDate = e.CreateDate
            }).ToList();
        }
        
        
        public static CharterView? GetViewByID(int id)
        {
            var charter = db.Charter
                .Include(e=>e.User)
                .Include(c=>c.Transport)
                .Include(c=>c.Driver)
                .Include(c=>c.ChildrenList)
                .Include(c=>c.PeopleList)
                .Include(c=>c.MiddleRoutePoints)
                .Where(e=>e.ID ==id).Select(e => new CharterView()
                {
                    ID = e.ID,
                    Date = e.DateStart.ToString("d"),
                    Time = e.DateStart.ToString("t"),
                    DateFinish = e.DateFinish.ToString("d"),
                    TimeFinish = e.DateFinish.ToString("t"),
                    Charter = e.Charterer,
                    CharterAddress = e.ChartererAddress,
                    Transport = e.Transport.Brand,
                    Driver =e.Driver.GetShortName(),
                    StartRoutePoint = $"{e.DateStart.ToString("d")} {e.DateStart.ToString("t")} {e.StartRoutePoint}",
                    FinishRoutePoint = $"{e.DateFinish.ToString("d")} {e.DateFinish.ToString("t")} {e.FinishRoutePoint}",
                    MiddlePoints = e.MiddleRoutePoints,
                    PeopleAmount = e.PeopleAmount,
                    ChildrenList = e.ChildrenList,
                    PeopleList = e.PeopleList,
                    Inn = e.Inn,
                    MiddleRoutePoints = new List<string>(),
                    Childrens = new List<string>(),
                    Peoples = new List<string>(),
                    Status = e.Status,
                    Price = e.Price,
                    CreateDate = e.CreateDate,
                    FIO = $"{e.User.Surname} {e.User.Name} {e.User.Middlename}",
                    Address = e.User.Address,
                    Phone = e.User.Phone,
                    NotificationFilePath = e.NotificationFilePath
                }).FirstOrDefault();
            foreach (var item in charter.MiddlePoints.OrderBy(o=>o.ID))
            {
                var str = "";
                if (item.Date != "")
                {
                    str += $"{item.Date} ";
                }

                str += $"{item.Time} {item.Point}";
                charter.MiddleRoutePoints.Add(str);
            }

            var countChild = 1;
            foreach (var child in charter.ChildrenList.OrderByDescending(o=>o.ID))
            {
                var str = $"{countChild} {child.Fio} {child.DateOfB.ToString("d")} {child.NumberPhone}";
                charter.Childrens.Add(str);
                countChild++;
            }

            var countPeople = 1;
            foreach (var man in charter.PeopleList.OrderByDescending(o=>o.ID))
            {
                var str = $"{countPeople}   {man.Fio}   {man.NumberPhone}";
                charter.Peoples.Add(str);
                countPeople++;
            }

            return charter;
        }

        public static Charter? GetCharterByID(int eventId)
        {
            var charter = db.Charter.Include(e=>e.User)
                .Include(e=>e.Transport)
                .Include(e=>e.Driver)
                .Include(e=>e.MiddleRoutePoints)
                .Include(e=>e.PeopleList)
                .Include(e=>e.ChildrenList)
                .Where(e => e.ID == eventId).FirstOrDefault();
            charter.ChildrenList = charter.ChildrenList.OrderBy(c => c.ID).ToList();
            charter.PeopleList =charter.PeopleList.OrderBy(c => c.ID).ToList();
            return charter;
        }
    
    public enum EnumStatus
    {
        [Description("Активна")] active = 1,
        [Description("Оплачена")] payedFor = 2,
        [Description("Завершена")] сompleted = 4,
        [Description("Отменена")] canceled = 5
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