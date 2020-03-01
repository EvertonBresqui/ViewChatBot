using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Chatbot.Models;
using Microsoft.AspNetCore.Http;

namespace Chatbot.Controllers
{
    public class BotController : Controller
    {

        private readonly IHttpContextAccessor _httpContextAccessor = null;

        public BotController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public ActionResult Index()
        {
          
 
            ViewBag.SessionId = Guid.NewGuid().ToString();

            return View();
        }
    }
}
