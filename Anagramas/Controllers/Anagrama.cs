using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagramas.Controllers
{
    /*
     
   Nombre de la escuela: Universidad Tecnologica Metropolitana



    Asignatura: Aplicaciones Web Orientadas a Servicios




    Nombre del Maestro: Chuc Uc Joel Ivan




    Nombre de la actividad: Actividad 3 "Anagrama"




    Nombre del alumno: Fabian Francisco Aguilar Rivero




    Cuatrimestre: 4




    Grupo: B




    Parcial: 1
    
    */




    [Route("api/[controller]")]
    [ApiController]
    public class Anagrama : ControllerBase
    {

        [HttpGet]
        public IActionResult Anagramas(string palabraoriginal, string palabranueva)
        {
            bool Anagrama;
            var Resultado = "";

            if (palabraoriginal.Length != palabranueva.Length)
            {
                Anagrama = false;
            }

            else
            {
                char[] A = palabraoriginal.ToCharArray();

                Array.Sort(A);



                char[] B = palabranueva.ToCharArray();

                Array.Sort(B);



                string PalabraO = new string(A);
                string PalabraN = new string(B);
                if (PalabraO == PalabraN)
                {
                    Anagrama = true;
                }
                else
                {
                    Anagrama = false;
                }

            }
            if (Anagrama == true)
            {
                Resultado = "Las palabras " + palabraoriginal + " y " + palabranueva + " Son Anagramas";
            }

            else
            {
                Resultado = "Las palabras " + palabraoriginal + " y " + palabranueva + " No son Anagramas";
            }


            return Ok(Resultado);
        }

    }
}
