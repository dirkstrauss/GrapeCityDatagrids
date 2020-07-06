using GrapeCity.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapeCity.Data
{
    public class JsonCityData : ICityData
    {
        List<City> _cities;

        public JsonCityData()
        {
            //var jsonPath = @"C:\[PATH_TO_FILE]\cities.json"; // JSON file included in GrapeCity.Data project.
            //_cities = JsonConvert.DeserializeObject<List<City>>(File.ReadAllText(jsonPath));

            _cities = new List<City>()
            {
                new City { Id = 1, CityName = "Cape Town", AccentCity = "Cape Town", ProvinceName = Province.WesternCape, Latitude = -33.918861, Longitude = 18.423300 },
                new City { Id = 2, CityName = "Port Elizabeth", AccentCity = "Port Elizabeth", ProvinceName = Province.EasternCape, Latitude = -33.991360, Longitude = 25.656912 },
                new City { Id = 3, CityName = "Durban", AccentCity = "Durban", ProvinceName = Province.KwaZuluNatal, Latitude = -29.883333, Longitude = 31.049999 }
            };
        }

        public IEnumerable<City> GetCityByName(string name = null)
        {
            return string.IsNullOrEmpty(name)
                ? _cities.OrderBy(x => x.CityName)
                : _cities
                    .Where(x => x.CityName.StartsWith(name))
                    .OrderBy(x => x.CityName);
        }

        public City GetById(int Id)
        {
            return _cities.SingleOrDefault(c => c.Id == Id);
        }
    }
}
