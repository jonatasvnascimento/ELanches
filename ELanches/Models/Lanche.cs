using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELanches.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "O nome do lanche deve ser informado")]
        [Display(Name = "Nome do Lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e o maximo {2} de tamanho")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O nome do lanche deve ser informado")]
        [Display(Name = "Descrição curta")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no minimo {1} caractere")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no minimo {1} caractere")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "O nome do lanche deve ser informado")]
        [Display(Name = "Descrição detalhada")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no minimo {1} caractere")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no minimo {1} caractere")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "O preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve esta entre 1 e 999,99")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho da imagem normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no maximo {1} de caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho da imagem miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no maximo {1} de caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
