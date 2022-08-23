﻿using System;
using Tabuleiro;

namespace xadrez_console
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro.Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if(tabuleiro.Peca(i, j) == null)
                        Console.Write("- ");
                    else
                        Console.Write(tabuleiro.Peca(i, j) + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
