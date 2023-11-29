using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiControlador.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiControlador.Controller
{
    public class Paciente
    {


   }
    public class PacientesController: ControllerBase
    {
    
    
    private Pacientes[] datosClinica = new Pacientes[]{

     new Paciente{IdPciente= 01, NombrePc= "Julio", ApellidoPac= "Crespo", RunPac= "19077999-k", NacionalidadPac= "Chilena", Visa= "Si", Genero= "M", Sintomas= "Asma" },
     new Paciente{IdPciente= 02, NombrePc= "Maria", ApellidoPac= "Lopez", RunPac= "20077999-k", NacionalidadPac= "Chilena", Visa= "Si", Genero= "F", Sintomas= "Migraña" },
     new Paciente{IdPciente= 03, NombrePc= "Julia", ApellidoPac= "Marin", RunPac= "15077999-k", NacionalidadPac= "Colombiana", Visa= "No", Genero= "F", Sintomas= "Colitis" },
    
     // Genero el Método GET para listar todos los médicos

    [HttpGet("Pacientes")]

    public ActionResult<List<Medicos>> GetPacientes()
        {
            
        {
      
return Ok(datosClinica);
 }

        
        }

           
// Método GET para obtener datos de un solo médico por su ID
        
        [
HttpGet("Pacientes/{id}")]
        public static ActionResult<Medicos> GetMedicoPorId(int idPac)
        {
        }
    }

    public class PacientesController : ControllerBase
    {
        // Datos de ejemplo para pacientes (pueden ser reemplazados por una base de datos real)
        private List<Paciente> datosClinica = new List<Paciente>();

        

    // Grenero el Método POST para crear y guardar un nuevo paciente
        [HttpPost("pacientes")]
        [Route("Crear Nuevo Paciente")]

        public ActionResult <Pacientes> CrearPaciente([FromBody] Pacientes newPaciente){

    
        {
           
     // Verificacion del metodo
            
  
        if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            
            }
        }
    }

 [HttpPut("Pacientes/{Id}")]

[Route("Editar datos de un Paciente por su Id")]

    }
}

