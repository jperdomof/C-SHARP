using System;
public abstract class Animal: Mamifero
{
    public string Nombre { get; set; }

    public static void nombre()
    {
      Mamifero.familia();
        
    }

     public static void vertebrado()
    {
        Console.WriteLine("son animales Vertebrados");
        
    }

    public static void invertebrado()
    {
        Console.WriteLine("son animales Invertebrados");
        
    }

    public static void extremidades()
    {
        Console.WriteLine("son animales con 4 patas");
        
    }

    public static void extremidades2()
    {
        Console.WriteLine("son animales de 2 patas");
        
    }

    public static void extremidades3()
    {
        Console.WriteLine("son animales con 2 alas");
        
    }

    public static void extremidades4()
    {
        Console.WriteLine("son animales con 2 aletas");
        
    }


}