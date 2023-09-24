using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace TouristСenterLibrary.Entity
{
    public class Instructor : Human
    {
        private static ApplicationContext db = ContextManager.db;
        public int ID { get; set; }
        [Required] public bool IsRemoved { get; set; }

        

        public List<InstructorGroup> InstructorGroups { get; set; } = new List<InstructorGroup>();

        public Instructor()
        {
        }
        public Instructor(string Surname,string Name,string Middlename, 
                          string PhoneNumber) : base(Surname, Name, Middlename, PhoneNumber)
        {
            IsRemoved = false;
        }

        public bool Add()
        {
            try
            {
                db.Instructor.Add(this);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public class InstructorView
        {
            public int ID { get; set; }
            public string Surname { get; set; }
            public string Name { get; set; }
            public string Middlename { get; set; }
            public string InstructorTelefonNumber { get; set; }
            public bool InHike { get; set; }
            public string Image { get; set; }
            public string Discription { get; set; }
            public bool IsRemoved { get; set; }

        }
        public static List<InstructorView> GetInstructors()
        {
            return (from i in db.Instructor
                    select new InstructorView()
                    {
                        ID = i.ID,
                        Surname = i.Surname,
                        Name = i.Name,
                        Middlename = i.Middlename,
                        InstructorTelefonNumber = i.PhoneNumber,
                        InHike = false,
                        IsRemoved =i.IsRemoved
                    }).ToList();
        }
        
        public void RemoveInstructor()
        {
            this.IsRemoved = true;
            db.SaveChanges();
        }

        public void RestorInstructor()
        {
            this.IsRemoved = false;
            db.SaveChanges();
        }
        public static Instructor GetInstructorByID(int id)
        {
            return db.Instructor.Include(i => i.InstructorGroups).Where(i => i.ID == id).FirstOrDefault();
        }

        public static List<InstructorView> GetInstructorViewsByHikeID(int hikeId)
        {
            List<int> intList = new List<int>();
            InstructorGroup instructorGroup =InstructorGroup.GetInstructorGroupByHikeID(hikeId);
            foreach (var ii in instructorGroup.InstructorsList)
            {
                intList.Add(ii.ID);
            }  
            List<InstructorView> list = Instructor.GetInstructorViewsByListID(intList);
            return list;
        }

        public static List<string> GetFullNameInstructorsByHikeID(int hikeId)
        {
            List<InstructorView> list = Instructor.GetInstructorViewsByHikeID(hikeId);
            string str;
            List<string> strlist = new List<string>();
            foreach(InstructorView i in list)
            {
                str = $"{i.Surname} {i.Name} ";
                if (i.Middlename != null)
                    str += $"{i.Middlename} ";
                str += $"{i.InstructorTelefonNumber}";
                strlist.Add(str);
            }
            return strlist;
        }

        public static List<InstructorView> GetInstructorViewsByListID(List<int> instructorsID)
        {
            List<InstructorView> instructors= new List<InstructorView>();
            foreach(int instructorId in instructorsID)
            {
                instructors.Add((from i in db.Instructor
                    where i.ID == instructorId
                    select new InstructorView()
                    {
                        ID = instructorId,
                        Surname = i.Surname,
                        Name = i.Name,
                        Middlename = i.Middlename,
                        InstructorTelefonNumber = i.PhoneNumber,
                    }).FirstOrDefault());
            }
            return instructors;
        }
    }
}
