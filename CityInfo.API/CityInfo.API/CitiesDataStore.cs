using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }
        
        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York",
                    Description = "city",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "Park in the middle of the city"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "Tall tower"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Paris",
                    Description = "city",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Elf tower",
                            Description = "French"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Paris poi 2",
                            Description = "Paris poi2 desc"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Guilin",
                    Description = "Home",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Guilin poi 1",
                            Description = "Guilin poi 1 desc"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Guilin poi 2",
                            Description = "Guilin poi 2 desc"
                        }
                    }
                    
                }
            };
        }
    }
}
