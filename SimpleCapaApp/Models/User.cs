using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SimpleCapaApp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public int AdministratorId { get; set; }

        [ForeignKey("AdministratorId")]
        public virtual Administrator Administrator { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }

    }
}