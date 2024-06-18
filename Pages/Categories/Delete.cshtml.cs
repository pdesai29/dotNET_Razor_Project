using bulky_Razor_temp.Data;
using bulky_Razor_temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace bulky_Razor_temp.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Category Category { get; set; }


        public IActionResult OnGet(int id)
        {
            Category = _db.Categories.Find(id);
            if (Category == null)
            {
                return RedirectToPage("Index");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            var category = _db.Categories.Find(Category.Id);
            if (category == null)
            {
                return RedirectToPage("Index");
            }
            _db.Categories.Remove(category);
            _db.SaveChanges();
            TempData["success"] = "Record Deleted successfully";

            return RedirectToPage("Index");
        }
    }
}
