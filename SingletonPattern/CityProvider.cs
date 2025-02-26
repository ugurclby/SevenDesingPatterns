using SingletonPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class CityProvider
    {
        private static CityProvider _instance;

        public static CityProvider Instance => _instance ?? (_instance = new CityProvider());

        private new List<City> Cities { get; set; }
        private CityProvider()
        {
            Cities = new List<City> {
                new City { CityName = "New York" },
                new City { CityName = "Los Angeles" },
                new City { CityName = "Chicago" },
                new City { CityName = "Houston" },
                new City { CityName = "Phoenix" },
                new City { CityName = "Philadelphia" },
                new City { CityName = "San Antonio" },
                new City { CityName = "San Diego" },
                new City { CityName = "Dallas" },
                new City { CityName = "San Jose" } 
            };
        } 

        public int CityCount() => Cities.Count; 

        public List<City> GetCities() => Cities;

    }
}
