using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleCapaApp.Models
{
    public class File
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FileName { get; set; }
        [Required]
        public string ContentType { get; set; }
        [Required]
        public byte[] fileBytes { get; set; }
    }
}