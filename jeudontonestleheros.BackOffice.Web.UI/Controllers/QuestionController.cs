using jeudontonestlehero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jeudontonestleheros.BackOffice.Web.UI.Controllers
{
    public class QuestionController : Controller
    {
        private readonly DefaultContext _context = null;
        public QuestionController(DefaultContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            this.ViewBag.paragrapheList = this._context.Paragraphe.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Question question)
        {
            this.ViewBag.paragrapheList = this._context.Paragraphe.ToList();
            if (this.ModelState.IsValid)
            {
                this._context.Question.Add(question);
                this._context.SaveChanges();
            }

            return View(question);
        }
    }
}
