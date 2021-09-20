using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskForEttusoUI.Controllers
{
    public class PhoneController : Controller
    {
        private readonly IPhoneService _phoneService = null;

        public PhoneController(IPhoneService phoneService)
        {
            _phoneService = phoneService;
        }
        [HttpGet]
        public IActionResult AddPhone()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddPhone(PhoneViewModel phone)
        {
            await _phoneService.Add(phone);
            return RedirectToAction("AddPersonal", "Personel" );
        }

    }
}
