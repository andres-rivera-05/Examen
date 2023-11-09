using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public interface PromedioInterfaz
    {
        /*Crear una interfaz llamada PromedioInterfaz, dicha interfaz llevará los siguientes métodos:
mostrarPromedio (Sin parámetros): Método de tipo string (0.5%)
mostrarPromedio (Con 3 parámetros de las notas): Método de tipo string (0.5%)
calcularPromedio (Sin parámetros): Método de tipo double (0.5%)
calcularPromedio (Con 3 parámetros de las notas): Método de tipo double (0.5%)*/


        public string mostrarPromedio();
        public string mostrarPromedio(double nita1, double nota2, double nota3 );

        public double calcularPromedio();
        public double calcularPromedio(double promedio_uno, double promedio_dos, double promedio_tres);


    }
}
