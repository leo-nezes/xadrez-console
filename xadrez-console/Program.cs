using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez posicao = new PosicaoXadrez('c', 7);

            Console.WriteLine(posicao);

            Console.WriteLine(posicao.ToPosicao());

            Console.ReadLine();
        }
    }
}
