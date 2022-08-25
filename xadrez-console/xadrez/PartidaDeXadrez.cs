using System;
using tabuleiro;

namespace xadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro _tabuleiro { get; private set; }
        private int _turno;
        private Cor _jogadorAtual;

        public PartidaDeXadrez()
        {
            _tabuleiro = new Tabuleiro(8, 8);
            _turno = 1;
            _jogadorAtual = Cor.Branca;
            ColocarPecas();
        }

        public void ExcecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca peca = _tabuleiro.RetirarPeca(origem);
            peca.IncrementarQuantidadeMovimentos();
            Peca pecaCapturada = _tabuleiro.RetirarPeca(destino);
            _tabuleiro.ColocarPeca(peca, destino);
        }

        private void ColocarPecas()
        {
            _tabuleiro.ColocarPeca(new Torre(_tabuleiro, Cor.Branca), new PosicaoXadrez('c', 1).ToPosicao());
            _tabuleiro.ColocarPeca(new Torre(_tabuleiro, Cor.Branca), new PosicaoXadrez('c', 2).ToPosicao());
            _tabuleiro.ColocarPeca(new Torre(_tabuleiro, Cor.Branca), new PosicaoXadrez('d', 2).ToPosicao());
            _tabuleiro.ColocarPeca(new Torre(_tabuleiro, Cor.Branca), new PosicaoXadrez('e', 2).ToPosicao());
            _tabuleiro.ColocarPeca(new Torre(_tabuleiro, Cor.Branca), new PosicaoXadrez('e', 1).ToPosicao());
            _tabuleiro.ColocarPeca(new Rei(_tabuleiro, Cor.Branca), new PosicaoXadrez('d', 1).ToPosicao());

            _tabuleiro.ColocarPeca(new Torre(_tabuleiro, Cor.Preta), new PosicaoXadrez('c', 7).ToPosicao());
            _tabuleiro.ColocarPeca(new Torre(_tabuleiro, Cor.Preta), new PosicaoXadrez('c', 8).ToPosicao());
            _tabuleiro.ColocarPeca(new Torre(_tabuleiro, Cor.Preta), new PosicaoXadrez('d', 7).ToPosicao());
            _tabuleiro.ColocarPeca(new Torre(_tabuleiro, Cor.Preta), new PosicaoXadrez('e', 7).ToPosicao());
            _tabuleiro.ColocarPeca(new Torre(_tabuleiro, Cor.Preta), new PosicaoXadrez('e', 8).ToPosicao());
            _tabuleiro.ColocarPeca(new Rei(_tabuleiro, Cor.Preta), new PosicaoXadrez('d', 8).ToPosicao());
        }
     }
}
