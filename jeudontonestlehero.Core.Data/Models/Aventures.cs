using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data.Models
{
    public class Aventures
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage ="Le titre est requis")]
        public string Title { get; set; }

    }
}

