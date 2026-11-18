using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhamHaiMinh_241230797.Models;
using WebApplication1.Controllers;

namespace PhamHaiMinh_241230797.ViewComponents
{
    public class MenuViewComponent : ViewComponent {
        private readonly QlnhaSachContext _context;
        public MenuViewComponent(QlnhaSachContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var theloai = await _context.TheLoais.ToListAsync();
            return View(theloai);
        }
    }
}
