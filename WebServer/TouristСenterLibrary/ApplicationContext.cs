using Microsoft.EntityFrameworkCore;
using System.IO;
using TouristСenterLibrary.Entity;

namespace TouristСenterLibrary
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Order> Order { get; set; }
        public DbSet<ApplicationType> ApplicationType { get; set; }
        public DbSet<CheckpointRoute> CheckpointRoute { get; set; }
        public DbSet<TouristGroup> TouristGroup { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Driver> Driver { get; set; }
        public DbSet<RoutePoint> RoutePoint { get; set; }
        public DbSet<EventUser> EventUser { get; set; }
        public DbSet<CountableEquipment> CountableEquipment { get; set; }
        public DbSet<CountableHikeEquipment> CountableHikeEquipment { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Hike> Hike { get; set; }
        public DbSet<Children> Children { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<InstructorGroup> InstructorGroup { get; set; }
        public DbSet<Participant> Participant { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Route> Route { get; set; }
        public DbSet<RouteHike> RouteHike { get; set; }
        public DbSet<Transport> Transport { get; set; }
        public DbSet<TransportCompany> TransportCompany { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<TypeEvent> TypeEvent { get; set; } 
        public DbSet<Event> Event { get; set; }
        public DbSet<Charter> Charter { get; set; }
        public DbSet<Contract> Contract { get; set; }
        public string DbPath { get; }
        private static string _path = Path.Combine(Directory.GetCurrentDirectory(), $"db.data");
        private static string _host = "localhost";
        

        public ApplicationContext(): this(GetDb())
        {
        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {
            //Database.EnsureCreated();
            Database.Migrate();
            new ContextManager(this);
        }

        public static string GetCurrentDerectory()
        {
            return Directory.GetCurrentDirectory();
        }

        readonly static StreamWriter stream = new StreamWriter("log.txt", true);
        public static DbContextOptions<ApplicationContext> GetDb()
        {
            if(File.Exists(_path))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(_path, FileMode.Open)))
                {
                    _host = reader.ReadString();
                    if (_host == "" || _host is null)
                    {
                        _host = "localhost";
                    }
                }
            }
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>().UseNpgsql($"Host={_host};Port=5432;Database=let_cor;Username=postgres;Password=123");
            optionsBuilder.LogTo(stream.WriteLine);
            return optionsBuilder.Options;
        }
        public static void InitDb()
        {
            new ApplicationContext(GetDb());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(File.Exists(_path))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(_path, FileMode.Open)))
                {
                    _host = reader.ReadString();
                }
            }
            optionsBuilder.UseNpgsql($"Host={_host};Port=5432;Database=let_cor;Username=postgres;Password=123");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Human>();
            modelBuilder.Entity<Role>(EntityConfigure.RoleConfigure);
            modelBuilder.Entity<ApplicationType>(EntityConfigure.ApplicationTypeConfigure);
            modelBuilder.Entity<TypeEvent>(EntityConfigure.TypeEventConfigure);
            modelBuilder.Entity<Driver>(EntityConfigure.DriverConfigure);
            modelBuilder.Entity<CheckpointRoute>(EntityConfigure.CheckpointRouteConfigure);
            modelBuilder.Entity<Route>(EntityConfigure.RouteConfigure);
            modelBuilder.Entity<Employee>(EntityConfigure.EmployeeConfigure);
            modelBuilder.Entity<User>(EntityConfigure.UserConfigure);
            modelBuilder.Entity<EventUser>(EntityConfigure.EventUserConfigure);
            modelBuilder.Entity<TransportCompany>(EntityConfigure.TransportCompanyConfigure);
            modelBuilder.Entity<Transport>(EntityConfigure.TransportConfigure);
            modelBuilder.Entity<Instructor>(EntityConfigure.InstructorConfigure);
            modelBuilder.Entity<Equipment>(EntityConfigure.EquipmentConfigure);
            modelBuilder.Entity<CountableEquipment>(EntityConfigure.CountableEquipmentConfigure);
            modelBuilder.Entity<School>(EntityConfigure.SchoolConfigure);
        }
        
    }

}
