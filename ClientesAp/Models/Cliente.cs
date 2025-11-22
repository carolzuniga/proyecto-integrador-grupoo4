using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientesAp.Models
{
    [Table("Clientes", Schema = "dbo")] // <- mapea a dbo.Clientes
    public class Cliente
    {
        [Key] public int Id { get; set; }
        [Required, StringLength(80)] public string Nombre { get; set; } = string.Empty;
        [Required, StringLength(80)] public string Apellido { get; set; } = string.Empty;
        [EmailAddress, StringLength(120)] public string? Email { get; set; }
        [Phone, StringLength(30)] public string? Telefono { get; set; }
    }
}