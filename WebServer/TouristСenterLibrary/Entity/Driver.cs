using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TouristСenterLibrary.Entity;

public class Driver: Human
{
    private static ApplicationContext db = ContextManager.db;
    public int ID { get; set; }
    public string DriversLicenseNumber { get; set; }
    public string Categories { get; set; }
    public DateTime DateDriversLicense { get; set; }
    public double DriverExperienceD { get; set; }
    public bool IsRemoved { get; set; }

    public Driver()
    {
        IsRemoved = false;
    }
    public void RemoveDriver()
    {
        this.IsRemoved = true;
        db.SaveChanges();
    }

    public void RestorDriver()
    {
        this.IsRemoved = false;
        db.SaveChanges();
    }

    public Driver(string Surname, string Name, string? Middlename, string PhoneNumber, 
        string DriversLicenseNumber,string Categories,DateTime DateDriversLicense,double DriverExperienceD ): base(Surname, Name, Middlename, PhoneNumber)
    {
        this.DriversLicenseNumber = DriversLicenseNumber;
        this.Categories = Categories;
        this.DateDriversLicense = DateDriversLicense;
        this.DriverExperienceD = DriverExperienceD;
        this.IsRemoved = false;
    }
    public bool Add()
    {
        try
        {
            db.Driver.Add(this);
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
    public static Driver? GetDriverByID(int id)
    {
        return db.Driver.FirstOrDefault(u => u.ID == id);
    }

    public static List<Driver> GetDrivers()
    {
        return db.Driver.ToList();
    }
    public static List<Driver> GetDriversWithOutRemoved()
    {
        return db.Driver.Where(d=>!d.IsRemoved).ToList();
    }
    public string GetShortName()
    {
        string fullName = $"{Surname} {Name.Substring(0, 1)}.";
        if (Middlename != null) fullName += $" {Middlename.Substring(0, 1)}.";
        return fullName;
    }
    
    private static string[] GetSplitName(string fullName)
    {
        fullName = Regex.Replace(fullName, "[ ]+", " ");
        return fullName.Split(' ');
    }

    public static List<string> GetViewDrivers()
    {
        var drivers =  db.Driver.Where(d=>!d.IsRemoved).ToList();
        List<string> result = new List<string>();
        foreach (var driver in drivers)
        {
            result.Add(driver.GetShortName());
        }

        return result;
    }

    public static Driver GetDriverByShortName(string shortName)
    {
        var name = GetSplitName(shortName);
        return db.Driver.Where(d => d.Surname ==name[0]  && d.Name.Substring(0,1)+"."== name[1] && d.Middlename.Substring(0,1)+"."== name[2]).FirstOrDefault();
    }
    
}