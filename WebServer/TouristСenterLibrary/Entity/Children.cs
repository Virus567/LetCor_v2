using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace TouristСenterLibrary.Entity
{
    public class Children
    {
        private static ApplicationContext db = ContextManager.db;
        public int ID { get; set; }
        [Required] public  string Fio { get; set; }
        [Required] public DateTime DateOfB { get; set; }
        [Required] public string NumberPhone { get; set; }
        [Required] public Charter Charter { get; set; }

        public Children()
        {
        }
        
        public Children(string Fio, DateTime DateOfB, string NumberPhone)
        {
            this.Fio = Fio;
            this.DateOfB = DateOfB;
            this.NumberPhone = NumberPhone;
        }
        
        public bool Add()
        {
            try
            {
                db.Children.Add(this);
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
    }
}