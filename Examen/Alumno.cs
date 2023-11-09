using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Examen
{
    public abstract class Alumno
    {
        public String Nombre { get; set; }
        public string NumeroCuenta { get; set; }
        public string email { get; set; }

        //Metodo
        public void MostrarAlumno() {
            Console.WriteLine("Nombre Alumno: " + Nombre);
            Console.WriteLine("Numero de cuenta: " + NumeroCuenta);
            Console.WriteLine("Email: " + email);
        }
       
    }
}
