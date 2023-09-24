using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace TouristСenterLibrary.Entity
{
    public class Transport
    {
        private static ApplicationContext db = ContextManager.db;
        public int ID { get; set; }
        [Required] public string  Brand { get; set; }
        [Required] public string DiagnosticCardNumber { get; set; }
        [MaxLength(15)] [Required] public string CarNumber { get; set; }
        [Required] public DateTime DateDiagnosticCard { get; set; }
        public string DateDiagnosticCardStr { get; set; }
        [Required] public bool IsRemoved { get; set; }
        [Required] public int SeatCount { get; set; }

        public Transport()
        {
            
        }

        public Transport(string Brand, string CarNumber, string DiagnosticCardNumber, DateTime DateDiagnosticCard, int SeatCount)
        {
            this.Brand = Brand;
            this.CarNumber = CarNumber;
            this.DateDiagnosticCard = DateDiagnosticCard;
            this.DateDiagnosticCardStr = DateDiagnosticCard.ToString("d");
            this.DiagnosticCardNumber = DiagnosticCardNumber;
            this.SeatCount = SeatCount;
            this.IsRemoved = false;
        }

        public bool Add()
        {
            try
            {
                db.Transport.Add(this);
                db.SaveChanges();
                return true;
            }
            catch
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

        public void RemoveTransport()
        {
            this.IsRemoved = true;
            db.SaveChanges();
        }
        public void RestorTransport()
        {
            this.IsRemoved = false;
            db.SaveChanges();
        }
        
        public static Transport GetTransportByID(int transportId)
        {
            return db.Transport.Where(t => t.ID == transportId).FirstOrDefault();
        }

        public class TransportView
        {
            public int ID { get; set; }
            public string  Brand { get; set; }
            public string CarNumber { get; set; }
            public bool IsSelected { get; set; }
        }

        public static List<TransportView> GetTransportViews()
        {
            return (from t in db.Transport
                select new TransportView()
                {
                    ID = t.ID,
                    Brand = t.Brand,
                    CarNumber = t.CarNumber,
                    IsSelected = false
                }).ToList();
        }

        public static List<Transport> GetAllTransport()
        {
            return  db.Transport.ToList();
        }
        public static List<Transport> GetTransportWithOutRemoved()
        {
            return  db.Transport.Where(t=>!t.IsRemoved).ToList();
        }

        public static List<string> GetTransportsString()
        {
            return db.Transport.Select(t => t.Brand).ToList();
        }

        public static Transport? GetTransportByBrand(string brand)
        {
            return db.Transport.FirstOrDefault(t => t.Brand == brand);
        }
    }
}
