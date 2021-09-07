using jeudontonestlehero.Core.Data;
using jeudontonestlehero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jeudontonestleheros.BackOffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        private readonly DefaultContext _context = null;
        public ParagrapheController(DefaultContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Paragraphe paragraphe)
        {
            if (this.ModelState.IsValid)
            {
                this._context.Paragraphe.Add(paragraphe);
                this._context.SaveChanges();
                ModelState.Clear();
                Paragraphe objParagraphe = new Paragraphe
                {
                    Number = 0,
                    Title = string.Empty,
                    Description = string.Empty
                };
                return View(objParagraphe);
            }
            else
            {
                return View();
            }

        }
        public IActionResult Edit(int id)
        {
            Paragraphe paragraphe = null;
            var query = from item in this._context.Paragraphe
                        select item;
            paragraphe = query.ToList().First(item => item.Id == id);
            return View(paragraphe);
        }
        [HttpPost]
        public IActionResult Edit(Paragraphe paragraphe)
        {
            //this._context.Paragraphe.Update(paragraphe);

            this._context.Attach<Paragraphe>(paragraphe);
            this._context.Entry(paragraphe).Property(item => item.Title).IsModified = true;
            this._context.SaveChanges();

            var query = from item in _context.Paragraphe
                        where item.Id == paragraphe.Id
                        select item;

            Paragraphe updatedParagraphe = null;

            foreach (var item in query)
            {
                updatedParagraphe = item;
            }

            return View(updatedParagraphe);
        }
    }
}
