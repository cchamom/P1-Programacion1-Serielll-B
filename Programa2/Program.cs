using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola bienvenido, ingresa el precio de 3 productos: ");

        float[] precios = new float[3];

     
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Ingrese los precios de los productos" + (i + 1) + ": ");
            precios[i] = float.Parse(Console.ReadLine());

            if (precios[i] > 100.00)
            {
                float descuento = CalcularDescuento(precios[i]);
                Console.WriteLine("El precio del producto " + (i + 1) + " sobrepasa el Q.100.00. de quetzales");
                Console.WriteLine("Se hara un descuento de un 15%.");
                Console.WriteLine("Precio con el descuento: Q" + (precios[i] - descuento));
            }
        }

       
        float totaldelacompra = 0;
        float ahorroTotal = 0;
        foreach (float precio in precios)
        {
            totaldelacompra += precio;
            if (precio > 100.00)
            {
                ahorroTotal += CalcularDescuento(precio);
            }
        }

        Console.WriteLine("Total de la compra, sin en el descuentos: Q" + totaldelacompra);
        Console.WriteLine("Monto que el usuario que se ahorra por el descuentos: Q" + ahorroTotal);
    }

    static float CalcularDescuento(float precio)
    {
        return precio * 0.15f;
    }
}

