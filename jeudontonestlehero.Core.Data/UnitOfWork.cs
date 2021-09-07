using jeudontonestlehero.Core.Data.Interfaces;
using jeudontonestlehero.Core.Data.Models;
using jeudontonestlehero.Core.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DefaultContext _context;
        public UnitOfWork(DefaultContext context)
        {
            _context = context;
            Paragraphe = new ParagrapheRepository(_context);
            Question = new QuestionRepository(_context);
            Aventures = new AventureRepository(_context);
        }

        public IParagrapheRepository Paragraphe { get; private set; }
        public IQuestionRepository Question { get; private set; }
        public IRepository<Aventures> Aventures { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
