using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristСenterLibrary.Entity
{
    public class EventUser
    {
        private static ApplicationContext db = ContextManager.db;
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string? Middlename { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public EventUser()
        {
        }

        public EventUser(string Surname,  string Name, string? Middlename, string phone, string Address)
        {
            this.Surname = Surname;
            this.Middlename = Middlename;
            this.Name = Name;
            this.Phone = phone;
            this.Address = Address;
        }
        public bool Add()
        {
            try
            {
                db.EventUser.Add(this);
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
        public static User? GetUserByID(int id)
        {
            return db.User.FirstOrDefault(u => u.ID == id);
        }
    }
}
