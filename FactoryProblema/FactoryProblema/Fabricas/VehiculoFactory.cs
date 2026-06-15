using System.Collections;
using System.Diagnostics;

namespace FactoryProblema
{
    
    public static class VehiculoFactory
    {
        
    public static Vehiculo Crear(TipoVehiculo tipo)

        {
            return Vehiculo;
        }


        switch(tipo)
        {
            case TipoVehiculo.Sedan 
            return new Sedan();

            case TipoVehiculo.Compacto
            return new Compacto();

            case TipoVehiculo.Suv
            return new Suv();
        }
       
    }

    
}