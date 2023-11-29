//Se crea el modelo con los datos del Médico

namespace ApiControlador.Models
{
    public class Medicos
    {
        public int IdMed { get; set; }

        public String NombreMed { get; set; }

        public String ApellidoMed { get; set; }

        public String RunMed { get; set; }

        public String Eunacom { get; set; }

        public String NacionalidadMed { get; set; }

        public String Especialidad { get; set; }

        public DateTime HorarioMed { get; set; }

        public int Tarifa { get; set; }
    }
}