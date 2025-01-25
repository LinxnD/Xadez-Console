using tabuleiro;
using Xadrez_Console.tabuleiro;

namespace xadrez
{
    internal class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "T";
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
            while (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (tab.peca(posicao) != null && tab.peca(posicao).cor != cor)
                {
                    break;
                }
                posicao.Linha = posicao.Linha - 1;
            }

            //abaixo
            posicao.definirValores(posicao.Linha + 1, posicao.Coluna);
            while (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (tab.peca(posicao) != null && tab.peca(posicao).cor != cor)
                {
                    break;
                }
                posicao.Linha = posicao.Linha + 1;
            }

            //direita
            posicao.definirValores(posicao.Linha, posicao.Coluna + 1);
            while (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (tab.peca(posicao) != null && tab.peca(posicao).cor != cor)
                {
                    break;
                }
                posicao.Coluna = posicao.Coluna + 1;
            }

            //esquerda
            posicao.definirValores(posicao.Linha, posicao.Coluna - 1);
            while (tab.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (tab.peca(posicao) != null && tab.peca(posicao).cor != cor)
                {
                    break;
                }
                posicao.Coluna = posicao.Coluna - 1;
            }

            return mat;
        }
    }
}