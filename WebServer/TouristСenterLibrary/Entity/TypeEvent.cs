using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace TouristСenterLibrary.Entity
{
    public class TypeEvent
    {
        private static ApplicationContext db = ContextManager.db;
        [Required] public int ID { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Description { get; set; }
        [Required] public string ShortName { get; set; }
        [Required] public string Shablon { get; set; }
        [Required] public bool IsRemoved { get; set; }


        public TypeEvent()
        {
            IsRemoved = false;
        }

        public static List<string> GetEvents()
        {
            return db.TypeEvent.Where(e=>!e.IsRemoved).Select(e => e.Name).ToList();
        }

        public static TypeEvent GetTypeEventByName(string name)
        {
            return db.TypeEvent.FirstOrDefault(e=>e.Name == name);
        }

        public bool Add()
        {
            try
            {
                db.TypeEvent.Add(this);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public void RemoveEvent()
        {
            this.IsRemoved = true;
            db.SaveChanges();
        }

        public void RestorInstructor()
        {
            this.IsRemoved = false;
            db.SaveChanges();
        }
        public static List<TypeEvent> GetTypeEvents()
        {
            return db.TypeEvent.ToList();
        }
    }
}
