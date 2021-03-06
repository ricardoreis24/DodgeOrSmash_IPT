﻿using System;
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

        public string Name { get; set; }

        public decimal Wallet { get; set; }

        public float Score { get; set; }

        public string ActiveSkin { get; set; }

        public virtual ICollection<ScoreBoard>ListaDeScores { get; set; }
        public virtual ICollection<Purchase>ListaDeCompras { get; set; }
        public virtual ICollection<Inventory>ListaDeInventario { get; set; }
    }
}