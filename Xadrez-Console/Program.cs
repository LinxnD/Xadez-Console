using System;
using tabuleiro;
using xadrez;
using Xadrez_Console;
using Xadrez_Console.tabuleiro;


Tabuleiro tab = new Tabuleiro(8, 8);

tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

Tela.imprimirTabuleiro(tab);




Console.ReadLine();
