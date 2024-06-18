using bulky_Razor_temp.Data;
using bulky_Razor_temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace bulky_Razor_temp.Pages.Categories
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public Category Category { get; set; }
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public int Id { get; set; }
        public IActionResult OnGet(int id)
        {
            Category = _db.Categories.Find(id);
            if (Category == null)
            {
                RedirectToPage("Index");
            }

            return Page();


        }

        public IActionResult OnPost(int id)
        {
            var category = _db.Categories.Find(id);
            if (category == null)
            {
                return RedirectToPage("Index");
            }
            category.Name = Category.Name;
            category.DisplayOrder = Category.DisplayOrder;
            category.Description = Category.Description;
            _db.SaveChanges();

            TempData["success"] = "Record updated successfully";
            return RedirectToPage("Index");
        }
    }
}
