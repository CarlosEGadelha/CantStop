﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CantStopServer;

namespace CantStop
{
    public partial class Tabuleiro : Form
    {
        public static int idPlayer { get; set; }
        public static int idPartidaAtual { get; set; }
        public static string senhaPlayer { get; set; }
        public static string corJogadorAtual { get; set; }

        public Tabuleiro(int idJogador, string senhaJogador, int idPartida)
        {
            //Chama o Lobby
            //Lobby lobby = new Lobby();
            //lobby.ShowDialog();

            InitializeComponent();

            idPlayer = idJogador;
            senhaPlayer = senhaJogador;
            idPartidaAtual = idPartida;
            txtConsole.Text = Jogo.IniciarPartida(idPlayer, senhaPlayer);

            //string retorno = Jogo.IniciarPartida(idJogador, senhaJogador);
            //txtConsole.Text = retorno.Substring(5);

            //Exibe os jogadores da partida que foi selecionada lá no lobby
            //textBox1.Text = Jogo.ListarJogadores(lobby.idPartida);
        }

        private void btnRolarDados_Click_1(object sender, EventArgs e)
        {
            Lobby lobby = new Lobby();

            string retorno = Jogo.RolarDados(idPlayer, senhaPlayer);

            if (retorno.Substring(0, 4) != "ERRO")
            {
                string[] x = retorno.Split('\n');

                txtConsole.Text = x[0].Substring(1) + '\n'
                    + x[1].Substring(1) + '\n'
                    + x[2].Substring(1) + '\n'
                    + x[3].Substring(1);
            }
            else
            {
                txtConsole.Text = retorno.Substring(5);
            }

        }

        private void btnExibirTabuleiro_Click(object sender, EventArgs e)
        {
            txtTabuleiro.Text = Jogo.ExibirTabuleiro(idPartidaAtual);
            string retorno = Jogo.ExibirTabuleiro(idPartidaAtual);

            int[] posX = new int[11];
            posX[0] = 417;
            posX[1] = 445;
            posX[2] = 478;
            posX[3] = 506;
            posX[4] = 534;
            posX[5] = 563;
            posX[6] = 595;
            posX[7] = 623;
            posX[8] = 648;
            posX[9] = 677;
            posX[10] = 698;

            int[] posY = new int[11];
            posY[0] = 307;
            posY[1] = 346;
            posY[2] = 369;
            posY[3] = 407;
            posY[4] = 432;
            posY[5] = 459;
            posY[6] = 432;
            posY[7] = 405;
            posY[8] = 369;
            posY[9] = 335;
            posY[10] = 316;

            retorno = retorno.Replace("\r", "");
            string[] linha = retorno.Split('\n');
            List<Pino> listaPinos = new List<Pino>();

            for (int i = 0; i < linha.Length - 1; i++)
            {
                Pino novoP = new Pino();
                string[] items = linha[i].Split(',');
                novoP.Coluna = Convert.ToInt32(items[0]);
                novoP.Linha = Convert.ToInt32(items[1]);
                novoP.idJogador = Convert.ToInt32(items[2]);
                novoP.Base = items[3];
                listaPinos.Add(novoP);
            }

            string retornoJogador = Jogo.ListarJogadores(idPartidaAtual);

            retornoJogador = retornoJogador.Replace("\r", "");
            string[] linhaJogador = retornoJogador.Split('\n');
            List<Jogador> listaJogadores = new List<Jogador>();

            for (int i = 0; i < linhaJogador.Length - 1; i++)
            {
                Jogador novoJ = new Jogador();
                string[] items = linhaJogador[i].Split(',');
                novoJ.id = Convert.ToInt32(items[0]);
                novoJ.nome = items[1];
                novoJ.cor = items[2];
                listaJogadores.Add(novoJ);
            }

            foreach(Pino pino in listaPinos)
            {
                PictureBox pBox = new PictureBox();
                int X = posX[pino.Coluna - 2];
                int Y = posY[pino.Coluna - 2] - pino.Linha*(30);
                pBox.Location = new Point(X, Y);
                //Nome
                pBox.Name = pino.idJogador.ToString();
                //Tamanho
                pBox.Height = 20;
                pBox.Width = 20;
                
                foreach(Jogador jogador in listaJogadores)
                {
                    if(jogador.id == pino.idJogador)
                    {
                        corJogadorAtual = jogador.cor;
                    }
                }
                
                if(corJogadorAtual == "Vermelho")
                {
                    pBox.BackColor = Color.Red;
                }
                else if (corJogadorAtual == "Azul")
                {
                    pBox.BackColor = Color.Blue;
                }
                else if (corJogadorAtual == "Verde")
                {
                    pBox.BackColor = Color.Green;
                }
                else
                {
                    pBox.BackColor = Color.Yellow;
                }
                
                
                //pBox.Image = Image.FromFile(@"C:\Users\Second\Desktop\CantStop\CantStop\Resources\pinoVermelho.png");
                //Adiciona o controle ao Form
                Controls.Add(pBox);
                picTabuleiro.SendToBack();
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            txtConsole.Text = Jogo.Parar(idPlayer, senhaPlayer);
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            string ordem = txtOrdem.Text;
            string trilha = txtTrilha.Text;
            txtConsole.Text = Jogo.Mover(idPlayer, senhaPlayer, ordem, trilha);
            txtOrdem.Text = "";
            txtTrilha.Text = "";
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            txtConsole.Text = Jogo.VerificarVez(idPartidaAtual);
        }
    }
}
