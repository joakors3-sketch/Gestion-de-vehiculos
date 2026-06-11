public class Moto : Vehiculo
{
    public Moto(string marcaMoto, string modeloMoto)
        : base(marcaMoto, modeloMoto)
    {
    }

    public override void Acelerar()
    {
        Velocidad += 500;
    }

    public override void Frenar()
    {
        Velocidad -= 200;

        if (Velocidad < 0)
        {
            Velocidad = 0;
        }
    }
}