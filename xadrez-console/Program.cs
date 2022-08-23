using System;
using Tabuleiro;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro.Tabuleiro tabuleiro = new(8, 8);

            Tela.ImprimirTabuleiro(tabuleiro);

            Console.ReadLine();
        }
    }
}
