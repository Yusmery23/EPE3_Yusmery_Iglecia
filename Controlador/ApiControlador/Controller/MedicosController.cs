using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiControlador.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiControlador.Controller
{

   }
    public class MedicosController : ControllerBase
    {
    
    
    private Medicos[] datosClinica = new Medicos[]{

     new Medicos{IdMed= 1, NombreMed= "Juan", ApellidoMed= "Pérez", RunMed= "15077999-k", Eunacom= "MS11111", NacionalidadMed= "Chilena", Especialidad= "Traumatologo", HorarioMed= '07:00-13:00', Tarifa= 20000 },
     new Medicos{IdMed= 2, NombreMed= "Maria", ApellidoMed= "Lopez", RunMed= "22077999-1", Eunacom= "MS11112", NacionalidadMed= "Argentina", Especialidad= "Pediatra", HorarioMed= '13:00-19:00', Tarifa= 30000 },
     new Medicos{IdMed= 3, NombreMed= "Petra", ApellidoMed= "Villa", RunMed= "25077999-0", Eunacom= "MS11113", NacionalidadMed= "Venezolana", Especialidad= "Ginecologia", HorarioMed= '07:00-13:00', Tarifa= 40000 },

     // Genero el Método GET para listar todos los médicos

    [HttpGet("Medicos")]

    public ActionResult<List<Medicos>> GetMedicos()
        {
            
        {
      
return Ok(datosClinica);
 }

        
        }

           
// Método GET para obtener datos de un solo médico por su ID
        
        [
HttpGet("Medicos/{id}")]
        public static ActionResult<Medicos> GetMedicoPorId(int idMed)
        {
        }
    }

    