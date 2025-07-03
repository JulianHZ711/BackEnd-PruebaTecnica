using System.ComponentModel.DataAnnotations;

namespace Empleados.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required (ErrorMessage = "El correo electrónico es obligatorio")]
        [EmailAddress]
        public string Correo { get; set; }

        public string Cargo { get; set; }

        public string Departamento { get; set; }

        public string Telefono { get; set; }

        [FechaNoFutura(ErrorMessage = "La fecha no puede ser futura")]
        [DataType(DataType.Date)]
        public DateTime FechaIngreso { get; set; }

        public bool Activo { get; set; }

        //Validación fecha futura

        public class FechaNoFuturaAttribute: ValidationAttribute
        {
            public override bool IsValid (object value)
            {
                if (value is DateTime fecha)
                {
                    return fecha <= DateTime.Today;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
