using System.ComponentModel.DataAnnotations;

namespace appBodega.Models
{
    public class User
    {
        [Required(ErrorMessage ="ID es requerido para continuar")]
        public int IdUser { get; set; }
        [Required(ErrorMessage = "Mail del ususario es requerido para continuar")]
        public string UserMail { get; set; }
        [Required(ErrorMessage = "Contraseña es requerida para continuar")]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }

       
    }
}
