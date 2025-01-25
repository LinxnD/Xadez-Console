using System;
using tabuleiro;
using xadrez;
using Xadrez_Console;
using Xadrez_Console.tabuleiro;
using Xadrez_Console.xadrez;



PartidaDeXadrez partida = new PartidaDeXadrez();

while (!partida.Terminada) 
{
    Console.Clear();
    Tela.imprimirTabuleiro(partida.Tab);

    Console.Write("Origem: ");
    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

    bool[,] posicoesPossiveis = partida.Tab.peca(origem).movimentosPossiveis();

    Console.Clear();
    Tela.imprimirTabuleiro(partida.Tab, posicoesPossiveis);

    Console.WriteLine();
    Console.Write("Destino: ");
    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

    partida.executaMovimento(origem, destino);
}







Console.ReadLine();
