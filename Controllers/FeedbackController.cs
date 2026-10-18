
using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Models;
using System.Collections.Generic;

namespace ProductCatalog.Controllers
{
    public class FeedbackController : Controller
    {
        private static readonly List<Feedback> feedbackList = new();
        private static int nextId = 1;

        [HttpGet]
        public IActionResult Index()
        {
            return View(feedbackList);
        }

        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            if (!ModelState.IsValid)
            {
                return View(feedbackList);
            }

            feedback.Id = nextId++;
            feedbackList.Add(feedback);

            return RedirectToAction(nameof(Index));
        }
    }
}
