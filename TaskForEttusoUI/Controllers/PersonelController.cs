using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModel;
using CleanArchitecture.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskForEttusoUI.Controllers
{
    public class PersonelController : Controller
    {
        private readonly IPersonalService _personalService = null;
        private readonly IPhoneService _phoneService = null;
        public PersonelController(IPersonalService personalService,IPhoneService phoneService)
        {
            _personalService = personalService;
            _phoneService = phoneService;
        }
        public IActionResult ListPersonal()
        {
            //var phoneNumber = "5";
            //ViewData["PhoneNumbers"] = phoneNumber;
            var result = _personalService.GetPersonalDetails();
            return View(result);
        }
        [HttpGet]
        public IActionResult AddPersonal()
        {
            ViewBag.PhoneNumbers = _phoneService.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult AddPersonal(PersonalViewModel model)
        {
            _personalService.AddWithPhoneNumbers(model);
            return RedirectToAction("AddPersonal");
        }
        public IActionResult DeletePersonal(int id)
        {
            _personalService.Delete(id);
            return RedirectToAction("ListPersonal");
        }
        [HttpGet]
        public IActionResult UpdatePersonal(int id)
        {
            var result = _personalService.GetById(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult UpdatePersonal(PersonalViewModel model)
        {
            var result = _personalService.GetById(model.Id);
            result.Name = model.Name;
            result.Surname = model.Surname;
            result.Email = model.Email;
            result.BirthDay = model.BirthDay;
            _personalService.Update(result);
            return RedirectToAction("ListPersonal");
        }

    }
}
