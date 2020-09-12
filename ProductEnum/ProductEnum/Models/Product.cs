using System.ComponentModel.DataAnnotations;

namespace ProductEnum.Models
{
    public enum CategoryType
    {
        Electronicos = 10,
        Alimenticios = 20,
        Moda = 30,
        Belleza = 40,
        Automotriz = 50,
        Libros = 60
    };
    public class Product
    {
        [Key]
        public int productID { get; set; }
        [Display(Name = "Nombre del producto")]
        [Required(ErrorMessage = "Debe ingresar el nombre del producto")]
        public string name { get; set; }
        [Display(Name = "Categoria del producto")]
        [Required(ErrorMessage = "Debe ingresar la categoria del producto")]
        public CategoryType category { get; set; }
    }
}