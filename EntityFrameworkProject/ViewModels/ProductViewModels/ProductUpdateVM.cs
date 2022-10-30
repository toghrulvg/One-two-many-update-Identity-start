﻿using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkProject.ViewModels.ProductViewModels
{
    public class ProductUpdateVM
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Price { get; set; }
        [Required]
        public string Description { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public List<IFormFile> Photos { get; set; }
    }
}
