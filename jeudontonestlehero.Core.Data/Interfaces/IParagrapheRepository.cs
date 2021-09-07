using jeudontonestlehero.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data.Interfaces
{
    public interface IParagrapheRepository : IRepository<Paragraphe>
    {
        Paragraphe GetParagrapheWithQuestionAndAnswer(int id);
        Paragraphe GetInitialParagraphe();
    }
}
