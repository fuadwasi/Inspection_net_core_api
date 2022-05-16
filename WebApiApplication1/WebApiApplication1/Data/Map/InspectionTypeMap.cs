using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiApplication1.Data.Mapping;
using WebApiApplication1.Domains;

namespace WebApiApplication1.Data.Map
{
    public class InspectionTypeMap : EntityTypeConfiguration<InspectionType>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<InspectionType> builder)
        {
            builder.HasKey(inspection => inspection.Id);
            
            base.Configure(builder);
        }
    }
}
