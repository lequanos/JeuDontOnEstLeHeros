using jeudontonestlehero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jeudontonestleheros.BackOffice.Web.UI.Controllers
{
    public class AnswerController : Controller
    {
        private readonly DefaultContext _context = null;
        public AnswerController(DefaultContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            this.ViewBag.questionList = this._context.Question.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Answer answer)
        {
            this.ViewBag.questionList = this._context.Question.ToList();
            if (ModelState.IsValid)
            {
                this._context.Answer.Add(answer);
                this._context.SaveChanges();
            }
            return View(answer);
        }
    }
}
