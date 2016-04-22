namespace HGPS.Data
{
    using HGPS.Data.ModelsEF;

    public class BaseRepository
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository"/> class.
        /// </summary>
        /// <param name="databaseContext">The database context.</param>
        public BaseRepository(HGPS_Entities databaseContext)
        {
            this.DbContext = databaseContext;
        }

        #endregion Constructors

        #region Protected Properties

        /// <summary>
        /// Gets the database context.
        /// </summary>
        protected HGPS_Entities DbContext { get; private set; }

        #endregion Protected Properties
    }
}