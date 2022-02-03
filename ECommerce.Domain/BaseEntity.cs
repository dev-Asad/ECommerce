using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
