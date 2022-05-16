using System.ComponentModel.DataAnnotations;

namespace WebApiApplication1.Domains
{
    public class Inspection :BaseEntity
    {
        [StringLength(20)] 
        public string Status { get; set; } = string.Empty;

        [StringLength(200)] 
        public string Comments { get; set; } = string.Empty;

        public int InspectionTypeId { get; set; }

        public InspectionType? InspectionType { get; set; }
    }
}
