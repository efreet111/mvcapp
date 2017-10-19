using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcapp.Models
{
    public class UsuarioModel
    {
        public class ActorModel
        {
            [Required]
            [Display(Name = "Nombre")]
            public string Name { get; set; }
            [Required]
            [Display(Name = "Apellido")]
            public string LastName { get; set; }
            [Key]
            [Required]
            [Display(Name = "ID")]
            public string IDNumber { get; set; }
            [Key]
            [Required]
            [DataType(DataType.EmailAddress)]
            [Display(Name = "EMail")]
            public string EMail { get; set; }
            
            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "password")]
            public string Password { get; set; }
        }
    }


    
}