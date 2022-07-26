namespace ELunch.Models
{
  public class Lanche
  {
    public int LancheId { get; set; }
    public string Name { get; set; }
    public string DescricaoCurta { get; set; }
    public string DescricaoDetalhada { get; set; }
    public decimal Preco { get; set; }
    public string ImagemUrl { get; set; }
    public string ImagemThumbnailUrl { get; set; }
    public bool IsLanchePreferido { get; set; }
    public bool EmEstoque { get; set; }

    // Definindo o relacionamento entre Lanche e Categoria
    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; }
  }
}