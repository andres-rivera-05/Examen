using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Promedio : PromedioInterfaz
    {

        public double nota1;
        public double nota2;
        public double nota3;

        public Promedio(double nota1, double nota2, double nota3) { 
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

       public string mostrarPromedio()
        {
            return $"Mostrando promedio sin parametor {calcularPromedio()}";
        }

        public string mostrarPromedio(double nita1, double nota2, double nota3)
        {
            return $"Mostrando promedio con parametros {calcularPromedio(nota1,nota2,nota3)}";
        }

        public double calcularPromedio()
        {
            return (nota1+nota2+nota3)/3;
        }

        public double calcularPromedio(double promedio_uno, double promedio_dos, double promedio_tres)
        {
            return (nota1 + nota2 + nota3) / 3;
        }
    }
}
