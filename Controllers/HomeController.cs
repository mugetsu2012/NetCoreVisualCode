using System;
using Microsoft.AspNetCore.Mvc;
using NetCoreVisualCode.Models;
using System.Linq;

namespace NetCoreVisualCode.Controllers {
    
    public class HomeController: Controller
    {
        private IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;

            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good afternoon";
            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm() => View();

        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if(ModelState.IsValid)
            {
                _repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else 
            {
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            return View(_repository.Responses.Where(r => r.WillAttend ==  true));
        }
        
    }
}