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
        private int Turno;
        private Cor JogadorAtual;
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

        private void colocarPecas() 
        {
            Tab.colocarPeca(new Rei(Tab, Cor.Branca), new PosicaoXadrez('c', 1).toPosicao());
        }
    }
}
