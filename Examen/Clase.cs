using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Clase : Alumno
    {
        /*Crear una clase llamada Clase, llevará los atributos nombreClase, horaClase,
         * nombreCatedratico, también llevará un método llamado mostrarClase 
         * en el cuál se van a mostrar los datos de la clase. Esta clase va a heredar
         * la clase abstracta Alumno y se debe implementar el método mostrarAlumno mostrando 
         * los datos de la clase Alumno respectivamente. (5%)*/

        public string NombreClase;
        public string HoraClase;
        public string NombreCatedratico;
 
        //Metodo
        public void MostrarClase() {
            Console.WriteLine("Nombre clase: " + NombreClase);
            Console.WriteLine("Hora Clase: " + HoraClase);
            Console.WriteLine("Nombre Catedratico: "+NombreCatedratico);
            this.MostrarAlumno();

        }


    }
}
