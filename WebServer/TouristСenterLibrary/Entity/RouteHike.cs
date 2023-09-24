using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace TouristСenterLibrary.Entity
{
    public class RouteHike
    {
        private static ApplicationContext db = ContextManager.db;

        public int ID { get; set; }
        [Required] public Route Route { get; set; }
        public Transport StartBus { get; set; }
        public Transport? FinishBus { get; set;}
        public Transport? StartCargo { get; set; }
        public Transport? FinishCargo { get; set; }
        [Required] public Hike Hike { get; set; }

        public RouteHike()
        {
        }


        public RouteHike(Route Route, Hike Hike)
        {
            this.Route = Route;
            this.Hike = Hike;
        }


        public static bool Add(RouteHike routeHike)
        {
            try
            {
                db.RouteHike.Add(routeHike);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public static bool UpdateTransport(RouteHike routeHike, Transport startBus, Transport finishBus, Transport startCargo, Transport finishCargo)
        {
            try
            {
                routeHike.StartBus = startBus;
                routeHike.FinishBus = finishBus;
                routeHike.StartCargo = startCargo;
                routeHike.FinishCargo = finishCargo;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static RouteHike GetRouteHikeByHikeID(int hikeID)
        {
            var routeHike = db.RouteHike
                .Include(r=>r.StartBus)
                .Include(r => r.FinishBus)
                .Include(r => r.StartCargo)
                .Include(r => r.FinishCargo)
                .Include(r => r.Hike)
                .Include(r => r.Route)
                .Where(rh => rh.Hike.ID == hikeID).FirstOrDefault();
            return routeHike;
        }
    }

    
}
