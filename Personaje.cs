public class Personaje
{
    public string Nombre {get; set;}

    public int Vida {get; protected set;}  //protected es para que solo peda ser utilizado por clases padres o hijas

    public int Fuerza {get; set;}

    public Personaje()
    {
        
    }

    public Personaje(string nombre,int vida, int fuerza)
    {
        Nombre=nombre;
        Vida=vida;              //estos son constructores, no entendi bien que son
        Fuerza=fuerza;
    }

    public virtual void Atacar(Personaje objeto)
    {
        Console.WriteLine($"El {objeto.Nombre} fue atacado por {Nombre}")
        objetivo.RescibirDano
    }

    public override string ToString()   //sirve para ver que valores tomo el objeto
    {
        return $"Nombre: {Nombre}\nVida: {Vida}\nFuerza: {Fuerza}";
    }
}