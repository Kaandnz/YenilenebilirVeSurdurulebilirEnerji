using Microsoft.AspNetCore.Mvc;
using Bloggie.Web.Models.ViewModels;
using Bloggie.Web.Repositories;

namespace Bloggie.Web.Controllers
{
    public class TopicsController : Controller
    {
        private readonly IBlogPostRepository blogPostRepository;

        public TopicsController(IBlogPostRepository blogPostRepository)
        {
            this.blogPostRepository = blogPostRepository;
        }

        public async Task<IActionResult> WaterEnergy()
        {
            var blogPosts = await blogPostRepository.GetByTagAsync("Water Energy");
            return View(blogPosts);
        }


        public async Task<IActionResult> WindEnergy()
        {
            var blogPosts = await blogPostRepository.GetByTagAsync("Wind Energy");
            return View(blogPosts);
        }

        public async Task<IActionResult> SolarEnergy()
        {
            var blogPosts = await blogPostRepository.GetByTagAsync("Solar Energy");
            return View(blogPosts);
        }

        public async Task<IActionResult> GeothermalEnergy()
        {
            var blogPosts = await blogPostRepository.GetByTagAsync("Geothermal Energy");
            return View(blogPosts);
        }

        public async Task<IActionResult> BiomassEnergy()
        {
            var blogPosts = await blogPostRepository.GetByTagAsync("Biomass Energy");
            return View(blogPosts);
        }

        public async Task<IActionResult> FutureEnergy()
        {
            var blogPosts = await blogPostRepository.GetByTagAsync("Future Energy");
            return View(blogPosts);
        }
    }
}
