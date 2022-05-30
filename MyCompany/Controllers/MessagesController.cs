using System;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;

namespace MyCompany.Controllers
{
    public class MessagesController : Controller
    {
        private readonly DataManager dataManager;

        public MessagesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.MessageItems.GetMessageItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageMessages");
            return View(dataManager.MessageItems.GetMessageItems());
        }
    }
}