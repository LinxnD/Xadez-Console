using tabuleiro;
using Xadrez_Console.tabuleiro;

namespace xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) 
        {

        }

        public override string ToString() 
        {
            return "R";
        }

        private bool podeMover(Posicao pos) 
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis() 
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];


            //acima
            posicao.definirValores(posicao.Linha - 1, posicao.Coluna);
            if (tab.posicaoValida(posicao) && podeMover(posicao)) 
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //NE
            posicao.definirValores(posicao.Linha - 1, posicao.Coluna + 1);
            if (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //direita
            posicao.definirValores(posicao.Linha , posicao.Coluna + 1);
            if (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //SE
            posicao.definirValores(posicao.Linha - 1, posicao.Coluna +1);
            if (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //abaixo
            posicao.definirValores(posicao.Linha +1, posicao.Coluna);
            if (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //SO
            posicao.definirValores(posicao.Linha + 1, posicao.Coluna - 1);
            if (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //esquerda
            posicao.definirValores(posicao.Linha, posicao.Coluna - 1);
            if (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //NO
            posicao.definirValores(posicao.Linha - 1, posicao.Coluna -1);
            if (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            return mat;
        }
    }
}
