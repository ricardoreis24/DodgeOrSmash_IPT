using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DodgeOrSmash.Models
{
    public class Purchase
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PurchaseID { get; set; }

        //atributos espicificos de relacionamento
        //modelo CD

        public decimal ValorDaCompra { get; set; }

        [Column(TypeName = "datetime")]
        [Display(Name = "Purchase Date")]
        public DateTime Data { get; set; }

        [ForeignKey("User")]
        public int UserFK { get; set; }
        public virtual Users User { get; set; }

        [ForeignKey("Skin")]
        public int SkinFK { get; set; }
        public virtual Skins Skin { get; set; }

   


        
    }
}