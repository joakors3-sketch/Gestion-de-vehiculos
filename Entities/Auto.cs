public class Auto : Vehiculo
{
    public Auto(string marca, string modelo)
        : base(marca, modelo)
    {
    }

    public override void Acelerar()
    {
        Velocidad += 200;
    }

    public override void Frenar()
    {
        Velocidad -= 50;

        if (Velocidad < 0)
        {
            Velocidad = 0;
        }
    }
}