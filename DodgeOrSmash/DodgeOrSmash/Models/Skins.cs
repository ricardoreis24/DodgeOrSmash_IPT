using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DodgeOrSmash.Models
{
    public class Skins
    {
        //dados da tabela skins

        public Skins()
        {
            Purchase = new HashSet<Purchase>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Skin identifier")]
        public int SkinsID { get; set; }

        [Required(ErrorMessage = "O {0} é de preencimento obrigatório...")]
        [Display(Name = "Is skin Available")]
        public bool IsActive { set; get; }

        [Required(ErrorMessage = "O {0} é de preencimento obrigatório...")]
        [StringLength(30)]
        [Display(Name = "Skin Name")]
        public string Name { set; get; }

        [Required(ErrorMessage = "O {0} é de preencimento obrigatório...")]
        [Display(Name = "Skin Price")]
        public decimal Price { get; set; }

        //[Required(ErrorMessage = "O {0} é de preencimento obrigatório...")]
        [Display(Name = "Skin Image")]
        public string ImagePath { get; set; }

        // especificar relacionamentos
        public ICollection<Purchase> Purchase { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
    }
}