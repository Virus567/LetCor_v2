using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristСenterLibrary
{
    public class TmpJsonClass
    {
        public class Feature
        {
            public class MyClass
            {
                public class MetaData
                {
                    public string name { get; set; }
                    public string address { get; set; }
                }

                public MetaData CompanyMetaData { get; set; }
            }
            public MyClass properties { get; set; }
        }
        public List<Feature> features { get; set; }
        
    }
}
