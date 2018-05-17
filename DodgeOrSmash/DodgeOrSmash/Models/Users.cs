using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DodgeOrSmash.Models
{
    public class Users
    {
        public Users()
        {
            ListaDeScores = new HashSet<ScoreBoard>();
            ListaDeCompras = new HashSet<Purchase>();

        }

    [Key]
        public int UserID { get; set; }

        [Required]

        public decimal Wallet { get; set; }

        public float Score { get; set; }

        public int ActiveSkin { get; set; }

        public string Inventory { get; set; }

        public virtual ICollection<ScoreBoard>ListaDeScores { get; set; }
        public virtual ICollection<Purchase>ListaDeCompras { get; set; }
    }
}