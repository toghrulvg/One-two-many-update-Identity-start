using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using EntityFrameworkProject.Models;

namespace EntityFrameworkProject.ViewModels
{
    public class BlogEditVM
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Desc { get; set; }
        [Required]
        public List<IFormFile> Photos { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public Blog blog { get; set; }

        
    }
}
