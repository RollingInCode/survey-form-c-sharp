using Microsoft.AspNetCore.Mvc;
using survey_form_asp_net.Models;

namespace survey_form_asp_net.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Survey());
        }

        [HttpPost]
        public IActionResult Index(Survey survey)
        {
            if (ModelState.IsValid)
            {
                // You can store the survey results into a database here.
                // For simplicity, we just return the Thanks view.

                return View("Thanks", survey);
            }

            return View(survey);
        }
    }
}
