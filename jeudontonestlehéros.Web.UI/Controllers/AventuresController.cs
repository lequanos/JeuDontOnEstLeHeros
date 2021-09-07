using jeudontonestlehero.Core.Data;
using jeudontonestlehero.Core.Data.Models;
using jeudontonestlehero.Core.Data.DataLayers;
using jeudontonestlehéros.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jeudontonestlehéros.Web.UI.Controllers
{
    public class AventuresController : Controller
    {
        private readonly UnitOfWork _unitOfWork = null;

        public AventuresController(UnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            ViewBag.MonTitre = "Aventures";
            IEnumerable<Aventures> aventures = _unitOfWork.Aventures.GetAll();

            return View(aventures);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Aventures aventure)
        {
            ActionResult result = this.View();
            if (this.ModelState.IsValid)
            {
                this._unitOfWork.Aventures.Add(aventure);
                this._unitOfWork.Complete();
                result = this.RedirectToAction("Play");
            }
            return result;
        }

        public IActionResult Edit(int id)
        {
            Aventures aventure = this._unitOfWork.Aventures.Get(id);

            return View(aventure);
        }

        [HttpPost]
        public IActionResult Edit(Aventures aventure)
        {
            if (this.ModelState.IsValid)
            {
                this._unitOfWork.Aventures.Update(aventure);
                this._unitOfWork.Complete();
            }

            return View(aventure);
        }

        public IActionResult Play(int id)
        {
            Paragraphe item = null;
            if (id == 0)
                item = this._unitOfWork.Paragraphe.GetInitialParagraphe();
            else
                item = this._unitOfWork.Paragraphe.GetParagrapheWithQuestionAndAnswer(id);
            return View(item);
        }
    }
}
