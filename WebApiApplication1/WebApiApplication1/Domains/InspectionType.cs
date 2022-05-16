using System.ComponentModel.DataAnnotations;

namespace WebApiApplication1.Domains
{
    public class InspectionType :BaseEntity
    {
        [StringLength(20)]
        public string InspectionName { get; set; } = string.Empty;
    }
}
