using System.ComponentModel.DataAnnotations;

namespace appBodega.Models
{
    public class User
    {
        [Required]
        public int IdUser { get; set; }
        [Required]
        public string UserMail { get; set; }
        [Required]
        //[DataType(DataType.Password)]
        public string UserPassword { get; set; }
        //[Required]
        public string ConfirmPassword { get; set; }


    }
}
