using System;

namespace Diamante.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            volta:
            Console.WriteLine("digite uma letra");
           char letra = char.Parse(Console.ReadLine().ToUpper());
            int numeroParaALetra = (int)letra;

            int numeroParaLinhas = numeroParaALetra - 65; //69-65 = 5
          
         
                              
                for (int i = 0; i <= numeroParaLinhas ; i++)
                {
                    for (int z = -(numeroParaLinhas+1)/2; z <= numeroParaLinhas + i; z++)
                    {         

                        if (z == ((numeroParaLinhas)/2) - i || z == ((numeroParaLinhas)/2) + i)
                        {
                            Console.Write($"{(char) (65+i)}");
                        }
                   
                    else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }

            for (int i = 1; i <= numeroParaLinhas; i++)
            {
                for (int z = -(numeroParaLinhas + 1)/2; z <= numeroParaLinhas+(numeroParaLinhas - i); z++)
                {

                    if (z == ((numeroParaLinhas) / 2) - (numeroParaLinhas-i) || z == ((numeroParaLinhas) / 2) + (numeroParaLinhas-i))
                    {
                        Console.Write($"{(char)(numeroParaALetra - i)}");
                    }

                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }


            //for (int i = ((numeroParaLinhas - 1) / 2); i <= numeroParaLinhas; i++)
            //{
            //    for (int z = 0; z < numeroParaLinhas; z++)
            //    {                       //((5-1)/2) 2 + (5-3) 2 = 4    
            //        if (z == ((numeroParaLinhas - 1) / 2) - (numeroParaLinhas - i) || z == ((numeroParaLinhas - 1) / 2) + (numeroParaLinhas - i))
            //        {
            //        Console.Write($"{(char)(65 + i)}");
            //    }

            //    else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            Console.ReadKey();
          
        }
    }
}
