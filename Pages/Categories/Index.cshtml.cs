using bulky_Razor_temp.Data;
using bulky_Razor_temp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace bulky_Razor_temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public List<Category> CategoryList { get; set; }

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}
