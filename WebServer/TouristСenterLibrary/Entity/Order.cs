using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace TouristСenterLibrary.Entity
{
    public class Order 
    {
        private static ApplicationContext db = ContextManager.db;
        public int ID { get; set; }
        [Required] public ApplicationType ApplicationType { get; set; }
        [Required] public Route Route { get; set; }
        [Required] public Employee Employee { get; set; }
        [Required] public TouristGroup TouristGroup { get; set; }
        [Required] public string WayToTravel { get; set; }
        public string? FoodlFeatures { get; set; }
        public string? EquipmentFeatures { get; set; }
        [Required] public DateTime StartTime { get; set; }
        [Required] public DateTime FinishTime { get; set; }
        [Required] public string Status { get; set; }
        public Hike? Hike { get; set; }
        [Required] public int IndividualTentAmount { get; set; }
        [Required] public int IndividualTent { get; set; }
        [Required] public int IndividualSleepingBag { get; set; }
        [Required] public double Price { get; set; }
        public Instructor? Instructor { get; set; }
        public bool IsPhotograph { get; set; }
        [Required] public double Prepayment { get; set; }
        public string? ContractFilePath { get; set; }
        [Required] public bool IsCash { get; set; }
        public string? BossType { get; set; }
        public double? Insurance { get; set; }
        public string? BasedOrganization { get; set; }
        [Required] public DateTime CreateDate { get; set; }
        
        
        private static string  _path = Path.Combine(Directory.GetCurrentDirectory(), $"discounts.data");
        private static string _disc5 = "";
        private static string _disc10 = "";
        private static string _disc14 = "";

        public Order()
        {
            CreateDate =  DateTime.Now;
        }
        public enum EnumStatus
        {
            [Description("Активна")] active = 1,
            [Description("В сборке")] inAssembly = 2,
            [Description("Завершена")] сompleted = 3,
            [Description("Отменена")] canceled = 4
        }

        public class  OrderView
        {
            public int ID { get; set; }
            public List<User> Users { get; set; } = new List<User>();
            public string DateTime { get; set; }
            public string FinishTime { get; set; }
            public string RouteName { get; set; }
            public string WayToTravel { get; set; }
            public string TouristGroup { get; set; }
            public int TouristGroupID { get; set;}
            public int PeopleAmount { get; set; }
            public int ChildrenAmount { get; set; }
            public string ApplicationTypeName { get; set; }
            public string Status { get; set; }
            public double Price { get; set; }
            public bool IsListParticipants { get; set; }
            public bool IsPhotograph { get; set; }
            public double Prepayment { get; set; }
            public bool IsCash { get; set; }
        }
        public static List<OrderView> GetView()
        {
            List<OrderView> list = (from o in db.Order
                    .Include(o=>o.ApplicationType)
                    .Include(o=>o.TouristGroup).ThenInclude(t=>t.User)
                    select new OrderView()
                    {
                        ID = o.ID,
                        DateTime = o.StartTime.ToString("d"),
                        FinishTime = o.FinishTime.ToString("d"),
                        RouteName = o.Route.Name,
                        WayToTravel = o.WayToTravel,
                        TouristGroup = GetCompanyName(o, false),
                        TouristGroupID = o.TouristGroup.ID,
                        PeopleAmount = o.TouristGroup.PeopleAmount,
                        ApplicationTypeName = o.ApplicationType.Name,
                        ChildrenAmount = o.TouristGroup.ChildrenAmount,
                        Status = o.Status,
                        IsPhotograph = o.IsPhotograph,
                        Price = o.Price,
                        IsCash = o.IsCash,
                        Prepayment = o.Prepayment,
                        IsListParticipants = false
                        
                    }).ToList();
            foreach (var l in list)
            {
                
                if (l.ApplicationTypeName == "ИП" || l.ApplicationTypeName == "ООО")
                {
                    l.IsListParticipants = true;
                }
                else
                {
                    l.IsListParticipants = Participant.IsParticipantsForOrder(TouristGroup.GetGroupByID(l.TouristGroupID));
                }
            }
            return list;
        }

        public static string GetCompanyName(Order order, bool isHike)
        {
            string result ="";
            if (order.ApplicationType.Name == "ООО")
            {
                result = order.TouristGroup.User.NameOfCompany;
            }
            else if (order.ApplicationType.Name == "ИП")
            {
                result = $"ИП {order.TouristGroup.User.GetShortName()}";
            }
            else if(isHike)
            {
                result = "Сборная";
            }
            else
            {
                result = order.TouristGroup.User.GetShortName();
            }

            return result;
        }
        public static List<OrderView> GetViewByUserId(int userId)
        {
            try
            {
                List<OrderView> list = (from o in db.Order
                                    .Include(o=>o.ApplicationType)
                                    .Include(o => o.TouristGroup)
                                    .ThenInclude(o => o.User)
                                    .Include(o => o.TouristGroup)
                                    .ThenInclude(o => o.ParticipantsList)
                                    .ThenInclude(o =>o.User)
                                        select new OrderView()
                                        {
                                            ID = o.ID,
                                            DateTime = o.StartTime.ToString("d"),
                                            FinishTime = o.StartTime.ToString("d"),
                                            RouteName = o.Route.Name,
                                            WayToTravel = o.WayToTravel,
                                            TouristGroup = GetCompanyName(o,false),
                                            TouristGroupID = o.TouristGroup.ID,
                                            PeopleAmount = o.TouristGroup.PeopleAmount,
                                            ApplicationTypeName = o.ApplicationType.Name,
                                            ChildrenAmount = o.TouristGroup.ChildrenAmount,
                                            Status = o.Status,
                                            IsCash = o.IsCash,
                                            Prepayment = o.Prepayment,
                                            IsListParticipants = false
                                            
                                        }).ToList();
                foreach (var l in list)
                {
                    var touristGroup = TouristGroup.GetGroupByID(l.ID);
                    l.Users.Add(touristGroup.User);
                    foreach (var participant in touristGroup.ParticipantsList)
                    {
                        l.Users.Add(participant.User);
                    }
                }
                list = list.Where(o => o.Users.Contains(User.GetUserByID(userId)) && o.Status == "Активна").ToList();
                return list;
            }
            catch (Exception ex)
            {
                return new List<OrderView>();
            }
            
        }

        public static OrderView? GetViewById(int orderId)
        {
            try
            {
                OrderView? order = (from o in db.Order
                                    .Include(o=>o.ApplicationType)
                                    .Include(o => o.TouristGroup)
                                    .ThenInclude(o => o.User)
                                    .Include(o => o.TouristGroup)
                                    .ThenInclude(o => o.ParticipantsList)
                                    .ThenInclude(o => o.User)
                                    .Where(o=>o.ID == orderId)
                                        select new OrderView()
                                        {
                                            ID = o.ID,
                                            DateTime = o.StartTime.ToString("d"),
                                            FinishTime = o.FinishTime.ToString("d"),
                                            RouteName = o.Route.Name,
                                            WayToTravel = o.WayToTravel,
                                            TouristGroup = GetCompanyName(o,false),
                                            TouristGroupID = o.TouristGroup.ID,
                                            PeopleAmount = o.TouristGroup.PeopleAmount,
                                            ApplicationTypeName = o.ApplicationType.Name,
                                            ChildrenAmount = o.TouristGroup.ChildrenAmount,
                                            Status = o.Status,
                                            IsCash = o.IsCash,
                                            Prepayment = o.Prepayment,
                                            IsListParticipants = false
                                        }).FirstOrDefault();
                if(order != null)
                {
                    var touristGroup = TouristGroup.GetGroupByID(order.ID);
                    order.Users.Add(touristGroup.User);
                    foreach (var participant in touristGroup.ParticipantsList)
                    {
                        order.Users.Add(participant.User);
                    }
                }
                    
                return order;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public class OrderViewAll
        {
            public int ID { get; set; }
            public string StartTime { get; set; }
            public string Time { get; set; }
            public string FIO { get; set; }
            public string Organization { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public string OgrnIp { get; set; }
            public string FinishTime { get; set; }
            public string RouteName { get; set; }
            public string WayToTravel { get; set; }
            public string TouristGroup { get; set; }
            public int TouristGroupID { get; set; }
            public int PeopleAmount { get; set; }
            public int ChildrenAmount { get; set; }
            public string ApplicationType { get; set; }
            public string Status { get; set; }
            public int IndividualTent { get; set; }
            public int IndividualSleepingBag { get; set; }
            public double Price { get; set; }
            public int IndividualTentAmount { get; set; }
            public string FoodlFeatures { get; set; }
            public string EquipmentFeatures { get; set; }
            public double TotalPrice { get; set; }
            public bool IsListParticipants { get; set; }
            public bool IsCash { get; set; }
            public double Prepayment { get; set; }
            public string? BossType { get; set; }
            public double? Insurance { get; set; }
            public string? BasedOrganization { get; set; }
            

        }
        public static void Add(Order order)
        {
            db.Order.Add(order);
            db.SaveChanges();
        }
        public bool Add() 
        {
            try
            {
                db.Order.Add(this);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public static void Update(Order order)
        {
            db.Order.Update(order);
            db.SaveChanges();
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
        public static OrderViewAll? GetViewAllByID(int orderID)
        {
            OrderViewAll? order = db.Order.Include(o=>o.ApplicationType)
                                        .Include(o => o.TouristGroup)
                                        .ThenInclude(o=>o.User)
                                        .Where(o => o.ID == orderID)
                                        .Select(o =>  new OrderViewAll()
                                        {
                                            ID = orderID,
                                            StartTime = o.StartTime.ToString("d"),
                                            Time = o.StartTime.ToString("t"),
                                            FIO = o.TouristGroup.GetFullName(),
                                            Organization = o.TouristGroup.User.NameOfCompany,
                                            Phone = o.TouristGroup.User.PhoneNumber,
                                            Address = o.TouristGroup.User.AddressOrg,
                                            OgrnIp = o.TouristGroup.User.OgrnIP,
                                            FinishTime = o.FinishTime.ToString("d"),
                                            RouteName = o.Route.Name,
                                            WayToTravel = o.WayToTravel,
                                            TouristGroup = GetCompanyName(o,false),
                                            TouristGroupID = o.TouristGroup.ID,
                                            PeopleAmount = o.TouristGroup.PeopleAmount,
                                            ApplicationType = o.ApplicationType.Name,
                                            ChildrenAmount =o.TouristGroup.ChildrenAmount,
                                            FoodlFeatures = o.FoodlFeatures,
                                            EquipmentFeatures = o.EquipmentFeatures,
                                            Status = o.Status,
                                            Price= o.Price,
                                            IndividualSleepingBag = o.IndividualSleepingBag,
                                            IndividualTent = o.IndividualTent,
                                            TotalPrice = GetTotalPrice(o),
                                            Prepayment = o.Prepayment,
                                            IsCash = o.IsCash,
                                            IndividualTentAmount =o.IndividualTentAmount,
                                            BossType =  o.BossType,
                                            Insurance = o.Insurance,
                                            BasedOrganization = o.BasedOrganization
                                        }).FirstOrDefault();

            order.IsListParticipants = Participant.IsParticipantsForOrder(TouristGroup.GetGroupByID(order.TouristGroupID));
            return order;
        }
        public static Order GetOrderByID(int orderID)
        {
            var order = db.Order
                .Include(o => o.TouristGroup)
                .Include(o => o.Route)
                .Include(o => o.ApplicationType)
                .Include(o=>o.Hike)
                .Where(o => o.ID == orderID).FirstOrDefault();
            db.Participant.Where(p => p.TouristGroupID == order.TouristGroup.ID).Load();
            return order;
        }
        public static double GetTotalPrice(Order order)
        {
            
            if (File.Exists(_path))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(_path, FileMode.Open)))
                {
                    var tmp = reader.ReadString();
                    tmp = reader.ReadString();
                    tmp = reader.ReadString();
                    _disc5 = reader.ReadString();
                    _disc10 = reader.ReadString();
                    _disc14 = reader.ReadString();
                    
                }
            }
            double price = 0;
            foreach (var participant in order.TouristGroup.ParticipantsList)
            {
                int age = DateTime.Now.Year - participant.User.DateOfB.Year;
                if (participant.User.DateOfB > DateTime.Now.AddYears(-age))
                    age--;
                if ( age > 14)
                {
                    price += order.Price;
                }
                else if(age > 10)
                {
                    price += order.Price * (1 - Double.Parse(_disc14)/100);
                }
                else if(age > 5)
                {
                    price += order.Price * (1 - Double.Parse(_disc10)/100);
                }
                else
                {
                    price += order.Price * (1 - Double.Parse(_disc5)/100);
                }                
            }
            var insurance = order.Insurance;
            if (insurance != null || insurance != 0)
            {
                price += Convert.ToDouble(insurance) * order.TouristGroup.PeopleAmount;
            }
            return price;
        }

        public double GetChildrenPrice(int age)
        {
            if (_disc5 == "")
            {
                if (File.Exists(_path))
                {
                    using (BinaryReader reader = new BinaryReader(File.Open(_path, FileMode.Open)))
                    {
                        var tmp = reader.ReadString();
                        tmp = reader.ReadString();
                        tmp = reader.ReadString();
                        _disc5 = reader.ReadString();
                        _disc10 = reader.ReadString();
                        _disc14 = reader.ReadString();
                    
                    }
                }
            }
            if(age > 14) return Price;
            if(age > 10) return Price * (1 - Double.Parse(_disc14)/100);
            if(age > 5) return Price * (1 - Double.Parse(_disc10)/100);
            return Price * (1 - Double.Parse(_disc5)/100);
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
    }
}
