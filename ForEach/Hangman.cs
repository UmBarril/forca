using System;
using System.Collections.Generic;
using System.Text;

namespace Forca
{
    class Hangman
    {
        // P = PERNA COMPLETO     
        // B = BRACO COMPLETO
        // C = CABECA SEM T
        // T = TRONCO SEM B
        // Esq = APENAS PERNA/BRACO ESQUERDO

        //COMECA DO LADO DIREITO
        //PERNA PARA A CABECA


       public readonly static string vivo = "=========\n" +
                                            "  +---+\n" +
                                            "  |   |\n" +
                                            "  O   |\n" +
                                            " /|\\  |\n" +
                                            " / \\  |\n" +
                                            "      |\n" +
                                            "=========";
        public readonly static string PEsq ="=========\n" +
                                            "  +---+\n" +
                                            "  |   |\n" +
                                            "  O   |\n" +
                                            " /|\\  |\n" +
                                            " /    |\n" +
                                            "      |\n" +
                                            "=========";
        public readonly static string T =   "=========\n" +
                                            "  +---+\n" +
                                            "  |   |\n" +
                                            "  O   |\n" +
                                            "  |   |\n" +
                                            "      |\n" +
                                            "      |\n" +
                                            "=========";
        public readonly static string B    ="=========\n" +
                                            "  +---+\n" +
                                            "  |   |\n" +
                                            "  O   |\n" +
                                            " /|\\  |\n" +
                                            "      |\n" +
                                            "      |\n" +
                                            "=========";
        public readonly static string BEsq ="=========\n" +
                                            "  +---+\n" +
                                            "  |   |\n" +
                                            "  O   |\n" +
                                            " /|   |\n" +
                                            "      |\n" +
                                            "      |\n" +
                                            "=========";
        public readonly static string C =   "=========\n" +
                                            "  +---+\n" +
                                            "  |   |\n" +
                                            "  O   |\n" +
                                            "      |\n" +
                                            "      |\n" +
                                            "      |\n" +
                                            "=========";
        public readonly static string ded = "=========\n" +
                                            "  +---+\n" +
                                            "  |   |\n" +
                                            "      |\n" +
                                            "      |\n" +
                                            "      |\n" +
                                            "      |\n" +
                                            "=========";
    }
}
