using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMP.ApplicationContext;
using SMP.ApplicationContext.Entity;

namespace SMP.Web.Controllers
{
    public class ClickController : Controller
    {
        private readonly SMPContext _context;
        public ClickController(SMPContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Click()
        {
            if(_context.Set<Register>().Any(p => p.RegisterDate < DateTime.Now && p.RegisterDate > DateTime.Now.AddDays(-1)))
            {
                return Content("已签到");
            }
            else
            {
                var register = new Register(DateTime.Now);
                await _context.Set<Register>().AddAsync(register);
                await _context.SaveChangesAsync();
                return Content("签到成功");
            }
        }
    }
}