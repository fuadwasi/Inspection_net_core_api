using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiApplication1.Data.Mapping;
using WebApiApplication1.Domains;

namespace WebApiApplication1.Data.Map
{
    public class InspectionMap : EntityTypeConfiguration<Inspection>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<Inspection> builder)
        {
            builder.HasKey(inspection => inspection.Id);

            builder.Property(inspection => inspection.Comments).HasMaxLength(1000);
            builder.Property(inspection => inspection.Status).HasMaxLength(1000);
            builder.HasOne(inspection => inspection.InspectionType)
                .WithMany()
                .HasForeignKey(inspection => inspection.InspectionTypeId);
            
            base.Configure(builder);
        }
    }
}
