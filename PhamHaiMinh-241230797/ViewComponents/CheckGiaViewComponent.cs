using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhamHaiMinh_241230797.Models;

namespace PhamHaiMinh_241230797.ViewComponents
{
    public class CheckGiaViewComponent:ViewComponent
    {
        private readonly QlnhaSachContext _context;
        public CheckGiaViewComponent(QlnhaSachContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var saches = await _context.Saches.Where(s => s.Gia >= 100).ToListAsync();
            return View(saches);
        }
    }
}
