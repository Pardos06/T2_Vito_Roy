using System.ComponentModel.DataAnnotations;

namespace T2_Vito_Roy.Models
{
    public class Distribuidor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del Distribuidor es obligatorio")]
        public string NombreDistribuidor { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [DataType(DataType.Date)] 
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)] 
        public DateTime InicioOperacion { get; set; }

        [Required(ErrorMessage = "Campo es obligatorio")]
        public string Contacto { get; set; }
    }
}
