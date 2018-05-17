using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DodgeOrSmash.Models
{
    public class ScoreBoard
    {
        [Key]
        public int PontID { get; set; }

        public float Pontuacao { get; set; }

        [Column(TypeName = "datetime")]
        [Display(Name = "ScoreBoard Date")]
        public DateTime Data { get; set; }

        [ForeignKey("User")]
        public int UserFK { get; set; }
        public virtual Users User { get; set; }

    }
}