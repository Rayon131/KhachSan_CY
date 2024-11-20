using AppData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text;

namespace AppView.Controllers
{
    public class PhonggController : Controller
    {
        private readonly HotelDbContext _db;
        public PhonggController(HotelDbContext context)
        {
            _db = context;
        }
		public async Task<IActionResult> Index()
		{
			return View(await _db.Phongs.ToListAsync());
		}
	}
}