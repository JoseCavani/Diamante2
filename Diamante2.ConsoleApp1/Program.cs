﻿using System;
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
            int numeroParaALetra = (int)letra; // numero de 65 - 90 ASCII

            int numeroParaLinhas = numeroParaALetra - 65; //numero de 0 a 25 para as letras do alfabeto

            #endregion



      
            #region     Parte de cima e meio
            for (int linhas = 0; linhas <= numeroParaLinhas ; linhas++) // rodar as linhas ate que chege no numero maximo de linhas
                {
                    for (int colunas = -(numeroParaLinhas+1)/2; colunas <= numeroParaLinhas + linhas; colunas++)// fazer colunas
    // essa logica determine onde iniciar as colunas 
    // tem que ser inicializado de acordo com o valor minimo maior senão dara errado depois
    //o numero inicilizado é  (-numeroParaLinhas ((0 a 25) + 1)/2) 
    //eu descobri isso fazendo as contas com o valor z (colunas == ((numeroParaLinhas)/2) - linhas) e descobri essa formula, note que ele fica negativo
                    {
                    if (colunas > ((numeroParaLinhas) / 2) + linhas)
                        break;// logica para evitar escrever mais espaçoes do que necessario
                    if (colunas == ((numeroParaLinhas) / 2) - linhas || colunas == ((numeroParaLinhas) / 2)   + linhas  )
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
            for (int linhas = 1; linhas <= numeroParaLinhas; linhas++)
            {
                for (int colunas = -(numeroParaLinhas + 1)/2; colunas <= numeroParaLinhas+(numeroParaLinhas - linhas); colunas++)
                // na parte de baixo muda a logica de ate onde as colunas vão
                //aqui tem se que o maior numero maximo de colunas (descoberto por testes com a letra Z) e: numeroParaLinhas+(numeroParaLinhas - i)
                {
                    if (colunas > ((numeroParaLinhas) / 2) + (numeroParaLinhas - linhas))
                        break; // logica para evitar escrever mais espaçoes do que necessario
                    if (colunas == ((numeroParaLinhas) / 2) - (numeroParaLinhas - linhas) || colunas == ((numeroParaLinhas) / 2) + (numeroParaLinhas - linhas ))
                    // logica para descobrir o minimo e maximo de cada linha
                    {
                        Console.Write($"{(char)(numeroParaALetra - linhas)}"); // descobrir a letra e imprimr

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
