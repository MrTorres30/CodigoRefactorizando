namespace FactoryProblema
{
    
    public abstract class Vehiculo : VehiculoFactory
    {
        
        private string marca;
        public string Marca {get;}

        private double precio;
        public double Precio {get;}


    
        public enum TipoVehiculo
        {
            Sedan = 1,
            Suv = 2,
            Compacto = 3
        }
        public override string ToString()
        {
            return $"Marca: {Marca}. Precio: {Precio}";
        }
    }
}