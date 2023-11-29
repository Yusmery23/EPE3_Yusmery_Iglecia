// Se Crea el modelo para los datos del Paciente

namespace ApiControlador.Models
{
    public class Pacientes
    {
        public int IdPciente { get; set; }

        public String NombrePac { get; set; }

        public String ApellidoPc { get; set; }

        public String RunPac { get; set; }

        public String NacionalidadPac { get; set; }

         public String Visa { get; set; }

          public String Genero { get; set; }

           public String SintomasPac { get; set; }

        public DateTime Horario { get; set; }

        public int Tarifa { get; set; }
    }
}