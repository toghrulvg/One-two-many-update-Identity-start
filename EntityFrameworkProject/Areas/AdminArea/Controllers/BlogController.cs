using EntityFrameworkProject.Data;
using EntityFrameworkProject.Helpers;
using EntityFrameworkProject.Models;
using EntityFrameworkProject.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EntityFrameworkProject.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class BlogController : Controller
    {

        
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BlogController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index() => View(await _context.Blogs.Where(m => !m.IsDeleted).ToListAsync());

        [HttpGet]
        public IActionResult Create(int? id)
        {
            return View();


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogCreateVM blog)
        {
            if (!ModelState.IsValid) return View();

            foreach (var photo in blog.Photos)
            {
                if (!photo.CheckFileType("image/"))
                {
                    ModelState.AddModelError("Photo", "Please choose correct image type");
                    return View();
                }


                if (!photo.CheckFileSize(200))
                {
                    ModelState.AddModelError("Photo", "Please choose correct image size");
                    return View();
                }
            }

            foreach (var photo in blog.Photos)
            {
                string fileName = Guid.NewGuid().ToString() + "_" + photo.FileName;

                string path = Helper.GetFilePath(_env.WebRootPath, "img", fileName);

                await Helper.SaveFile(path, photo);

                Blog newBlog = new Blog
                {
                    Image = fileName,
                    Title = blog.Title,
                    Desc = blog.Desc,
                    Date = DateTime.Now
                };

                await _context.Blogs.AddAsync(newBlog);
            }
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Delete(int id)
        {
            Blog blog = await _context.Blogs
                .Where(m =>m.Id == id)
                .FirstOrDefaultAsync();

            if (blog == null) return NotFound();

            string path = Helper.GetFilePath(_env.WebRootPath, "img", blog.Image);

            Helper.DeleteFile(path);

            blog.IsDeleted = true;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            Blog blog = await _context.Blogs.FirstOrDefaultAsync(m => m.Id == id);

            if (blog == null) return NotFound();

            return View(blog);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            Blog blog = await _context.Blogs.FirstOrDefaultAsync(m => m.Id == id);

            if (blog is null) return NotFound();

            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, BlogEditVM blog)
        {
            Blog dbBlog = await _context.Blogs.FirstOrDefaultAsync(m => m.Id == id);

            if (blog.Photos != null)
            {
                foreach (var photo in blog.Photos)
                {
                    if (!photo.CheckFileType("image/"))
                    {
                        ModelState.AddModelError("Photo", "Please choose correct image type");
                        return View(blog);
                    }


                    if (!photo.CheckFileSize(500))
                    {
                        ModelState.AddModelError("Photo", "Please choose correct image size");
                        return View(blog);
                    }
                }


                //string oldPath = Helper.GetFilePath(_env.WebRootPath, "img", dbBlog.Image);
                //Helper.DeleteFile(oldPath);
                foreach (var photo in blog.Photos)
                {
                    string fileName = Guid.NewGuid().ToString() + "_" + photo.FileName;

                    string path = Helper.GetFilePath(_env.WebRootPath, "img", fileName);

                    await Helper.SaveFile(path, photo);

                    blog.Image = fileName;

                    dbBlog.Image = blog.Image;
                }
                

                
            }

            dbBlog.Title = blog.Title;
            dbBlog.Desc = blog.Desc;
            dbBlog.Date = DateTime.Now;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
    }

}
