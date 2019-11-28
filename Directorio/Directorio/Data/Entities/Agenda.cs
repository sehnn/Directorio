using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Directorio.Data.Entities
{
    public class Agenda
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido obligatoriamente")]
        [Maxlength(30)]
        [Display(Name="Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido obligatoriamente")]
        [Maxlength(30)]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido obligatoriamente")]
        [Maxlength(30)]
        [Display(Name = "Empresa")]
        public string Empresa { get; set; }   

        [Maxlength(20)]
        [Display(Name = "Telefono")]
        public int Telefono { get; set; }

        [Maxlength(20)]
        [Display(Name = "N° Celular")]
        public int Celular { get; set; }

        [Maxlength(30)]
        [Display(Name = "Correo ")]
        public string Correo { get; set; }



        public string FullName => $"{Nombre} {Apellido}";

        public string FullNameEMpresa => $"{Nombre} {Apellido} - {Empresa}";

    }
}
