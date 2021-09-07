using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data.Models
{
    public class Paragraphe
    {
        [Key]
        public int Id { get; set; }

        [Range(1, 10000, ErrorMessage = "Veuillez saisir un nombre")]
        public int Number { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Veuillez saisir un titre")]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Veuillez saisir une description")]
        public string Description { get; set; }

        public bool IsInitial { get; set; }

        public Question MaQuestion { get; set; }
    }
}

