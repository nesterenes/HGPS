using System.Collections.Generic;
using System.Linq;
using HGPS.Data.ModelsEF;

namespace HGPS.Data
{
    public class CustomerRepository : BaseRepository
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationRepository"/> class.
        /// </summary>
        /// <param name="databaseContext">The database context.</param>
        public CustomerRepository(HGPS_Entities databaseContext)
            : base(databaseContext)
        {
        }
        #endregion

        public IQueryable<Customer> GetCustomers()
        {
            return this.DbContext.Customers;
        }
    }
}