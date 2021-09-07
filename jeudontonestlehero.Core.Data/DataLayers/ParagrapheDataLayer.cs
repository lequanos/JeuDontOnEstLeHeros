using jeudontonestlehero.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace jeudontonestlehero.Core.Data.DataLayers
{
    public class ParagrapheDataLayer
    {
        private DefaultContext _context = null;

        public ParagrapheDataLayer(DefaultContext context)
        {
            this._context = context;
        }

        public Paragraphe GetFirst()
        {
            Paragraphe paragraphe = this._context.Paragraphe
                                                    .Include(item => item.MaQuestion)
                                                    .ThenInclude(item => item.MyAnswers)
                                                    .First(item => item.IsInitial == true);
            return paragraphe;
        }
        
        public Paragraphe GetOne(int id)
        {
            Paragraphe paragraphe = this._context.Paragraphe
                                                    .Include(item => item.MaQuestion)
                                                    .ThenInclude(item => item.MyAnswers)
                                                    .First(item => item.Id == id);

            return paragraphe;
        }
    }
}
