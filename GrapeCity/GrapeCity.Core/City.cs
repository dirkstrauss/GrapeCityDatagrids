using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapeCity.Core
{
    public class City : IModelObject
    {
        public int Id { get; set; }

        public string CityName { get; set; }

        public string AccentCity { get; set; }

        public Province ProvinceName { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }        
    }
}