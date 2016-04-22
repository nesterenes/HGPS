using System.Collections.Generic;
using System.Linq;
using HGPS.Data.ModelsEF;

namespace HGPS.Data
{
    public class LocationRepository : BaseRepository
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationRepository"/> class.
        /// </summary>
        /// <param name="databaseContext">The database context.</param>
        public LocationRepository(HGPS_Entities databaseContext)
            : base(databaseContext)
        {
        }
        #endregion

        public IQueryable<Location> GetLocations()
        {
            return this.DbContext.Locations
                .Where(x => x.IsActive == 1);
        }
    }
}