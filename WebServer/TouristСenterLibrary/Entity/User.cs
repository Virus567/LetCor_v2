﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristСenterLibrary.Entity
{
    public class User : Human
    {
        private static ApplicationContext db = ContextManager.db;
        public int ID { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public DateTime DateOfB { get; set; }
        public string? NameOfCompany { get; set; }
        
        public string? AddressOrg { get; set; }
        public string? OgrnIP { get; set; } 

        public User()
        {
        }

        public User(string NameOfCompany, string Surname, string Name, string PhoneNumber, DateTime DateOfB)
        {
            this.NameOfCompany = NameOfCompany;
            this.Surname = Surname;
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
        }
        public User(string NameOfCompany, string Surname, string Name, string PhoneNumber, DateTime DateOfB, string Address)
        {
            this.NameOfCompany = NameOfCompany;
            this.Surname = Surname;
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
        }

        public User(string NameOfCompany, string Surname, string Name, string Middlename,
            string PhoneNumber, DateTime DateOfB) : base(Surname, Name, Middlename, PhoneNumber)
        {
            this.NameOfCompany = NameOfCompany;
            this.DateOfB = DateOfB;
        }
        public User(string NameOfCompany, string Surname, string Name, string Middlename,
            string PhoneNumber, DateTime DateOfB, string Address) : base(Surname, Name, Middlename, PhoneNumber)
        {
            this.NameOfCompany = NameOfCompany;
            this.DateOfB = DateOfB;
            this.Address = Address;
        }
        public bool Add()
        {
            try
            {
                db.User.Add(this);
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

        public static User GeUserAuth(string login, string password)
        {
            return db.User.FirstOrDefault(x => x.Login == login && x.Password == password);
        }

        public static User? GetUserByLogin(string login)
        {
            return db.User.FirstOrDefault(u => u.Login == login);
        }
        public static User? GetUserByID(int id)
        {
            return db.User.FirstOrDefault(u => u.ID == id);
        }

        public User(string? NameOfCompany, string Surname, string Name, string PhoneNumber) : base(Surname, Name, PhoneNumber)
        {
            this.NameOfCompany = NameOfCompany;
        }

        public string GetCompanyNameForHike()
        {
            string tmp;
            if (NameOfCompany != null)
                tmp = $"{NameOfCompany}";
            else
            {
                tmp = "Сборная";
            }
            return tmp;
        }
        public string GetCompanyNameForOrder()
        {
            string tmp;
            if (NameOfCompany != null)
                tmp = $"{NameOfCompany}";
            else
            {
                tmp = $"{Surname} {Name.Substring(0, 1)}.";
                if (Middlename != null) tmp += $" {Middlename.Substring(0, 1)}.";
            }
            return tmp;
        }

        public string GetShortName()
        {
            string fullName = $"{Surname} {Name.Substring(0, 1)}.";
            if (Middlename != null) fullName += $" {Middlename.Substring(0, 1)}.";
            return fullName;
        }
        
        public static bool IsHasUser(string phoneNumber)
        {
            return db.User.Any(u => u.PhoneNumber == phoneNumber);
        }

        public static User? GetUserByPhoneNumber(string phoneNumber)
        {
            return db.User.Where(u => u.PhoneNumber == phoneNumber).FirstOrDefault();
        }

    }
}
