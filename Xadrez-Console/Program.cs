using System;
using tabuleiro;
using xadrez;
using Xadrez_Console;
using Xadrez_Console.tabuleiro;
using Xadrez_Console.xadrez;



PartidaDeXadrez partida = new PartidaDeXadrez();

while (!partida.Terminada) 
{
    try
    {
        Console.Clear();
        Tela.imprimirPartida(partida);

        Console.Write("Origem: ");
        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
        partida.validarPosicaoDeOrigem(origem);

        bool[,] posicoesPossiveis = partida.Tab.peca(origem).movimentosPossiveis();

        Console.Clear();
        Tela.imprimirTabuleiro(partida.Tab, posicoesPossiveis);

        Console.WriteLine();
        Console.Write("Destino: ");
        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
        partida.validarPosicaoDestino(origem, destino);

        partida.realizaJogada(origem, destino);
    }
    catch (TabuleiroException e) 
    { 
        Console.WriteLine(e.Message);
        Console.ReadLine();
    }
}

Console.ReadLine();
