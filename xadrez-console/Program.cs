using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new(8, 8);

            tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
            tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
            tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tabuleiro);

            Console.ReadLine();
        }
    }
}
