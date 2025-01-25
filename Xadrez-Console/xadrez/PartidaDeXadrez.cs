using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;
using Xadrez_Console.tabuleiro;

namespace Xadrez_Console.xadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro Tab {  get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada {  get; private set; }

        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino) 
        {
            Peca p = Tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = Tab.retirarPeca(destino);
            Tab.colocarPeca(p, destino);
        }

        public void validarPosicaoDeOrigem(Posicao pos) 
        {
            if (Tab.peca(pos) == null) 
            {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida!");
            }
            if (JogadorAtual != Tab.peca(pos).cor) 
            {
                throw new TabuleiroException("A peça de origem escolhida não é sua!");
            }
            if (!Tab.peca(pos).existeMovimentosPossiveis()) 
            {
                throw new TabuleiroException("Não há movimentos possiveis para a peça escolhida!");
            }
        }

        public void validarPosicaoDestino(Posicao origem, Posicao destino) 
        {
            if (!Tab.peca(origem).podeMoverPara(destino)) 
            {
                throw new TabuleiroException("Posição de tabuleiro inválida!");
            }
        }

        public void realizaJogada(Posicao origem, Posicao destino) 
        {
            executaMovimento(origem, destino);
            Turno++;
            mudaJogador();
        }

        private void mudaJogador()
        {
            if (JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Preta;
            }
            else 
            {
                JogadorAtual = Cor.Branca;
            }
        }

        private void colocarPecas() 
        {
            Tab.colocarPeca(new Rei(Tab, Cor.Branca), new PosicaoXadrez('c', 1).toPosicao());
        }
    }
}
