using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELanches.Models
{
    [Table("CarrinhoCompraItens")]
    public class CarrinhoCompraItem
    {
        public int CarrinhoCompraItemId { get; set; }
        public Lanche Lanche { get; set; }
        public int Quatidade { get; set; }
        
        [StringLength(200)]
        public string CarrinhoCompraId { get; set; }
    }
}
