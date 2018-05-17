using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DodgeOrSmash.Models
{
    public class Inventory
    {
        [Key]
        public int InventoryID { get; set; }

        [ForeignKey("User")]
        public int idUser { get; set; }
        public virtual Users User { get; set; }

        [ForeignKey("Skin")]
        public int idSkin { get; set; }
        public virtual Skins Skin { get; set; }
    }
}