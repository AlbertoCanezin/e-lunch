namespace ELunch.Models
{
  public class Categoria
  {
    // Definir uma propriedade com o nome Id ou 'NomeId' para o EF gerar uma chave primaria na tabela do banco de dados
    public int CategoriaId { get; set; }

    // Definindo o nome da categoria
    public string CategoriaName { get; set; }

    public string Description { get; set; }

    // Definindo uma relação um-para-muitos 
    public List<Lanche> Lanches { get; set; }
  }
}