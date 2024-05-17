using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("[UserRole]")]
    public class UserRole{
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}