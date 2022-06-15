using System;
using System.Collections.Generic;

namespace Forca
{
    class Program
    {
        static string[] palavraDescoberta;
        static string stringDescoberta;        
        static string palavraSecreta;
        static int vidas = 6;

        static void Main(string[] args)
        {                                                 
            p:
            Console.WriteLine("Qual é a palavra secreta?");
            palavraSecreta = Console.ReadLine();

            if (hasNumbers(palavraSecreta))
            {
                Console.WriteLine("Apenas letras!");
                goto p;
            }
            if (palavraSecreta.Length < 2)
            {
                Console.WriteLine("Deve conter pelo menos duas letras!");
                goto p;
            }
            if (palavraSecreta.Contains(" "))
            {
                Console.WriteLine("Sem espaços!");
                goto p;
            }

            Console.Clear();

            palavraDescoberta = new string[palavraSecreta.Length];

            do
            {
            c:
                Console.WriteLine("Chute uma letra:");
                var stringChutada = Console.ReadLine();
                char letraChutada;
                if (stringChutada.Length != 1)
                {
                    Console.WriteLine("Apenas uma letra é permitida!");
                    goto c;
                }
                else
                {
                    letraChutada = char.Parse(stringChutada);
                }
                
                if (hasNumbers(palavraSecreta))
                {
                    Console.WriteLine("Apenas letras!");
                    goto c;
                }

                
                bool temALetra = palavraSecreta.Contains(letraChutada);

                if (temALetra)
                {
                    var i = 0;
                    while (i <= palavraSecreta.Length)
                    {
                        var indice = palavraSecreta.IndexOf(letraChutada, i);
                        if (indice != -1)
                        {
                            if (palavraDescoberta[indice] == null)
                            {
                                palavraDescoberta[indice] = stringChutada;
                                i = indice + 1;
                            }
                            else i++;
                        }
                        else break;
                    }
                    mostraForca(true);
                }   
                else
                {                   
                    vidas--;
                    mostraForca(false);
                }                                               
                stringDescoberta = null;
                foreach (string letra in palavraDescoberta)
                {
                    stringDescoberta += letra;
                }
            } while (vidas > 0 && stringDescoberta != palavraSecreta);

            if (vidas <= 0) Console.WriteLine("ACABOU AS VIDAS"); else                
            Console.WriteLine("PARABÉNS VOCÊ VENCEU O JOGO :)");

            hangMan();

            Console.WriteLine("Pressione ENTER para fechar o programa.");
            Console.ReadLine();
        }
        public static bool hasNumbers(string apalavra)
        {
            foreach (char letra in apalavra)
            {
                if (char.IsDigit(letra))
                {                    
                    return true;
                }               
            }
            return false;
        }
        public static void mostraForca(bool vitoria)
        {
            if (vitoria) Console.WriteLine("acertou!!"); else Console.WriteLine("errou O T Á R I O");

            Console.WriteLine("vidas = " + vidas);
            hangMan();
            Console.WriteLine();
            Console.WriteLine("TOTAL DE LETRAS DA PALAVRA: " + palavraSecreta.Length);
            Console.WriteLine();
            foreach (string letra in palavraDescoberta)
            {
                if (letra == null)
                {
                    Console.Write("_");
                    
                }
                else
                {
                    Console.Write(letra);                    
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void hangMan()
        {
            switch (vidas)
            {
                case 6:
                    Console.WriteLine(Hangman.vivo);
                    break;
                case 5:
                    Console.WriteLine(Hangman.PEsq);
                    break;
                case 4:
                    Console.WriteLine(Hangman.B);
                    break;
                case 3:
                    Console.WriteLine(Hangman.BEsq);
                    break;
                case 2:
                    Console.WriteLine(Hangman.T);
                    break;
                case 1:
                    Console.WriteLine(Hangman.C);
                    break;
                default:
                    break;
            }
        }
    }
}
