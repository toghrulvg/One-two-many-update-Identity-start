using EntityFrameworkProject.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkProject.ViewModels
{
    public class BlogCreateVM
    {
        [Required]
        
        public string Title { get; set; }
        [Required]
        public string Desc { get; set; }
        [Required]
        public List<IFormFile> Photos { get; set; }

        public string Image { get; set; }

        public DateTime Date { get; set; }

        public static implicit operator BlogCreateVM(Blog v)
        {
            throw new NotImplementedException();
        }
    }
}
