using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Blogapp.Models
{
    public class BlogPost
    {
        [Key]
        public int ID { get; set; }
        public string blogTitle { get; set; }
        public string content { get; set; }
        public DateTime blogDate { get; set; }
    }
}
