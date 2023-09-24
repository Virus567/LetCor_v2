using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristСenterLibrary.Entity
{
    public class Contract
    {
        private static ApplicationContext db = ContextManager.db;
        public int ID { get; set; }
        public Event Event { get; set; }
        public DateTime DateTime { get; set; }
        public string TypeContract { get; set; }
    }
}
