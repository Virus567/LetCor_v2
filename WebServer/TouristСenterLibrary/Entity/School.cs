using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace TouristСenterLibrary.Entity
{
    public class School
    {

        private static ApplicationContext db = ContextManager.db;
        [Required]public int ID { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Address { get; set; }
        [Required] public bool IsSchool { get; set; }

        public static List<School> GetSchools()
        {
            return db.School.ToList();
        }
        public bool Add()
        {
            try
            {
                db.School.Add(this);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
