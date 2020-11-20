using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApplication2.Data;
using CoreApplication2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoreApplication2.Controllers
{
    [Authorize(Policy="StudentRole")]
    public class StudentController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEventRepository _eventRepository;
        private readonly IProgramRepository _programRepository;
        private readonly IRegEventRepository _regEventRepository;

        public StudentController(UserManager<ApplicationUser> userManager, IEventRepository eventRepository, IProgramRepository programRepository,IRegEventRepository regEventRepository)
        {
            _userManager = userManager;
            _eventRepository = eventRepository;
            _programRepository = programRepository;
            _regEventRepository = regEventRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewEvents()
        {
            var model = _eventRepository.GetAllEvents();
            return View(model);
        }

        public IActionResult EventDetails(int Id)
        {
            ClgEvent clgEvent = _eventRepository.GetEvent(Id);
            if (clgEvent == null)
            {
                Response.StatusCode = 404;
                return View("EventNotFound", Id);
            }
            return View(clgEvent);
        }

        public IActionResult ViewPrograms(int Id)
        {
            var model = _programRepository.GetProgramsWithEventId(Id);
            ViewBag.EId = Id;
            if (model.Any())
            {
                ViewBag.ETitle = model.First().ClgEvent.Title;
            }
            return View(model);
        }

        public IActionResult AddRegEvent(int Id)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var model = _regEventRepository.GetRegEventsWithUserId(userId).Where(r => r.EventId == Id);
            if (model.Any())
            {
                return RedirectToAction("RegEventDetails", "Student", new { Id = model.First().Id , msg="You are already registered for this event !!"});
            }
            RegEvent regEvent = new RegEvent();
            regEvent.DateTime = DateTime.Now;
            regEvent.EventId = Id;
            regEvent.UserId = userId; //gets the current User-Id
            _regEventRepository.AddRegEvent(regEvent);
            return RedirectToAction("RegEventDetails", new { Id = regEvent.Id });
        }

        public IActionResult RegEventDetails(int Id, string msg) //Get the registered Event details with Id
        {
            if (!string.IsNullOrEmpty(msg))
            {
                ViewBag.ErrorMsg = msg;
            }
            ViewBag.Success = "You are registered for this event !!";
            RegEvent regEvent = _regEventRepository.GetRegEvent(Id);
            return View(regEvent);
        }

        public IActionResult RegEvents(int? Id)
        {
            if (Id!=null)
            {
                ViewBag.Id = Id;
            }
            var model = _regEventRepository.GetRegEventsWithUserId(_userManager.GetUserId(HttpContext.User));
            return View(model);
        }

        public IActionResult DeleteRegEvent(int Id)
        {
            _regEventRepository.DeleteRegEvent(Id);
            return RedirectToAction("RegEvents", new {Id= Id});
        }
    }
}