using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;

namespace MyCompany.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageIndex"));
        }

       /*
        public IActionResult Contacts()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageContacts"));
        }*/

        public IActionResult Protocols()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageProtocols"));
        }

        public IActionResult NPA()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageNPA"));
        }

        public IActionResult MunControl()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageMunControl"));
        }
    }
}