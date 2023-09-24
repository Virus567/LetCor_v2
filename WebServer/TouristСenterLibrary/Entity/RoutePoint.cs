using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace TouristСenterLibrary.Entity;

public class RoutePoint
{
    private static ApplicationContext db = ContextManager.db;
    public int ID { get; set; }
    public string? Date { get; set; }
    [Required] public string Time { get; set; }
    [Required] public string Point { get; set; }
    [Required] public bool IsTargetPoint { get; set; }
    public int NumberString { get; set; }
    [Required] public Charter Charter { get; set; }
    public int CharterID { get; set; }

    public RoutePoint()
    {
       IsTargetPoint = false;
    }

    public RoutePoint(string? Date, string Time, string Point, bool IsTargetPoint)
    {
        this.Date = Date;
        this.Time = Time;
        this.Point = Point;
        this.IsTargetPoint = IsTargetPoint;
    }
    
    public bool Add()
    {
        try
        {
            db.RoutePoint.Add(this);
            db.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static List<RoutePoint> GetRoutePointsByCharterID(int id)
    {
        return db.RoutePoint.Where(r => r.Charter.ID == id).ToList();
    }
    
}