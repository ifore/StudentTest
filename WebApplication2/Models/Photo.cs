using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication2.Models.School;

namespace WebApplication2.Models
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }

        public string FilePath { get; set; }

        public byte[] Image { get; set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }

    }
}