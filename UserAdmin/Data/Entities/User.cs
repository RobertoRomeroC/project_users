using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserAdmin.Data.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Mail { get; set; }
        public string Users { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public string Sex { get; set; }
    }
}
