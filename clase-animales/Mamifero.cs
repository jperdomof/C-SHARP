using System;

public abstract class Mamifero
{
    public string Familia { get; set; }

    public static void familia()
    {
        Console.WriteLine("Es un animal mamifero");
    }

    public static void familia2()
    {
        Console.WriteLine("Es un animal Equinodermo");
    }


}

public abstract class comer
{
    public static void carnivoro()

    {
      Console.WriteLine("Es un animal que se alimenta de carne");      

    }

    public static void hervivoro()

    {
      Console.WriteLine("Es un animal que se alimenta de hierva");      

    }

    public static void hervivoro2()

    {
      Console.WriteLine("Es un animal que se alimenta de polen");      

    }

    public static void hervivoro3()

    {
      Console.WriteLine("Es un animal que se alimenta de algas");      

    }

    

    public static void omnivoro()

    {
      Console.WriteLine("Es un animal que se alimenta de carne y de sustancias vegetales");      

    }
        
}