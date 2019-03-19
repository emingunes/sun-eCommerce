using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entity
{
    public class User : EntityBase
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Password { get; set; }

        public string TCKN { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public virtual IEnumerable<UserAddress> UserAddress { get; set; }

    }
}
