using System.ComponentModel.DataAnnotations;

namespace TEST_DEV_CCA_14082024.Dtos
{
    public class PersonaFisicaDto
    {
        public int IdPersonaFisica { get; set; }
        [Required (ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido paterno es requerido")]
        public string ApellidoPaterno { get; set; }

        [Required(ErrorMessage = "El apellido materno es requerido")]
        public string ApellidoMaterno { get; set; }

        [Required(ErrorMessage = "El RFC es requerido")]
        public string RFC { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El usuario que modifica el registro es necesario")]
        public string UsuarioAgrega { get; set; }

    }
}
