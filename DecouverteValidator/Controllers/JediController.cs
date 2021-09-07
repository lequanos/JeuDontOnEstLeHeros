using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecouverteValidator.Controllers
{
    public class JediController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Models.Jedi jedi)
        {
            if (ModelState.IsValid)
            {
                // On met à jour la BDD
            }
            return View(jedi);
        }
    }
}
