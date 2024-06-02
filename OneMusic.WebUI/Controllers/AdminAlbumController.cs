using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OneMusic.BusinessLayer.Abstract;
using OneMusic.EntityLayer.Entities;

namespace OneMusic.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminAlbumController : Controller
    {
        private readonly IAlbumService _albumService;
        private readonly ICategoryService _categoryService;
        private readonly UserManager<AppUser> _userManager;

        public AdminAlbumController(IAlbumService albumService, ICategoryService categoryService, UserManager<AppUser> userManager)
        {
            _albumService = albumService;
            _categoryService = categoryService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _albumService.TGetAlbumswithArtist();
            return View(values);
        }


        public IActionResult DeleteAlbum(int id)
        {
            _albumService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task <IActionResult> CreateAlbum()
        {
            var cat = _categoryService.TGetList();
            var catList = cat.Select(x=> new SelectListItem
            {
                Value = x.CategoryId.ToString(),
                Text = x.CategoryName
            }).ToList();
            ViewBag.CatList = catList;



            var artists = await _userManager.GetUsersInRoleAsync("Artist");
            ViewBag.Singers = artists.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = $"{a.Name} {a.Surname}"
            }).ToList();

            return View();
        }
        [HttpPost]
        public IActionResult CreateAlbum(Album album)
        {
            _albumService.TCreate(album);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateAlbum(int id)
        {
            var cat = _categoryService.TGetList();
            var catList = cat.Select(x => new SelectListItem
            {
                Value = x.CategoryId.ToString(),
                Text = x.CategoryName
            }).ToList();
            ViewBag.CatList = catList;



            var artists = await _userManager.GetUsersInRoleAsync("Artist");
            ViewBag.Singers = artists.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = $"{a.Name} {a.Surname}"
            }).ToList();

            var values = _albumService.TGetById(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult UpdateAlbum(Album album)
        {
             _albumService.TUpdate(album);
            return RedirectToAction("Index");

        }
    }
}
