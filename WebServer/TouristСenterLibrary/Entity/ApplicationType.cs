using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace TouristСenterLibrary.Entity
{
    public class ApplicationType
    {
        private static ApplicationContext db = ContextManager.db;
        public int ID { get; set; }
        [Required] public string Name { get; set; }

        public ApplicationType()
        {

        }
        public ApplicationType(string Name)
        {
            this.Name = Name;
        }

        public static ApplicationType GetIPType()
        {
            return db.ApplicationType.Where(a => a.ID == 2).First();
        }
        public static ApplicationType GetOOOType()
        {
            return db.ApplicationType.Where(a => a.ID == 3).First();
        }
        public static ApplicationType GetFamilyType()
        {
            return db.ApplicationType.Where(a => a.ID == 1).First();
        }
    }

}
