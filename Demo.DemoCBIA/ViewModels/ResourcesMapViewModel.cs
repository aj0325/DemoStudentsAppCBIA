using Demo.DemoCBIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DemoCBIA.ViewModels
{
        public class ResourcesMapViewModel : BaseViewModel
        {
            public Resources BuildingResources { get; }

            public ResourcesMapViewModel(string buildingName)
            {
                BuildingResources = GetResourcesForBuilding(buildingName);
            }

            private Resources GetResourcesForBuilding(string buildingName)
            {
                // Retrieve resources for the specified building
                // For demonstration purposes, let's assume some dummy data

                var resources = new Resources();

            // Add dummy restaurants
            resources.Restaurants.Add(new Restaurant { Name = "Bel Canto Paris", Location = new Location(48.856614, 3.352222) });
            resources.Restaurants.Add(new Restaurant { Name = "Restaurant Allard", Location = new Location(48.856614, 2.352222) });

            // Add hospitals
            resources.Hospitals.Add(new Hospital { Name = "Pitié Salpêtrière Hospital", Location = new Location(48.85341, 3.4588) });
            resources.Hospitals.Add(new Hospital { Name = "Robert-Debré Hospital", Location = new Location(48.25341, 3.3488) });

            return resources;
            }
        }
    

}
