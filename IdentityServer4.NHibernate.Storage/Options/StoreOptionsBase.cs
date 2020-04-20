namespace IdentityServer4.NHibernate.Options
{
    /// <summary>
    /// Base class for database configuration options.
    /// </summary>
    public abstract class StoreOptionsBase
    {
        /// <summary>
        /// Gets or sets the default schema
        /// </summary>
        /// <value>
        /// The default schema.
        /// </value>
        public string DefaultSchema { get; set; } = null;
    }
}
