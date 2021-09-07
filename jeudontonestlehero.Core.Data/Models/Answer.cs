using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        public string Proposition { get; set; }

        public int QuestionId { get; set; }

        public int ParagrapheId { get; set; }
    }
}
