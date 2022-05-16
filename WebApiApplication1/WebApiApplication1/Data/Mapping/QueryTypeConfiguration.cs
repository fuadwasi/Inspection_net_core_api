using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApiApplication1.Data.Mapping
{
    public class QueryTypeConfiguration<TEntity> : IMappingConfiguration, IEntityTypeConfiguration<TEntity> where TEntity : class
    {
        #region Utilities

        /// <summary>
        /// Developers can override this method in custom partial classes in order to add some custom configuration code
        /// </summary>
        /// <param name="builder">The builder to be used to configure the query</param>
        protected virtual void PostConfigure(EntityTypeBuilder<TEntity> builder)
        {
        }

        #endregion
        public void ApplyConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(this);
        }

        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            //add custom configuration
            PostConfigure(builder);
        }
    }
}
