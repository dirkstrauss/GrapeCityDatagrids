using GrapeCity.Core;
using System.Collections.Generic;

namespace GrapeCity.Data
{
    public interface ICityData
    {
        IEnumerable<City> GetCityByName(string name);
        City GetById(int Id);        
    }
}
