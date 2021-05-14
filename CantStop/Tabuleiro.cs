using System;
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
    public partial class frmTabuleiro : Form
    {
        public static int idPlayer { get; set; }
        public static int idPartidaAtual { get; set; }
        public static string senhaPlayer { get; set; }
        public string corJogadorAtual { get; set; }
        public static string corJogador { get; set; }
        public static string baseJogo { get; set; }

        string trilhaMover = "";
        string escolha01 = "";
        string escolha02 = "";
        string escolha03 = "";
        string escolha04 = "";
        string escolha05 = "";
        string escolha06 = "";
        string escolha07 = "";
        string escolha08 = "";
        string escolha09 = "";
        string escolha10 = "";
        string escolha11 = "";
        string escolha12 = "";

        int qntRodadas = 0;

        bool vezJogador = false;
        int qtdJogadas = 0;
        string ordemMover = "1234";
        int teste = 0;
        int teste2 = 0;
        int teste3 = 0;

        List<PictureBox> listaPbox = new List<PictureBox>();
        List<Jogador> listaJogadores = new List<Jogador>();

        public frmTabuleiro(int idJogador, string senhaJogador, int idPartida, string cor)
        {
            InitializeComponent();
            lblVersao.Text = "Versão " + Jogo.Versao;

            idPlayer = idJogador;
            senhaPlayer = senhaJogador;
            idPartidaAtual = idPartida;
            corJogador = cor;

            string retorno = Jogo.IniciarPartida(idPlayer, senhaPlayer);

            string retornoJogador = Jogo.ListarJogadores(idPartidaAtual);

            retornoJogador = retornoJogador.Replace("\r", "");
            string[] linhaJogador = retornoJogador.Split('\n');
            for (int i = 0; i < linhaJogador.Length - 1; i++)
            {
                Jogador novoJ = new Jogador();
                string[] items = linhaJogador[i].Split(',');
                novoJ.id = Convert.ToInt32(items[0]);
                novoJ.nome = items[1];
                novoJ.cor = items[2];
                listaJogadores.Add(novoJ);
            }

            if (retorno.Substring(0, 1) != "E")
            {
                string retornoVez = Jogo.VerificarVez(idPartidaAtual);
                string[] vez = retornoVez.Split(',');
                string turno = vez[1];

                foreach (Jogador jogador in listaJogadores)
                {
                    if (jogador.id == Convert.ToInt32(turno))
                    {
                        this.corJogadorAtual = jogador.cor;
                    }
                }
            }
            else
            {
                string retornoVez = Jogo.VerificarVez(idPartidaAtual);
                string[] vez = retornoVez.Split(',');
                string turno = vez[1];

                foreach (Jogador jogador in listaJogadores)
                {
                    if (jogador.id == Convert.ToInt32(turno))
                    {
                        this.corJogadorAtual = jogador.cor;
                    }
                }
            }

            if (corJogador == "Vermelho")
            {
                picSuaCor.Image = Properties.Resources.vermelho;
            }
            else if (corJogador == "Azul")
            {
                picSuaCor.Image = Properties.Resources.azul;
            }
            else if (corJogador == "Amarelo")
            {
                picSuaCor.Image = Properties.Resources.amarelo;
            }
            else if (corJogador == "Verde")
            {
                picSuaCor.Image = Properties.Resources.verde;
            }

            if (corJogadorAtual == "Vermelho")
            {
                picJogadorVez.Image = Properties.Resources.vermelho;
            }
            else if (corJogadorAtual == "Azul")
            {
                picJogadorVez.Image = Properties.Resources.azul;
            }
            else if (corJogadorAtual == "Amarelo")
            {
                picJogadorVez.Image = Properties.Resources.amarelo;
            }
            else if (corJogadorAtual == "Verde")
            {
                picJogadorVez.Image = Properties.Resources.verde;
            }

            lblInfoJogador.Text = idJogador + ". " + senhaJogador + ". " + corJogador;
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            txtConsole.Text = Jogo.Parar(idPlayer, senhaPlayer);
            lblCombinacoes.Text = "";
            qtdJogadas = 0;
        }

        public void ExibirHistorico()
        {
            txtHistorico.Text = Jogo.ExibirHistorico(idPartidaAtual);
        }

        public void ExibirTabuleiro()
        {
            string retorno = Jogo.ExibirTabuleiro(idPartidaAtual);

            int[] posX = new int[11];
            posX[0] = 378;
            posX[1] = 414;
            posX[2] = 451;
            posX[3] = 487;
            posX[4] = 523;
            posX[5] = 560;
            posX[6] = 597;
            posX[7] = 633;
            posX[8] = 670;
            posX[9] = 706;
            posX[10] = 742;

            int[] posY = new int[11];
            posY[0] = 319;
            posY[1] = 352;
            posY[2] = 385;
            posY[3] = 418;
            posY[4] = 451;
            posY[5] = 484;
            posY[6] = 451;
            posY[7] = 418;
            posY[8] = 385;
            posY[9] = 352;
            posY[10] = 319;

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

            foreach (PictureBox pBox in listaPbox)
            {
                this.Controls.Remove(pBox);
            }

            listaPbox.Clear();

            foreach (Pino pino in listaPinos)
            {
                PictureBox pBox = new PictureBox();

                int X = posX[pino.Coluna - 2];
                int Y = posY[pino.Coluna - 2] - pino.Linha * (33);
                pBox.Name = pino.idJogador.ToString();
                pBox.Height = 10;
                pBox.Width = 10;

                foreach (Jogador jogador in listaJogadores)
                {
                    if (jogador.id == pino.idJogador)
                    {
                        corJogadorAtual = jogador.cor;
                    }
                }

                if (pino.Base == "A")
                {
                    pBox.Image = Properties.Resources.preto;
                }
                else if (corJogadorAtual == "Vermelho")
                {
                    Y -= 5;
                    X -= 5;
                    pBox.Image = Properties.Resources.vermelho;
                }
                else if (corJogadorAtual == "Azul")
                {
                    Y += 5;
                    X -= 5;
                    pBox.Image = Properties.Resources.azul;
                }
                else if (corJogadorAtual == "Verde")
                {
                    Y += 5;
                    X += 5;
                    pBox.Image = Properties.Resources.verde;
                }
                else
                {
                    Y -= 5;
                    X += 5;
                    pBox.Image = Properties.Resources.amarelo;
                }

                pBox.Location = new Point(X, Y);
                listaPbox.Add(pBox);
                Controls.Add(listaPbox.Last());
                listaPbox.Last().BringToFront();
            }
        }

        public void RolarDados()
        {
            string retorno = Jogo.RolarDados(idPlayer, senhaPlayer);

            if (retorno.Substring(0, 4) != "ERRO")
            {
                string[] x = retorno.Split('\n');

                if (Convert.ToInt32(x[0].Substring(1)) == 1)
                {
                    picDado1.Image = Properties.Resources.facesDado_1;
                    Size size = new Size(50, 50);
                    picDado1.Size = size;
                    picDado1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Convert.ToInt32(x[0].Substring(1)) == 2)
                {
                    picDado1.Image = Properties.Resources.facesDado_2;
                    Size size = new Size(50, 50);
                    picDado1.Size = size;
                    picDado1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Convert.ToInt32(x[0].Substring(1)) == 3)
                {
                    picDado1.Image = Properties.Resources.facesDado_3;
                    Size size = new Size(50, 50);
                    picDado1.Size = size;
                    picDado1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Convert.ToInt32(x[0].Substring(1)) == 4)
                {
                    picDado1.Image = Properties.Resources.facesDado_4;
                    Size size = new Size(50, 50);
                    picDado1.Size = size;
                    picDado1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Convert.ToInt32(x[0].Substring(1)) == 5)
                {
                    picDado1.Image = Properties.Resources.facesDado_5;
                    Size size = new Size(50, 50);
                    picDado1.Size = size;
                    picDado1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Convert.ToInt32(x[0].Substring(1)) == 6)
                {
                    picDado1.Image = Properties.Resources.facesDado_6;
                    Size size = new Size(50, 50);
                    picDado1.Size = size;
                    picDado1.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                if (Convert.ToInt32(x[1].Substring(1)) == 1)
                {
                    picDado2.Image = Properties.Resources.facesDado_1;
                    Size size = new Size(50, 50);
                    picDado2.Size = size;
                    picDado2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Convert.ToInt32(x[1].Substring(1)) == 2)
                {
                    picDado2.Image = Properties.Resources.facesDado_2;
                    Size size = new Size(50, 50);
                    picDado2.Size = size;
                    picDado2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Convert.ToInt32(x[1].Substring(1)) == 3)
                {
                    picDado2.Image = Properties.Resources.facesDado_3;
                    Size size = new Size(50, 50);
                    picDado2.Size = size;
                    picDado2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Convert.ToInt32(x[1].Substring(1)) == 4)
                {
                    picDado2.Image = Properties.Resources.facesDado_4;
                    Size size = new Size(50, 50);
                    picDado2.Size = size;
                    picDado2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Convert.ToInt32(x[1].Substring(1)) == 5)
                {
                    picDado2.Image = Properties.Resources.facesDado_5;
                    Size size = new Size(50, 50);
                    picDado2.Size = size;
                    picDado2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Convert.ToInt32(x[1].Substring(1)) == 6)
                {
                    picDado2.Image = Properties.Resources.facesDado_6;
                    Size size = new Size(50, 50);
                    picDado2.Size = size;
                    picDado2.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                if (Convert.ToInt32(x[2].Substring(1)) == 1)
                {
                    picDado3.Image = Properties.Resources.facesDado_1;
                    Size size = new Size(50, 50);
                    picDado3.Size = size;
                    picDado3.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Convert.ToInt32(x[2].Substring(1)) == 2)
                {
                    picDado3.Image = Properties.Resources.facesDado_2;
                    Size size = new Size(50, 50);
                    picDado3.Size = size;
                    picDado3.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Convert.ToInt32(x[2].Substring(1)) == 3)
                {
                    picDado3.Image = Properties.Resources.facesDado_3;
                    Size size = new Size(50, 50);
                    picDado3.Size = size;
                    picDado3.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Convert.ToInt32(x[2].Substring(1)) == 4)
                {
                    picDado3.Image = Properties.Resources.facesDado_4;
                    Size size = new Size(50, 50);
                    picDado3.Size = size;
                    picDado3.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Convert.ToInt32(x[2].Substring(1)) == 5)
                {
                    picDado3.Image = Properties.Resources.facesDado_5;
                    Size size = new Size(50, 50);
                    picDado3.Size = size;
                    picDado3.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Convert.ToInt32(x[2].Substring(1)) == 6)
                {
                    picDado3.Image = Properties.Resources.facesDado_6;
                    Size size = new Size(50, 50);
                    picDado3.Size = size;
                    picDado3.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                if (Convert.ToInt32(x[3].Substring(1)) == 1)
                {
                    picDado4.Image = Properties.Resources.facesDado_1;
                    Size size = new Size(50, 50);
                    picDado4.Size = size;
                    picDado4.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Convert.ToInt32(x[3].Substring(1)) == 2)
                {
                    picDado4.Image = Properties.Resources.facesDado_2;
                    Size size = new Size(50, 50);
                    picDado4.Size = size;
                    picDado4.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Convert.ToInt32(x[3].Substring(1)) == 3)
                {
                    picDado4.Image = Properties.Resources.facesDado_3;
                    Size size = new Size(50, 50);
                    picDado4.Size = size;
                    picDado4.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Convert.ToInt32(x[3].Substring(1)) == 4)
                {
                    picDado4.Image = Properties.Resources.facesDado_4;
                    Size size = new Size(50, 50);
                    picDado4.Size = size;
                    picDado4.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Convert.ToInt32(x[3].Substring(1)) == 5)
                {
                    picDado4.Image = Properties.Resources.facesDado_5;
                    Size size = new Size(50, 50);
                    picDado4.Size = size;
                    picDado4.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (Convert.ToInt32(x[3].Substring(1)) == 6)
                {
                    picDado4.Image = Properties.Resources.facesDado_6;
                    Size size = new Size(50, 50);
                    picDado4.Size = size;
                    picDado4.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                int comb01 = Convert.ToInt32(x[0].Substring(1)) + Convert.ToInt32(x[1].Substring(1));
                int comb02 = Convert.ToInt32(x[2].Substring(1)) + Convert.ToInt32(x[3].Substring(1));

                int comb03 = Convert.ToInt32(x[0].Substring(1)) + Convert.ToInt32(x[3].Substring(1));
                int comb04 = Convert.ToInt32(x[1].Substring(1)) + Convert.ToInt32(x[2].Substring(1));

                int comb05 = Convert.ToInt32(x[2].Substring(1)) + Convert.ToInt32(x[0].Substring(1));
                int comb06 = Convert.ToInt32(x[1].Substring(1)) + Convert.ToInt32(x[3].Substring(1));

                string combi01 = comb01.ToString();
                string combi02 = comb02.ToString();

                string combi03 = comb03.ToString();
                string combi04 = comb04.ToString();

                string combi05 = comb05.ToString();
                string combi06 = comb06.ToString();

                if (comb01 == 10)
                {
                    combi01 = "A";
                }
                else if (comb01 == 11)
                {
                    combi01 = "B";
                }
                else if (comb01 == 12)
                {
                    combi01 = "C";
                }

                if (comb02 == 10)
                {
                    combi02 = "A";
                }
                else if (comb02 == 11)
                {
                    combi02 = "B";
                }
                else if (comb02 == 12)
                {
                    combi02 = "C";
                }

                // ------------------------------------ //

                if (comb03 == 10)
                {
                    combi03 = "A";
                }
                else if (comb03 == 11)
                {
                    combi03 = "B";
                }
                else if (comb03 == 12)
                {
                    combi03 = "C";
                }

                if (comb04 == 10)
                {
                    combi04 = "A";
                }
                else if (comb04 == 11)
                {
                    combi04 = "B";
                }
                else if (comb04 == 12)
                {
                    combi04 = "C";
                }

                // ------------------------------------ //

                if (comb05 == 10)
                {
                    combi05 = "A";
                }
                else if (comb05 == 11)
                {
                    combi05 = "B";
                }
                else if (comb05 == 12)
                {
                    combi05 = "C";
                }

                if (comb06 == 10)
                {
                    combi06 = "A";
                }
                else if (comb06 == 11)
                {
                    combi06 = "B";
                }
                else if (comb06 == 12)
                {
                    combi06 = "C";
                }

                trilhaMover = combi01 + combi02;
                escolha01 = combi01 + combi02;
                escolha02 = combi03 + combi04;
                escolha03 = combi05 + combi06;
                escolha04 = combi02 + combi01;
                escolha09 = combi04 + combi03;
                escolha10 = combi06 + combi05;

                escolha05 = combi01 + "0";
                escolha06 = combi02 + "0";
                escolha07 = combi03 + "0";
                escolha08 = combi04 + "0";
                escolha11 = combi05 + "0";
                escolha12 = combi06 + "0";

                lblCombinacoes.Text = "ORDEM [1234]: " + comb01 + " e " + comb02 + "\n"
                + "ORDEM [1423]: " + comb03 + " e " + comb04 + "\n"
                + "ORDEM [1324]: " + comb05 + " e " + comb06 + "\n";

                //else
                //{
                //    lblCombinacoes.Text = "ORDEM [12]: " + comb01 + " ou [34]: " + comb02 + "\n"
                //         + "ORDEM [14]: " + comb03 + "  ou [23]: " + comb04 + "\n"
                //         + "ORDEM [13]: " + comb05 + "  ou [24]: " + comb06 + "\n";
                //}
            }
            else
            {
                txtConsole.Text = retorno.Substring(5);
                //qtdJogadas = 0;
            }
        }

        public void VerificarVez()
        {
            string retornoVez = Jogo.VerificarVez(idPartidaAtual);

            if (retornoVez.Substring(0, 4) != "ERRO")
            {
                string[] vez = retornoVez.Split(',');
                string turno = vez[1];

                foreach (Jogador jogador in listaJogadores)
                {
                    if (jogador.id == Convert.ToInt32(turno))
                    {
                        this.corJogadorAtual = jogador.cor;
                    }
                }

                if (corJogadorAtual == "Vermelho")
                {
                    picJogadorVez.Image = Properties.Resources.vermelho;
                }
                else if (corJogadorAtual == "Azul")
                {
                    picJogadorVez.Image = Properties.Resources.azul;
                }
                else if (corJogadorAtual == "Amarelo")
                {
                    picJogadorVez.Image = Properties.Resources.amarelo;
                }
                else if (corJogadorAtual == "Verde")
                {
                    picJogadorVez.Image = Properties.Resources.verde;
                }

                if (Convert.ToInt32(turno) == idPlayer)
                {
                    vezJogador = true;
                }
                else
                {
                    vezJogador = false;
                }
            }
            else
            {
                tmrAtualizaTabuleiro.Stop();
                tmrAtualizacao.Stop();
                MessageBox.Show("Partida terminou! Temos um vencedor");
                VotarLobby();
            }
        }

        public void Mover()
        {
            lblTeste1.Text = teste.ToString();
            lblTeste2.Text = teste2.ToString();
            lblTeste3.Text = teste3.ToString();

            string ordem = ordemMover;
            string trilha = trilhaMover;
            string retorno = Jogo.Mover(idPlayer, senhaPlayer, ordem, trilha);

            if (retorno == "" || retorno.Substring(0, 4) != "ERRO")
            {
                trilhaMover = "";
                ordemMover = "1234";
                qtdJogadas++;
                teste = 0;
                teste2 = 0;
                teste3 = 0;
            }
            else if (retorno.Substring(0, 26) == "ERRO: Não é possível mover")
            {
                txtConsole.Text = retorno;

                if (teste == 0)
                {
                    trilhaMover = escolha02;
                    ordemMover = "1423";
                    teste++;
                }
                else if (teste == 1)
                {
                    trilhaMover = escolha03;
                    ordemMover = "1324";
                    teste++;
                }
                else if (teste == 2)
                {
                    trilhaMover = escolha04;
                    ordemMover = "3412";
                    teste++;
                }
                else if (teste == 3)
                {
                    trilhaMover = escolha09;
                    ordemMover = "2314";
                    teste++;
                }
                else if (teste == 4)
                {
                    trilhaMover = escolha10;
                    ordemMover = "2413";
                    teste++;
                }
                else if (teste == 5)
                {
                    trilhaMover = escolha05;
                    ordemMover = "1234";
                    teste++;
                }
                else if (teste == 6)
                {
                    trilhaMover = escolha06;
                    ordemMover = "3412";
                    teste++;
                }
                else if (teste == 7)
                {
                    trilhaMover = escolha07;
                    ordemMover = "1423";
                    teste++;
                }
                else if (teste == 8)
                {
                    trilhaMover = escolha08;
                    ordemMover = "2314";
                    teste++;
                }
                else if (teste == 9)
                {
                    trilhaMover = escolha11;
                    ordemMover = "1324";
                    teste++;
                }
                else if (teste == 10)
                {
                    trilhaMover = escolha12;
                    ordemMover = "2413";
                    teste = 0;
                }
            }
            else if (retorno.Substring(0, 15) == "ERRO:É possível")
            {
                txtConsole.Text = retorno;

                if (teste3 == 0)
                {
                    trilhaMover = escolha01;
                    ordemMover = "1234";
                    teste3++;
                }
                else if (teste3 == 1)
                {
                    trilhaMover = escolha02;
                    ordemMover = "1423";
                    teste3++;
                }
                else if (teste3 == 2)
                {
                    trilhaMover = escolha03;
                    ordemMover = "1324";
                    teste3++;
                }
                else if (teste3 == 3)
                {
                    trilhaMover = escolha04;
                    ordemMover = "3412";
                    teste3++;
                }
                else if (teste3 == 4)
                {
                    trilhaMover = escolha09;
                    ordemMover = "2314";
                    teste3++;
                }
                else if (teste3 == 5)
                {
                    trilhaMover = escolha10;
                    ordemMover = "2413";
                    teste3 = 0;
                }
            }
            else 
            {
                txtConsole.Text = retorno;

                if (teste2 == 0)
                {
                    trilhaMover = escolha02;
                    ordemMover = "1423";
                    teste2++;
                }
                else if (teste2 == 1)
                {
                    trilhaMover = escolha03;
                    ordemMover = "1324";
                    teste2++;
                }
                else if (teste2 == 2)
                {
                    trilhaMover = escolha04;
                    ordemMover = "3412";
                    teste2++;
                }
                else if (teste2 == 3)
                {
                    trilhaMover = escolha09;
                    ordemMover = "2314";
                    teste2++;
                }
                else if (teste2 == 4)
                {
                    trilhaMover = escolha10;
                    ordemMover = "2413";
                    teste2++;
                }
                else if (teste2 == 5)
                {
                    trilhaMover = escolha05;
                    ordemMover = "1234";
                    teste2++;
                }
                else if (teste2 == 6)
                {
                    trilhaMover = escolha06;
                    ordemMover = "3412";
                    teste2++;
                }
                else if (teste2 == 7)
                {
                    trilhaMover = escolha07;
                    ordemMover = "1423";
                    teste2++;
                }
                else if (teste2 == 8)
                {
                    trilhaMover = escolha08;
                    ordemMover = "2314";
                    teste2++;
                }
                else if (teste2 == 9)
                {
                    trilhaMover = escolha11;
                    ordemMover = "1324";
                    teste2++;
                }
                else if (teste2 == 10)
                {
                    trilhaMover = escolha12;
                    ordemMover = "2413";
                    teste2 = 0;
                }
            }
        }

        public void Parar()
        {
            txtConsole.Text = Jogo.Parar(idPlayer, senhaPlayer);
            lblCombinacoes.Text = "";
            //qtdJogadas = 0;
        }

        private void Tabuleiro_Load(object sender, EventArgs e)
        {
            tmrAtualizaTabuleiro.Enabled = true;
            tmrAtualizaTabuleiro.Start();
            tmrAtualizaTabuleiro.Interval = 2600;
            tmrAtualizaTabuleiro.Tick += new EventHandler(tmrAtualizaTabuleiro_Tick);

            tmrAtualizacao.Enabled = true;
            tmrAtualizacao.Start();
            tmrAtualizacao.Interval = 2600;
            tmrAtualizacao.Tick += new EventHandler(tmrAtualizacao_Tick);
        }

        private void tmrAtualizacao_Tick(object sender, EventArgs e)
        {
            VerificarVez();

            if(vezJogador == false)
            {
                qtdJogadas = 0;
                teste = 0;
                teste2 = 0;
                teste3 = 0;
            }

            if (qntRodadas < 5)
            {
                if (qtdJogadas < 5 && vezJogador == true)
                {
                    RolarDados();
                    Mover();
                }
                else if (qtdJogadas == 5)
                {
                    Parar();
                    qntRodadas++;
                }
            }
            else if (qntRodadas < 10)
            {
                if (qtdJogadas < 2 && vezJogador == true)
                {
                    RolarDados();
                    Mover();
                }
                else if (qtdJogadas == 2)
                {
                    Parar();
                    qntRodadas++;
                }
            }
            else
            {
                if (qtdJogadas < 1 && vezJogador == true)
                {
                    RolarDados();
                    Mover();
                }
                else if (qtdJogadas == 1)
                {
                    Parar();
                    qntRodadas++;
                }
            }
        }

        private void tmrAtualizaTabuleiro_Tick(object sender, EventArgs e)
        {
            ExibirTabuleiro();
            ExibirHistorico();
        }

        private void btnVoltarLobby_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void VotarLobby()
        {
            frmLobby form = new frmLobby();
            this.Close();
            form.Show();
        }
    }
}