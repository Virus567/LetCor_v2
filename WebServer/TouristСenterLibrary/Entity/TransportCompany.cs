using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace TouristСenterLibrary.Entity
{
    public class TransportCompany
    {
        private static ApplicationContext db = ContextManager.db;
        public int ID { get; set; }
        [Required] public string Name { get; set; }
        [MaxLength(15)] [Required] public string PhoneNumber { get; set; }

        public TransportCompany()
        {

        }
        public TransportCompany(string Name, string PhoneNumber)
        {
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
        }

        public bool Add()
        {
            try
            {
                db.TransportCompany.Add(this);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<string> GetCompanyes()
        {
            return db.TransportCompany.Select(x => x.Name).ToList();
        }

        public static TransportCompany? GetCompanyByName(string name)
        {
            return db.TransportCompany.Where(s=>s.Name == name).FirstOrDefault();
        }
    }
}
