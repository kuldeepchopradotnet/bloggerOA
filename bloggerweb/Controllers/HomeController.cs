using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bloggerweb.Models;
using Boggerweb.Service;

namespace bloggerweb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostService _postService;
        public HomeController(IPostService postService) {
            _postService = postService;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<PostViewModel> model = new List<PostViewModel>();
            _postService.GetPosts().ToList().ForEach(p =>
            {
                PostViewModel post = new PostViewModel
                {
                    Id = p.Id,
                    Content =  p.Content
                  
                };
                model.Add(post);
            });
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
