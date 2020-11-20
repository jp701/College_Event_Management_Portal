using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using CoreApplication2.Data;
using CoreApplication2.Models;
using CoreApplication2.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreApplication2.Views
{
    [Authorize(Roles="Admin")]
    //[Authorize(Policy ="AdminRole")]
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEventRepository _eventRepository;
        private readonly IProgramRepository _programRepository;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IRegEventRepository _regEventRepository;

        public AdminController(UserManager<ApplicationUser> userManager,IEventRepository eventRepository,IProgramRepository programRepository, IRegEventRepository regEventRepository,IHostingEnvironment hostingEnvironment)
        {
            _userManager = userManager;
            _eventRepository = eventRepository;
            _programRepository = programRepository;
            _hostingEnvironment = hostingEnvironment;
            _regEventRepository = regEventRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        /* Get Student Table Data */
        public IActionResult GetStudentList()
        {
            var users = _userManager.Users;
            ViewBag.count = 0;
            return View(users);
        }

        /* CRUD operations on Event*/
        [HttpGet]
        public IActionResult AddEvent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEvent(EventCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFilename = null;
                if (model.Photo != null)
                {
                    string uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                    uniqueFilename= Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string filePath= Path.Combine(uploadFolder, uniqueFilename);
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                ClgEvent @event = new ClgEvent
                {
                    Title = model.Title,
                    Category = model.Category,
                    Date = model.Date,
                    Status = status.New,
                    Venue = model.Venue,
                    Description = model.Description,
                    PhotoPath = uniqueFilename
                };
                _eventRepository.AddEvent(@event);
                return RedirectToAction("EventDetails", new { id = @event.Id, updated=false });
            }
            return View();
        }

        public IActionResult EventDetails(int Id,bool updated)
        {
            if (updated)
            {
                ViewBag.Msg = "Event details updated successfully !!";
            }
            ClgEvent clgEvent = _eventRepository.GetEvent(Id);
            if (clgEvent == null)
            {
                Response.StatusCode = 404;
                return View("EventNotFound", Id);
            }
            return View(clgEvent);
        }

        public IActionResult ViewEvents()
        {
            var model = _eventRepository.GetAllEvents();
            return View(model);
        }

        [HttpGet]
        public ViewResult UpdateEvent(int Id)
        {
            ClgEvent clgEvent = _eventRepository.GetEvent(Id);
            ClgEvent newEvent = new ClgEvent
            {
                Id = clgEvent.Id,
                Title= clgEvent.Title,
                Category= clgEvent.Category,
                Status= clgEvent.Status,
                Date= clgEvent.Date,
                Description= clgEvent.Description,
                Venue= clgEvent.Venue
            };
            return View(newEvent);
        }

        [HttpPost]
        public IActionResult UpdateEvent(ClgEvent model)
        {
            if (ModelState.IsValid)
            {
                ClgEvent clgEvent = _eventRepository.GetEvent(model.Id);
                clgEvent.Title = model.Title;
                clgEvent.Category = model.Category;
                clgEvent.Status = model.Status;
                clgEvent.Date = model.Date;
                clgEvent.Description = model.Description;
                clgEvent.Venue = model.Venue;
                ClgEvent updatedEvent = _eventRepository.UpdateEvent(clgEvent);
                return RedirectToAction("EventDetails", new { id =model.Id, updated=true });
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult DeleteEvent(int Id)
        {
            ClgEvent clgEvent = _eventRepository.GetEvent(Id);
            if (clgEvent == null)
            {
                Response.StatusCode = 404;
                return View("EventNotFound", Id);
            }
            return View(clgEvent);
        }

        [HttpPost,ActionName("DeleteEvent")]
        public IActionResult DeleteEventConfirmed(int Id)
        {
            ClgEvent clgEvent = _eventRepository.GetEvent(Id);
            _eventRepository.DeleteEvent(clgEvent.Id);
            return RedirectToAction("ViewEvents");
        }

        /*CRUD operations on Program*/
        [HttpGet]
        public IActionResult AddProgram()
        {
            var events = _programRepository.GetAllEvents().Where(e=>e.Status==0);
            ViewBag.EventId = new SelectList(events, "Id", "Title");
            return View();
        } 

        [HttpPost]
        public IActionResult AddProgram(EventProgram program)
        {
            if (ModelState.IsValid)
            {
                EventProgram newProg = _programRepository.AddProgram(program);
                return RedirectToAction("ProgramDetails", new { Id = newProg.Id, updated=false});
            }
            return View();
        }

        public IActionResult ProgramDetails(int Id, bool updated)
        {
            if (updated)
            {
                ViewBag.Msg = "Program details updated successfully !!";
            }
            var prog = _programRepository.GetProgram(Id);
            if (prog == null)
            {
                Response.StatusCode = 404;
                ViewBag.ErrorMsg = "Program Not Found with Id: " + Id;
            }
            return View(prog);
        }

        public IActionResult ViewPrograms()
        {
            var model = _programRepository.GetAllPrograms();
            return View(model);
        }

        [HttpGet]
        public IActionResult UpdateProgram(int Id)
        {
            var prog = _programRepository.GetProgram(Id);
            var events = _programRepository.GetAllEvents().Where(e => e.Status == 0);
            ViewBag.EventId = new SelectList(events, "Id", "Title",prog.EventId);
            return View(prog);
        }

        [HttpPost]
        public IActionResult UpdateProgram(EventProgram model)
        {
            if (ModelState.IsValid)
            {
                EventProgram prog = _programRepository.GetProgram(model.Id);
                prog.Title = model.Title;
                prog.Type = model.Type;
                prog.Venue = model.Venue;
                prog.StartTime = model.StartTime;
                prog.EndTime = model.EndTime;
                prog.EventId = model.EventId;
                _programRepository.UpdateProgram(prog); //reflect updated program in db
                return RedirectToAction("ProgramDetails", new { Id = prog.Id, updated = true });
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult DeleteProgram(int Id)
        {
            EventProgram prog = _programRepository.GetProgram(Id);
            if (prog == null)
            {
                Response.StatusCode = 404;
                ViewBag.ErrorMsg = "Program Not Found with Id: " + Id;
            }
            return View(prog);
        }

        [HttpPost,ActionName("DeleteProgram")]
        public IActionResult DeleteProgramConfirmed(int Id)
        {
            EventProgram prog = _programRepository.GetProgram(Id);
            _programRepository.DeleteProgram(prog.Id);
            return RedirectToAction("ViewPrograms");
        }

        /* Report for Done and Registered Events */
        public IActionResult GetEventReport()
        {
            var model = _eventRepository.GetDoneEvents();
            return View(model);
        }

        public IActionResult GetRegEventReport()
        {
            var model = _regEventRepository.GetAllRegEvents();
            return View(model);
        }
    }
}