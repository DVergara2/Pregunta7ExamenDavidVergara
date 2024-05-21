using System;
using System.Net.NetworkInformation;
abstract class Pais
{
    public abstract void ColorBandera();
    public abstract void Tamaño();

    public abstract void Idioma();

}

class Ecuador : Pais
{
    public override void ColorBandera()
    {

        Console.WriteLine("El color de labandera es: Amarillo,Azul y Rojo");
    }
    public override void Tamaño()
    {
        
        Console.WriteLine("El tamaño es:283,561 km²");

    }
    public override void Idioma()
    {
        Console.WriteLine("El Idioma es:Español");
    }


}

class Andorra : Pais
{
    public override void ColorBandera()
    {

        Console.WriteLine("El color de labandera es: Azul,Amarillo,Rojo");
    }
    public override void Tamaño()
    {
        
        Console.WriteLine("El tamaño es:468 km²");

    }
    public override void Idioma()
    {
        Console.WriteLine("El Idioma es:el catalán, el español, el francés y el portugués");
    }


}
class Brasil : Pais
{
    public override void ColorBandera()
    {

        Console.WriteLine("El color de labandera es: Verde ,Amrillo ,Azul");
    }
    public override void Tamaño()
    {
        
        Console.WriteLine("El tamaño es:8.51 millones km²");

    }
    public override void Idioma()
    {
        Console.WriteLine("El Idioma es: portugués");
    }


}

class Program
{
    static void Main(string[] args)
    {
        Ecuador myEcuador = new Ecuador(); 
        myEcuador.ColorBandera();

        Andorra myAndorra = new Andorra(); 
        myAndorra.Tamaño();
        
        Brasil myBrasil = new Brasil(); 
        myBrasil.Idioma();

    }

}