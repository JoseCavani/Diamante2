using System;
using System.Text.RegularExpressions;
namespace Diamante.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region Verificar o que foi digitado
        volta:
            Console.WriteLine("digite uma letra");
            string stringDigitado = Console.ReadLine().ToUpper();
            if (!(char.TryParse(stringDigitado, out char letra)&& Regex.IsMatch(stringDigitado, @"^[a-zA-Z]+$")))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("invalido");
                Console.ReadKey();
                Console.ResetColor();
                goto volta;
            }
            int numeroDoLetraDe65A90 = (int)letra; // numero de 65 - 90 ASCII

            int numeroDaLetraDe0A25 = numeroDoLetraDe65A90 - 65; //numero de 0 a 25 para as letras do alfabeto

            #endregion


            


      
            #region     Parte de cima e meio
            for (int linhas = 0; linhas <= numeroDaLetraDe0A25 ; linhas++) // rodar as linhas ate que chege no numero maximo de linhas
                {
                    for (int colunas = -(numeroDaLetraDe0A25+1)/2; colunas <= numeroDaLetraDe0A25 + (numeroDaLetraDe0A25/2); colunas++)// fazer colunas
    // essa logica determine onde iniciar as colunas 
    // tem que ser inicializado de acordo com o valor minimo maior senão dara errado depois
    //o numero inicilizado é  (-numeroParaLinhas ((0 a 25) + 1)/2) 
    //eu descobri isso fazendo as contas com o valor z (colunas == ((numeroParaLinhas)/2) - linhas) e descobri essa formula, note que ele fica negativo
                    {
                    if (colunas > ((numeroDaLetraDe0A25) / 2) + linhas)
                        break;// logica para evitar escrever mais espaçoes do que necessario
                    if (colunas == ((numeroDaLetraDe0A25) / 2) - linhas || colunas == ((numeroDaLetraDe0A25) / 2)   + linhas  )
                    //valores minimos || e maxmio da cada linha
                    {
                        Console.Write($"{(char)(65 + linhas)}");// descobrir a letra e imprimir
                    
                    }
                    else
                        Console.Write(" ");
                    
                    }
                    Console.WriteLine();
                }
            #endregion



            #region Parte de baixo
            for (int linhas = 1; linhas <= numeroDaLetraDe0A25; linhas++)
            {
                for (int colunas = -(numeroDaLetraDe0A25 +1)/2; colunas <= numeroDaLetraDe0A25+(numeroDaLetraDe0A25/2); colunas++)
                // na parte de baixo a logica e igual
                {
                    if (colunas > ((numeroDaLetraDe0A25) / 2) + (numeroDaLetraDe0A25 - linhas))
                        break; // logica para evitar escrever mais espaçoes do que necessario
                    if (colunas == ((numeroDaLetraDe0A25) / 2) - (numeroDaLetraDe0A25 - linhas) || colunas == ((numeroDaLetraDe0A25) / 2) + (numeroDaLetraDe0A25 - linhas ))
                    // logica para descobrir o minimo e maximo de cada linha
                    {
                        Console.Write($"{(char)(numeroDoLetraDe65A90 - linhas)}"); // descobrir a letra e imprimr

                    }
                   else
                        Console.Write(" ");

                   
                }
                Console.WriteLine();
            }
            #endregion
         
            Console.ReadKey();
          
        }
    }
}
