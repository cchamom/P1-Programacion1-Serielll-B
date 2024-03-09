using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido, por favor ingrea tu correo electronico de dominio gmail: ");

        string correo = Console.ReadLine();

          if (correo.EndsWith("@gmail.com"))
        {
            string nuevoC = correo.Replace("@gmail.com", "@miumg.edu.gt");
            Console.WriteLine("El nuevo correo ekectronico generado es: " + nuevoC);
        }
          else
        {
            Console.WriteLine("El correo electronico no es valido por que no es de dominio gmail.");
        }
    }
}



