using Calculator.Models;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        // Action to display the initial form with input fields for num1, num2, and operation type
        public ActionResult Index()
        {
            return View(new calc()); // Returns a new, empty calc model to the view
        }

        // POST: Calc
        // Action to handle the form submission, perform the calculation, and redisplay the form with the result
        [HttpPost]
        public ActionResult Index(calc model, string operation)
        {
            if (model != null)
            {
                model.SetOperation(operation); // Sets the operation type (add, sub, etc.)
            }
            return View(model); // Returns the calc model with the total property now reflecting the result of the operation
        }
    }
}
