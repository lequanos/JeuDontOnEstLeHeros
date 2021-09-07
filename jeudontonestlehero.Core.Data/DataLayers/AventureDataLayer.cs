using jeudontonestlehero.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data.DataLayers
{
    public class AventureDataLayer
    {
        private DefaultContext _context = null;

        public AventureDataLayer(DefaultContext context)
        {
            this._context = context;
        }

        public Aventures GetAventure(int id)
        {
            Aventures aventure = null;
            var aventuresList = from a in this._context.Aventure
                                select a;

            aventure = aventuresList.ToList().First(item => item.Id == id);

            return aventure;
        }

        public void AddAventure(Aventures aventure)
        {
            this._context.Aventure.Add(aventure);
            this._context.SaveChanges();
        }
        public void UpdateAventure(Aventures aventure)
        {
            this._context.Aventure.Update(aventure);
            this._context.SaveChanges();
        }
    }
}
