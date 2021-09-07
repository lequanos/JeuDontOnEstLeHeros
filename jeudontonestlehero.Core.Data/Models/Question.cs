using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeudontonestlehero.Core.Data.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public int ParagrapheId { get; set; }

        public List<Answer> MyAnswers { get; set; }
    }
}
