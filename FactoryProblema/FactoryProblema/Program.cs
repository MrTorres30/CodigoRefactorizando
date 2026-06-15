using System;

namespace FactoryProblema
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                try
                {
                    
            Console.Clear();
            Console.WriteLine("|||||||| [1]Sedan   ||||||||");
            Console.WriteLine("|||||||| [2]Compacto||||||||");
            Console.WriteLine("||||||||   [3]Suv   ||||||||");
            Console.Write("Elija cual tipo de vehiculo desea: ");
                
            double precio;
            int opcion;
        if (int.TryParse(Console.ReadLine(), out opcion))
                {
            TipoVehiculo tipo = (TipoVehiculo)opcion;

            System.Console.WriteLine("Diga la marca: ");
            string marca = Console.ReadLine();

            Console.WriteLine("Diga el precio: ");
            double.TryParse(Console.ReadLine(), out precio);
            
            Vehiculo v = VehiculoFactory.Crear(tipo, marca, precio);

            Console.WriteLine(v);
                    
                }
            else
                {
                    Console.WriteLine("Por favor ingrese un número válido");
                }


                }catch(TipoVehiculoNoSoportadoException e)
                {
                    Console.WriteLine(e.Message);
                }
            Console.ReadKey();
            }
        }
    }
}
