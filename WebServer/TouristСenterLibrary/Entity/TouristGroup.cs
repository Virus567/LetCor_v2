using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace TouristСenterLibrary.Entity
{
    public class TouristGroup
    {
        private static ApplicationContext db = ContextManager.db;
        public int ID { get; set; }
        [Required] public int PeopleAmount { get; set; }
        [Required] public int ChildrenAmount { get; set; }
        [Required] public int ChildrenAmount5 { get; set; }
        [Required] public int ChildrenAmount10 { get; set; }
        [Required] public int ChildrenAmount14 { get; set; }
        [Required] public User User { get; set; }
        public List<Participant> ParticipantsList { get; set; }

        public TouristGroup()
        {
            ParticipantsList = new List<Participant>();
        }
        public TouristGroup(User User, int PeopleAmount,int ChildrenAmount, int ChildrenAmount5, int ChildrenAmount10, int ChildrenAmount14)
        {
            this.User = User;
            this.PeopleAmount = PeopleAmount;
            this.ChildrenAmount = ChildrenAmount;
            this.ChildrenAmount5 = ChildrenAmount5;
            this.ChildrenAmount10 = ChildrenAmount10;
            this.ChildrenAmount14 = ChildrenAmount14;
            ParticipantsList = new List<Participant>();
        }

        public  string GetFullName()
        {
            return User.GetFullName();
        }
        public static void Add(TouristGroup client)
        {
            db.TouristGroup.Add(client);
            db.SaveChanges();
        }
        public static void Update(TouristGroup client)
        {
            db.TouristGroup.Update(client);
            db.SaveChanges();
        }
        public string GetCompanyNameForHike()
        {
            return User.GetCompanyNameForHike();
        }
        public string GetCompanyNameForOrder()
        {
            return User.GetCompanyNameForOrder();
        }


        public static TouristGroup GetGroupByID(int groupId)
        {
            var client = db.TouristGroup.Where(c => c.ID == groupId).FirstOrDefault();
            db.Participant.Where(p => p.TouristGroupID == groupId).Load();
            return client;
        }
        public static TouristGroup GetGroupByOrderId(int orderId)
        {
            return (from c in db.TouristGroup
                    join o in db.Order on c.ID equals o.TouristGroup.ID
                    where o.ID == orderId
                    select c).FirstOrDefault();
        }

        public int GetChildren5()
        {
            int children = 0;
            foreach (var participant in ParticipantsList)
            {
                int age = DateTime.Now.Year - participant.User.DateOfB.Year;
                if (participant.User.DateOfB > DateTime.Now.AddYears(-age))
                    age--;
                if (age <= 5)
                {
                    children++;
                }
            }
            return children;
        }
        public int GetChildren10()
        {
            int children = 0;
            foreach (var participant in ParticipantsList)
            {
                int age = DateTime.Now.Year - participant.User.DateOfB.Year;
                if (participant.User.DateOfB > DateTime.Now.AddYears(-age))
                    age--;
                if (age > 5 && age<=10)
                {
                    children++;
                }
            }
            return children;
        }
        public int GetChildren14()
        {
            int children = 0;
            foreach (var participant in ParticipantsList)
            {
                int age = DateTime.Now.Year - participant.User.DateOfB.Year;
                if (participant.User.DateOfB > DateTime.Now.AddYears(-age))
                    age--;
                if (age > 10 && age <= 14)
                {
                    children++;
                }
            }
            return children;
        }
    }
}
