using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wsei.Lab7.Services;

namespace Wsei.Lab7.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index([FromServices] IChatMessagesRepository repository)
        {
            var messages = repository.GetAll();
            return View(messages);
        }
    }
}
