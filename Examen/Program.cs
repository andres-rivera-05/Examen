
using Examen;

try
{
    Clase clase = new Clase();

    clase.NombreClase = "Programacion II";
    clase.HoraClase = "18:00 - 19.30";
    clase.NombreCatedratico = "Roger Ivan Gurdian";
    clase.Nombre = "andres";
    clase.NumeroCuenta = "T3231125";
    clase.email = "Cristiarivera@gmail.com";

    clase.MostrarClase();
    double nota1, nota2, nota3;

    Console.WriteLine("Ingrese nota 1: ");
    nota1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingrese nota 2: ");
    nota2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingrese nota 3: ");
    nota3 = Convert.ToDouble(Console.ReadLine());

    Promedio promedio = new Promedio(nota1, nota2, nota3);

    Console.WriteLine("utilizando el metodo calcular promedio con parametros" + promedio.mostrarPromedio(nota1, nota2, nota3));
    Console.WriteLine("utilizando el metodo calcular promedio sin parametros" + promedio.mostrarPromedio());

}
catch (FormatException)
{
    Console.WriteLine("ingrese un valor valido");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
