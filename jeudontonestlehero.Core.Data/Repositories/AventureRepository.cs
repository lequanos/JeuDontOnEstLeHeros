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
    public class AventureRepository : Repository<Aventures>, IRepository<Aventures>
    {
        public AventureRepository(DefaultContext context)
            : base(context)
        {
        }

        public DefaultContext DefaultContext
        {
            get { return Context as DefaultContext; }
        }
    }
}
