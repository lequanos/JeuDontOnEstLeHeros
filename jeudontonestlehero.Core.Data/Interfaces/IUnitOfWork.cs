using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IParagrapheRepository Paragraphe { get; }
        IQuestionRepository Question { get; }
        int Complete();
    }
}
