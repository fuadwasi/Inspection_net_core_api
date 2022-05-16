using System.ComponentModel.DataAnnotations;

namespace WebApiApplication1.Domains
{
    public class Status: BaseEntity
    {
        [StringLength(20)] 
        public string StatusOption { get; set; } = string.Empty;
    }
}
