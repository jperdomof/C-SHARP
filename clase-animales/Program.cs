using System;

namespace _12_ejercicio_clase_animales
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string opcion="";

            while (true)
            {
                
                Console.WriteLine("");
                Console.WriteLine("Tipos de Animales");
                Console.WriteLine("");
                Console.WriteLine("Ingrese una letra del abecedario o ingrese la letra s para salir");
                opcion = Console.ReadLine();
                
                switch (opcion)
                {
                    case "a":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: Abeja");
                    Utilidades.abeja();
                    Animal.invertebrado();
                    Animal.extremidades3();
                    comer.hervivoro2();

                    break;
                    
                   case "b":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: ballena");
                    Utilidades.ballena();
                    Animal.vertebrado();
                    Animal.extremidades4();
                    Animal.nombre();
                    comer.carnivoro();
                   
                    break;

                    case "c":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: cebra");
                    Utilidades.cebra();
                    Animal.vertebrado();
                    Animal.extremidades();
                    Animal.nombre();
                    comer.hervivoro();
                    break;

                    case "d":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: delfin");
                    Utilidades.delfin();
                    Animal.vertebrado();
                    Animal.extremidades4();
                    Animal.nombre();
                    comer.carnivoro();
                    break;

                    case "e":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: Estrella de mar ");
                    Utilidades.estrella();
                    Animal.invertebrado();
                    Animal.familia2();
                    comer.hervivoro3();
                    break;

                    case "f":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: foca");
                    Utilidades.foca();
                    Animal.extremidades4();
                    Animal.vertebrado();
                    Animal.nombre();
                    comer.carnivoro();
                    break;

                    case "g":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: Gato");
                    Felino.gato();
                    Animal.vertebrado();
                    Animal.extremidades();
                    Animal.nombre();
                    comer.carnivoro();
                    break;

                    case "h":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: hormiga");
                    Utilidades.hormiga();
                    Animal.invertebrado();
                    comer.omnivoro();
                    break;

                    case "i":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: iguana");
                    Utilidades.Iguana();
                    Animal.vertebrado();
                    Animal.extremidades();
                    comer.hervivoro();
                    break;

                    case "k":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: koala");
                    Utilidades.koala();
                    Animal.vertebrado();
                    Animal.extremidades();
                    Animal.nombre();
                    comer.hervivoro();
                    break;

                    case "j":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: jirafa");
                    Utilidades.jirafa();
                    Animal.vertebrado();
                    Animal.extremidades();
                    Animal.nombre();
                    comer.hervivoro();

                    break;

                    case "l":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: leon");
                    Felino.leon();
                    Animal.vertebrado();
                    Animal.extremidades();
                    Animal.nombre();
                    comer.carnivoro();
            
                    break;

                    case "m":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: Murcielago");
                    Felino.murcielago();
                    Animal.extremidades3();
                    Animal.vertebrado();
                    Animal.nombre();
                    comer.omnivoro();
                    break;

                    case "n":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: Nutria");
                    Felino.nutria();
                    Animal.extremidades();
                    Animal.vertebrado();
                    Animal.nombre();
                    comer.carnivoro();
                    break;

                    case "o":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: Oso");
                    Felino.oso();
                    Animal.vertebrado();
                    Animal.extremidades();
                    Animal.nombre();
                    comer.carnivoro();
                    break;

                    case "p":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: Pantera");
                    Felino.pantera();
                    Animal.vertebrado();
                    Animal.extremidades();
                    Animal.nombre();
                    comer.carnivoro();
                    break;

                    case "q":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: Quetzal");
                    Felino.quetzal();
                    Animal.vertebrado();
                    Animal.extremidades3();
                    comer.omnivoro();
                    break;

                    case "t":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: Tigre");
                    Felino.tigre();
                    Animal.vertebrado();
                    Animal.extremidades();
                    Animal.nombre();
                    comer.carnivoro();
                    break;

                    case "u":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: Urraca");
                    Felino.urraca();
                    Animal.vertebrado();
                    Animal.extremidades3();
                    comer.omnivoro();
                    break;

                    case "v":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: Vaca");
                    Felino.vaca();
                    Animal.vertebrado();
                    Animal.extremidades();
                    Animal.nombre();
                    comer.hervivoro();
                    break;

                    case "z":
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Animal: Zorzal");
                    Felino.zorzal();
                    Animal.vertebrado();
                    Animal.extremidades3();
                    comer.omnivoro();
                    break;
                    
                    default:
                    break;

                
            }
            if(opcion== "s")
            {
                break;
            }


            }

            

            
        }
    }
}
