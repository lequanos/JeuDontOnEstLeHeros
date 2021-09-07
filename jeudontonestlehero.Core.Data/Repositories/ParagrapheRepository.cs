using jeudontonestlehero.Core.Data.Interfaces;
using jeudontonestlehero.Core.Data.Models;
using jeudontonestleheros.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data.Repositories
{
    public class ParagrapheRepository : Repository<Paragraphe>, IParagrapheRepository
    {
        public ParagrapheRepository(DefaultContext context)
            : base(context)
        {
        }

        public Paragraphe GetParagrapheWithQuestionAndAnswer(int id)
        {
            return DefaultContext.Paragraphe.Include(item => item.MaQuestion).ThenInclude(item => item.MyAnswers).First(item => item.Id == id);
        }

        public Paragraphe GetInitialParagraphe()
        {
            return DefaultContext.Paragraphe.Include(item => item.MaQuestion).ThenInclude(item => item.MyAnswers).First(item => item.IsInitial);
        }

        public DefaultContext DefaultContext
        {
            get { return Context as DefaultContext; }
        }
    }
}
