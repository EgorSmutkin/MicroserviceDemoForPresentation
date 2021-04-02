using System.ComponentModel.DataAnnotations;

namespace UserService.Database.Entities
{
    public class ApplicationUser
    {
        [Key]
        public int UserId {get; set; }
        public string Name {get; set; }
        public string Address {get; set; }
        public string Contact {get; set; }
    }
}
