public abstract class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Velocidad { get; set; }

    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
        Velocidad = 0;
    }

    public abstract void Acelerar();
    public abstract void Frenar();

    public void MostrarInfo()
    {
        Console.WriteLine($"Vehículo: {Marca} {Modelo}");
        Console.WriteLine($"Velocidad actual: {Velocidad} km/h");
    }
}