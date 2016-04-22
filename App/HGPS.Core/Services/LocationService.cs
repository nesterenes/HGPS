using HGPS.Data;
using HGPS.Data.ModelsEF;
using System.Collections.Generic;
using System.Linq;

namespace HGPS.Core.Services
{
    public class LocationService
    {
        private LocationRepository repo()
        {
            HGPS_Entities dbContext = new HGPS_Entities();
            LocationRepository repo = new LocationRepository(dbContext);
            return repo;
        }

        public List<Location> GetLocations(int userId)
        {
            var rtn = this.repo().GetLocations().ToList();

            return rtn;
        }
    }
}