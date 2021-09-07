using jeudontonestlehero.Core.Data.Interfaces;
using jeudontonestlehero.Core.Data.Models;
using jeudontonestleheros.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data.Repositories
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(DefaultContext context)
            : base(context)
        {
        }

        public IEnumerable<Question> GetQuestionWithoutAnswer()
        {
            return DefaultContext.Question.Where(item => item.MyAnswers == null).ToList();
        }

        public DefaultContext DefaultContext
        {
            get { return Context as DefaultContext; }
        }
    }
}
