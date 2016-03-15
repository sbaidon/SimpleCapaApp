using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleCapaApp.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [Required]
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        public Status Status { get; set; }

    }

    public enum Status
    {
        New,
        Started,
        Completed
    }
}