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

        //string trilhaMover = "";

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

        //string ordemMover = "1234";
        //int teste = 0;
        //int teste2 = 0;
        //int teste3 = 0;

        bool combinacao01 = false;
        bool combinacao02 = false;
        bool combinacao03 = false;

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

        //private void btnParar_Click(object sender, EventArgs e)
        //{
        //    txtConsole.Text = Jogo.Parar(idPlayer, senhaPlayer);
        //    lblCombinacoes.Text = "";
        //    qtdJogadas = 0;
        //}

        public void ExibirHistorico()
        {
            //lblHistorico.Text = Jogo.ExibirHistorico(idPartidaAtual);
            lblHistorico.Text = "";
            string retorno = Jogo.ExibirHistorico(idPartidaAtual);

            retorno = retorno.Replace("\r", "");
            string[] linha = retorno.Split('\n');

            int contador = linha.Length;
            if (linha.Length > 15)
            {
                contador = 15;
            }

            for (int i = 0; i < contador; i++)
            {
                lblHistorico.Text += linha[i] +  "\n";
            }
        }

        bool[] trilhasDominadas = new bool[11] { false, false, false, false, false, false, false, false, false, false, false };

        public void ExibirTabuleiro()
        {
            string trilhasDom = Jogo.VerificarTrilhas(idPartidaAtual);
            if (trilhasDom != "")
            {
                string[] linhaTrilha = trilhasDom.Split('\n');
                for (int i = 0; i < linhaTrilha.Length - 1; i++)
                {
                    string[] items = linhaTrilha[i].Split(',');
                    trilhasDominadas[Convert.ToInt32(items[0]) - 2] = true;
                }
            }

            string retorno = Jogo.ExibirTabuleiro(idPartidaAtual);

            int[] posX = new int[11];
            posX[0] = 495;
            posX[1] = 535;
            posX[2] = 575;
            posX[3] = 615;
            posX[4] = 655;
            posX[5] = 695;
            posX[6] = 735;
            posX[7] = 775;
            posX[8] = 815;
            posX[9] = 855;
            posX[10] = 895;

            int posY = 620;

            //int[] posY = new int[11];
            //posY[0] = 620;
            //posY[1] = 404;
            //posY[2] = 437;
            //posY[3] = 470;
            //posY[4] = 503;
            //posY[5] = 536;
            //posY[6] = 503;
            //posY[7] = 470;
            //posY[8] = 437;
            //posY[9] = 404;
            //posY[10] = 371;

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
                //int Y = posY[pino.Coluna - 2] - pino.Linha * (40);
                int Y = posY - pino.Linha * (40);
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
                    Y -= 6;
                    X -= 6;
                    pBox.Image = Properties.Resources.vermelho;
                }
                else if (corJogadorAtual == "Azul")
                {
                    Y += 6;
                    X -= 6;
                    pBox.Image = Properties.Resources.azul;
                }
                else if (corJogadorAtual == "Verde")
                {
                    Y += 6;
                    X += 6;
                    pBox.Image = Properties.Resources.verde;
                }
                else
                {
                    Y -= 6;
                    X += 6;
                    pBox.Image = Properties.Resources.amarelo;
                }

                pBox.Location = new Point(X, Y);
                listaPbox.Add(pBox);
                Controls.Add(listaPbox.Last());
                listaPbox.Last().BringToFront();
            }
        }

        //public void DadosOutroJogador()
        //{
        //    string retorno = Jogo.VerificarDados(idPartidaAtual);

        //    if (retorno.Substring(0, 4) != "ERRO")
        //    {
        //        string[] x = retorno.Split('\n');
        //        Size size = new Size(50, 50);

        //        if (Convert.ToInt32(x[0].Substring(11, 1)) == 1)
        //        {
        //            picDadoPlayer1.Image = Properties.Resources.facesDado_1;
        //            picDadoPlayer1.Size = size;
        //            picDadoPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //        else if (Convert.ToInt32(x[0].Substring(11, 1)) == 2)
        //        {
        //            picDadoPlayer1.Image = Properties.Resources.facesDado_2;
        //            picDadoPlayer1.Size = size;
        //            picDadoPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //        else if (Convert.ToInt32(x[0].Substring(11, 1)) == 3)
        //        {
        //            picDadoPlayer1.Image = Properties.Resources.facesDado_3;
        //            picDadoPlayer1.Size = size;
        //            picDadoPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //        else if (Convert.ToInt32(x[0].Substring(11, 1)) == 4)
        //        {
        //            picDadoPlayer1.Image = Properties.Resources.facesDado_4;
        //            picDadoPlayer1.Size = size;
        //            picDadoPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //        else if (Convert.ToInt32(x[0].Substring(11, 1)) == 5)
        //        {
        //            picDadoPlayer1.Image = Properties.Resources.facesDado_5;
        //            picDadoPlayer1.Size = size;
        //            picDadoPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //        else if (Convert.ToInt32(x[0].Substring(11, 1)) == 6)
        //        {
        //            picDadoPlayer1.Image = Properties.Resources.facesDado_6;
        //            picDadoPlayer1.Size = size;
        //            picDadoPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }

        //        if (Convert.ToInt32(x[1].Substring(11, 1)) == 1)
        //        {
        //            picDadoPlayer2.Image = Properties.Resources.facesDado_1;
        //            picDadoPlayer2.Size = size;
        //            picDadoPlayer2.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //        else if (Convert.ToInt32(x[1].Substring(11, 1)) == 2)
        //        {
        //            picDadoPlayer2.Image = Properties.Resources.facesDado_2;
        //            picDadoPlayer2.Size = size;
        //            picDadoPlayer2.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //        else if (Convert.ToInt32(x[1].Substring(11, 1)) == 3)
        //        {
        //            picDadoPlayer2.Image = Properties.Resources.facesDado_3;
        //            picDadoPlayer2.Size = size;
        //            picDadoPlayer2.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //        else if (Convert.ToInt32(x[1].Substring(11, 1)) == 4)
        //        {
        //            picDadoPlayer2.Image = Properties.Resources.facesDado_4;
        //            picDadoPlayer2.Size = size;
        //            picDadoPlayer2.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //        else if (Convert.ToInt32(x[1].Substring(11, 1)) == 5)
        //        {
        //            picDadoPlayer2.Image = Properties.Resources.facesDado_5;
        //            picDadoPlayer2.Size = size;
        //            picDadoPlayer2.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //        else if (Convert.ToInt32(x[1].Substring(11, 1)) == 6)
        //        {
        //            picDadoPlayer2.Image = Properties.Resources.facesDado_6;
        //            picDadoPlayer2.Size = size;
        //            picDadoPlayer2.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }

        //        if (Convert.ToInt32(x[2].Substring(11, 1)) == 1)
        //        {
        //            picDadoPlayer3.Image = Properties.Resources.facesDado_1;
        //            picDadoPlayer3.Size = size;
        //            picDadoPlayer3.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //        else if (Convert.ToInt32(x[2].Substring(11, 1)) == 2)
        //        {
        //            picDadoPlayer3.Image = Properties.Resources.facesDado_2;
        //            picDadoPlayer3.Size = size;
        //            picDadoPlayer3.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //        else if (Convert.ToInt32(x[2].Substring(11, 1)) == 3)
        //        {
        //            picDadoPlayer3.Image = Properties.Resources.facesDado_3;
        //            picDadoPlayer3.Size = size;
        //            picDadoPlayer3.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //        else if (Convert.ToInt32(x[2].Substring(11, 1)) == 4)
        //        {
        //            picDadoPlayer3.Image = Properties.Resources.facesDado_4;
        //            picDadoPlayer3.Size = size;
        //            picDadoPlayer3.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //        else if (Convert.ToInt32(x[2].Substring(11, 1)) == 5)
        //        {
        //            picDadoPlayer3.Image = Properties.Resources.facesDado_5;
        //            picDadoPlayer3.Size = size;
        //            picDadoPlayer3.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //        else if (Convert.ToInt32(x[2].Substring(11, 1)) == 6)
        //        {
        //            picDadoPlayer3.Image = Properties.Resources.facesDado_6;
        //            picDadoPlayer3.Size = size;
        //            picDadoPlayer3.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }

        //        if (Convert.ToInt32(x[3].Substring(11, 1)) == 1)
        //        {
        //            picDadoPlayer4.Image = Properties.Resources.facesDado_1;
        //            picDadoPlayer4.Size = size;
        //            picDadoPlayer4.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //        else if (Convert.ToInt32(x[3].Substring(11, 1)) == 2)
        //        {
        //            picDadoPlayer4.Image = Properties.Resources.facesDado_2;
        //            picDadoPlayer4.Size = size;
        //            picDadoPlayer4.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //        else if (Convert.ToInt32(x[3].Substring(11, 1)) == 3)
        //        {
        //            picDadoPlayer4.Image = Properties.Resources.facesDado_3;
        //            picDadoPlayer4.Size = size;
        //            picDadoPlayer4.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //        else if (Convert.ToInt32(x[3].Substring(11, 1)) == 4)
        //        {
        //            picDadoPlayer4.Image = Properties.Resources.facesDado_4;
        //            picDadoPlayer4.Size = size;
        //            picDadoPlayer4.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //        else if (Convert.ToInt32(x[3].Substring(11, 1)) == 5)
        //        {
        //            picDadoPlayer4.Image = Properties.Resources.facesDado_5;
        //            picDadoPlayer4.Size = size;
        //            picDadoPlayer4.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //        else if (Convert.ToInt32(x[3].Substring(11, 1)) == 6)
        //        {
        //            picDadoPlayer4.Image = Properties.Resources.facesDado_6;
        //            picDadoPlayer4.Size = size;
        //            picDadoPlayer4.SizeMode = PictureBoxSizeMode.StretchImage;
        //        }
        //    }
        //}

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

                escolha01 = combi01 + combi02;
                escolha02 = combi03 + combi04;
                escolha03 = combi05 + combi06;
                escolha04 = combi02 + combi01;
                escolha05 = combi04 + combi03;
                escolha06 = combi06 + combi05;

                escolha07 = combi01 + "0";
                escolha08 = combi02 + "0";
                escolha09 = combi03 + "0";
                escolha10 = combi04 + "0";
                escolha11 = combi05 + "0";
                escolha12 = combi06 + "0";

                if (combi01 == combi02)
                {
                    combinacao01 = true;
                }
                else if (combi03 == combi04)
                {
                    combinacao02 = true;
                }
                else if (combi05 == combi06)
                {
                    combinacao03 = true;
                }

                //trilhaMover = combi01 + combi02;
                //escolha01 = combi01 + combi02;
                //escolha02 = combi03 + combi04;
                //escolha03 = combi05 + combi06;
                //escolha04 = combi02 + combi01;
                //escolha09 = combi04 + combi03;
                //escolha10 = combi06 + combi05;

                //escolha05 = combi01 + "0";
                //escolha06 = combi02 + "0";
                //escolha07 = combi03 + "0";
                //escolha08 = combi04 + "0";
                //escolha11 = combi05 + "0";
                //escolha12 = combi06 + "0";

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
                lblErro.Text = retorno.Substring(5);
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
                MessageBox.Show(retornoVez.Substring(5));
                //MessageBox.Show("Jogador " + corJogadorAtual + " ganhou!!!");
                VotarLobby();
            }
        }

        // ---------------------------------------------------------------------------------------------- //

        int alpinistas = 3;

        string[] guardaPosicoes = new string[3];

        int[] penultimaPosicao = new int[11] { 2, 4, 6, 8, 10, 12, 10, 8, 6, 4, 2 };
        int[] ultimaPosicao = new int[11] { 3, 5, 7, 9, 11, 13, 11, 9, 7, 5, 3 };
        int[] posicaoJogador = new int[11];
        int[] posicaoJogadorBackup = new int[11];

        string teste01;
        string teste02;
        string teste03;
        string teste04;
        string teste05;
        string teste06;

        public void MoverSecundario()
        {
            string combi01 = escolha01.Substring(0, 1);
            string combi02 = escolha01.Substring(1, 1);
            string combi03 = escolha02.Substring(0, 1);
            string combi04 = escolha02.Substring(1, 1);
            string combi05 = escolha03.Substring(0, 1);
            string combi06 = escolha03.Substring(1, 1);

            teste01 = escolha01.Substring(0, 1);
            teste02 = escolha01.Substring(1, 1);
            teste03 = escolha02.Substring(0, 1);
            teste04 = escolha02.Substring(1, 1);
            teste05 = escolha03.Substring(0, 1);
            teste06 = escolha03.Substring(1, 1);


            if (escolha01.Substring(0, 1) == "A")
            {
                combi01 = "10";
            }
            else if (escolha01.Substring(0, 1) == "B")
            {
                combi01 = "11";
            }
            else if (escolha01.Substring(0, 1) == "C")
            {
                combi01 = "12";
            }

            if (escolha01.Substring(1, 1) == "A")
            {
                combi02 = "10";
            }
            else if (escolha01.Substring(1, 1) == "B")
            {
                combi02 = "11";
            }
            else if (escolha01.Substring(1, 1) == "C")
            {
                combi02 = "12";
            }

            if (escolha02.Substring(0, 1) == "A")
            {
                combi03 = "10";
            }
            else if (escolha02.Substring(0, 1) == "B")
            {
                combi03 = "11";
            }
            else if (escolha02.Substring(0, 1) == "C")
            {
                combi03 = "12";
            }

            if (escolha02.Substring(1, 1) == "A")
            {
                combi04 = "10";
            }
            else if (escolha02.Substring(1, 1) == "B")
            {
                combi04 = "11";
            }
            else if (escolha02.Substring(1, 1) == "C")
            {
                combi04 = "12";
            }

            if (escolha03.Substring(0, 1) == "A")
            {
                combi05 = "10";
            }
            else if (escolha03.Substring(0, 1) == "B")
            {
                combi05 = "11";
            }
            else if (escolha03.Substring(0, 1) == "C")
            {
                combi05 = "12";
            }

            if (escolha03.Substring(1, 1) == "A")
            {
                combi06 = "10";
            }
            else if (escolha03.Substring(1, 1) == "B")
            {
                combi06 = "11";
            }
            else if (escolha03.Substring(1, 1) == "C")
            {
                combi06 = "12";
            }

            if (alpinistas == 3)
            {
                if ((combinacao01 == true && posicaoJogador[Convert.ToInt32(combi01) - 2] == penultimaPosicao[Convert.ToInt32(combi01) - 2]) && trilhasDominadas[Convert.ToInt32(combi01) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha07);
                    guardaPosicoes[0] = escolha07.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi01) - 2] += 1;
                    alpinistas--;
                }
                else if ((combinacao02 == true && posicaoJogador[Convert.ToInt32(combi03) - 2] == penultimaPosicao[Convert.ToInt32(combi03) - 2]) && trilhasDominadas[Convert.ToInt32(combi03) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha09);
                    guardaPosicoes[0] = escolha09.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi03) - 2] += 1;
                    alpinistas--;
                }
                else if ((combinacao03 == true && posicaoJogador[Convert.ToInt32(combi05) - 2] == penultimaPosicao[Convert.ToInt32(combi05) - 2]) && trilhasDominadas[Convert.ToInt32(combi05) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha11);
                    guardaPosicoes[0] = escolha11.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi05) - 2] += 1;
                    alpinistas--;
                }

                else if (combinacao01 == true && trilhasDominadas[Convert.ToInt32(combi01) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha01);
                    guardaPosicoes[0] = escolha01.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi01) - 2] += 2;
                    alpinistas--;
                }
                else if (combinacao02 == true && trilhasDominadas[Convert.ToInt32(combi03) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha02);
                    guardaPosicoes[0] = escolha02.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi03) - 2] += 2;
                    alpinistas--;
                }
                else if (combinacao03 == true && trilhasDominadas[Convert.ToInt32(combi05) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha03);
                    guardaPosicoes[0] = escolha03.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi05) - 2] += 2;
                    alpinistas--;
                }
                else
                {
                    if (trilhasDominadas[Convert.ToInt32(combi01) - 2] == false && trilhasDominadas[Convert.ToInt32(combi02) - 2] == false)
                    {
                        Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha01);
                        guardaPosicoes[0] = escolha01.Substring(0, 1);
                        guardaPosicoes[1] = escolha01.Substring(1, 1);
                        posicaoJogador[Convert.ToInt32(combi01) - 2] += 1;
                        posicaoJogador[Convert.ToInt32(combi02) - 2] += 1;
                        alpinistas = 1;
                    }
                    else if (trilhasDominadas[Convert.ToInt32(combi03) - 2] == false && trilhasDominadas[Convert.ToInt32(combi04) - 2] == false)
                    {
                        Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha02);
                        guardaPosicoes[0] = escolha02.Substring(0, 1);
                        guardaPosicoes[1] = escolha02.Substring(1, 1);
                        posicaoJogador[Convert.ToInt32(combi03) - 2] += 1;
                        posicaoJogador[Convert.ToInt32(combi04) - 2] += 1;
                        alpinistas = 1;
                    }
                    else if (trilhasDominadas[Convert.ToInt32(combi05) - 2] == false && trilhasDominadas[Convert.ToInt32(combi06) - 2] == false)
                    {
                        Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha03);
                        guardaPosicoes[0] = escolha03.Substring(0, 1);
                        guardaPosicoes[1] = escolha03.Substring(1, 1);
                        posicaoJogador[Convert.ToInt32(combi05) - 2] += 1;
                        posicaoJogador[Convert.ToInt32(combi06) - 2] += 1;
                        alpinistas = 1;
                    }
                    else
                    {
                        if (trilhasDominadas[Convert.ToInt32(combi01) - 2] == false)
                        {
                            Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha07);
                            guardaPosicoes[0] = escolha07.Substring(0, 1);
                            posicaoJogador[Convert.ToInt32(combi01) - 2] += 1;
                            alpinistas--;
                        }
                        else if (trilhasDominadas[Convert.ToInt32(combi02) - 2] == false)
                        {
                            Jogo.Mover(idPlayer, senhaPlayer, "3412", escolha08);
                            guardaPosicoes[0] = escolha08.Substring(0, 1);
                            posicaoJogador[Convert.ToInt32(combi02) - 2] += 1;
                            alpinistas--;
                        }
                        else if (trilhasDominadas[Convert.ToInt32(combi03) - 2] == false)
                        {
                            Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha09);
                            guardaPosicoes[0] = escolha09.Substring(0, 1);
                            posicaoJogador[Convert.ToInt32(combi03) - 2] += 1;
                            alpinistas--;
                        }
                        else if (trilhasDominadas[Convert.ToInt32(combi04) - 2] == false)
                        {
                            Jogo.Mover(idPlayer, senhaPlayer, "2314", escolha10);
                            guardaPosicoes[0] = escolha10.Substring(0, 1);
                            posicaoJogador[Convert.ToInt32(combi04) - 2] += 1;
                            alpinistas--;
                        }
                        else if (trilhasDominadas[Convert.ToInt32(combi05) - 2] == false)
                        {
                            Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha11);
                            guardaPosicoes[0] = escolha11.Substring(0, 1);
                            posicaoJogador[Convert.ToInt32(combi05) - 2] += 1;
                            alpinistas--;
                        }
                        else if (trilhasDominadas[Convert.ToInt32(combi06) - 2] == false)
                        {
                            Jogo.Mover(idPlayer, senhaPlayer, "2413", escolha12);
                            guardaPosicoes[0] = escolha12.Substring(0, 1);
                            posicaoJogador[Convert.ToInt32(combi06) - 2] += 1;
                            alpinistas--;
                        }
                    }
                }
            }
            else if (alpinistas == 2)
            {
                if ((combinacao01 == true && posicaoJogador[Convert.ToInt32(combi01) - 2] == penultimaPosicao[Convert.ToInt32(combi01) - 2]) && trilhasDominadas[Convert.ToInt32(combi01) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha07);
                    guardaPosicoes[1] = escolha07.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi01) - 2] += 1;
                    alpinistas--;
                }
                else if ((combinacao02 == true && posicaoJogador[Convert.ToInt32(combi03) - 2] == penultimaPosicao[Convert.ToInt32(combi03) - 2]) && trilhasDominadas[Convert.ToInt32(combi03) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha09);
                    guardaPosicoes[1] = escolha09.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi03) - 2] += 1;
                    alpinistas--;
                }
                else if ((combinacao03 == true && posicaoJogador[Convert.ToInt32(combi05) - 2] == penultimaPosicao[Convert.ToInt32(combi05) - 2]) && trilhasDominadas[Convert.ToInt32(combi05) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha11);
                    guardaPosicoes[1] = escolha11.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi05) - 2] += 1;
                    alpinistas--;
                }

                else if ((combinacao01 == true && escolha01.Substring(0, 1) == guardaPosicoes[0]) && trilhasDominadas[Convert.ToInt32(combi01) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha01);
                    guardaPosicoes[1] = escolha01.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi01) - 2] += 2;
                }
                else if ((combinacao02 == true && escolha02.Substring(0, 1) == guardaPosicoes[0]) && trilhasDominadas[Convert.ToInt32(combi03) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha02);
                    guardaPosicoes[1] = escolha02.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi03) - 2] += 2;
                }
                else if ((combinacao03 == true && escolha03.Substring(0, 1) == guardaPosicoes[0]) && trilhasDominadas[Convert.ToInt32(combi05) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha03);
                    guardaPosicoes[1] = escolha03.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi05) - 2] += 2;
                }
                else if (combinacao01 == true && trilhasDominadas[Convert.ToInt32(combi01) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha01);
                    guardaPosicoes[1] = escolha01.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi01) - 2] += 2;
                    alpinistas--;
                }
                else if (combinacao02 == true && trilhasDominadas[Convert.ToInt32(combi03) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha02);
                    guardaPosicoes[1] = escolha02.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi03) - 2] += 2;
                    alpinistas--;
                }
                else if (combinacao03 == true && trilhasDominadas[Convert.ToInt32(combi05) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha03);
                    guardaPosicoes[1] = escolha03.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi05) - 2] += 2;
                    alpinistas--;
                }


                else if (escolha01.Substring(0, 1) == guardaPosicoes[0] && (trilhasDominadas[Convert.ToInt32(combi01) - 2] == false && trilhasDominadas[Convert.ToInt32(combi02) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha01);
                    guardaPosicoes[1] = escolha01.Substring(1, 1);
                    posicaoJogador[Convert.ToInt32(combi01) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi02) - 2] += 1;
                    alpinistas--;
                }
                else if (escolha01.Substring(1, 1) == guardaPosicoes[0] && (trilhasDominadas[Convert.ToInt32(combi01) - 2] == false && trilhasDominadas[Convert.ToInt32(combi02) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha01);
                    guardaPosicoes[1] = escolha01.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi01) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi02) - 2] += 1;
                    alpinistas--;
                }

                else if (escolha02.Substring(0, 1) == guardaPosicoes[0] && (trilhasDominadas[Convert.ToInt32(combi03) - 2] == false && trilhasDominadas[Convert.ToInt32(combi04) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha02);
                    guardaPosicoes[1] = escolha02.Substring(1, 1);
                    posicaoJogador[Convert.ToInt32(combi03) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi04) - 2] += 1;
                    alpinistas--;
                }
                else if (escolha02.Substring(1, 1) == guardaPosicoes[0] && (trilhasDominadas[Convert.ToInt32(combi03) - 2] == false && trilhasDominadas[Convert.ToInt32(combi04) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha02);
                    guardaPosicoes[1] = escolha02.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi03) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi04) - 2] += 1;
                    alpinistas--;
                }

                else if (escolha03.Substring(0, 1) == guardaPosicoes[0] && (trilhasDominadas[Convert.ToInt32(combi05) - 2] == false && trilhasDominadas[Convert.ToInt32(combi06) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha03);
                    guardaPosicoes[1] = escolha03.Substring(1, 1);
                    posicaoJogador[Convert.ToInt32(combi05) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi06) - 2] += 1;
                    alpinistas--;
                }
                else if (escolha03.Substring(1, 1) == guardaPosicoes[0] && (trilhasDominadas[Convert.ToInt32(combi05) - 2] == false && trilhasDominadas[Convert.ToInt32(combi06) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha03);
                    guardaPosicoes[1] = escolha03.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi05) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi06) - 2] += 1;
                    alpinistas--;
                }

                else
                {
                    if (trilhasDominadas[Convert.ToInt32(combi01) - 2] == false && trilhasDominadas[Convert.ToInt32(combi02) - 2] == false)
                    {
                        Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha01);
                        guardaPosicoes[1] = escolha01.Substring(0, 1);
                        guardaPosicoes[2] = escolha01.Substring(1, 1);
                        posicaoJogador[Convert.ToInt32(combi01) - 2] += 1;
                        posicaoJogador[Convert.ToInt32(combi02) - 2] += 1;
                        alpinistas = 0;
                    }
                    else if (trilhasDominadas[Convert.ToInt32(combi03) - 2] == false && trilhasDominadas[Convert.ToInt32(combi04) - 2] == false)
                    {
                        Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha02);
                        guardaPosicoes[1] = escolha02.Substring(0, 1);
                        guardaPosicoes[2] = escolha02.Substring(1, 1);
                        posicaoJogador[Convert.ToInt32(combi03) - 2] += 1;
                        posicaoJogador[Convert.ToInt32(combi04) - 2] += 1;
                        alpinistas = 0;
                    }
                    else if (trilhasDominadas[Convert.ToInt32(combi05) - 2] == false && trilhasDominadas[Convert.ToInt32(combi06) - 2] == false)
                    {
                        Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha03);
                        guardaPosicoes[1] = escolha03.Substring(0, 1);
                        guardaPosicoes[2] = escolha03.Substring(1, 1);
                        posicaoJogador[Convert.ToInt32(combi05) - 2] += 1;
                        posicaoJogador[Convert.ToInt32(combi06) - 2] += 1;
                        alpinistas = 0;
                    }
                    else
                    {
                        if (trilhasDominadas[Convert.ToInt32(combi01) - 2] == false)
                        {
                            Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha07);
                            guardaPosicoes[1] = escolha07.Substring(0, 1);
                            posicaoJogador[Convert.ToInt32(combi01) - 2] += 1;
                            alpinistas--;
                        }
                        else if (trilhasDominadas[Convert.ToInt32(combi02) - 2] == false)
                        {
                            Jogo.Mover(idPlayer, senhaPlayer, "3412", escolha08);
                            guardaPosicoes[1] = escolha08.Substring(0, 1);
                            posicaoJogador[Convert.ToInt32(combi02) - 2] += 1;
                            alpinistas--;
                        }
                        else if (trilhasDominadas[Convert.ToInt32(combi03) - 2] == false)
                        {
                            Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha09);
                            guardaPosicoes[1] = escolha09.Substring(0, 1);
                            posicaoJogador[Convert.ToInt32(combi03) - 2] += 1;
                            alpinistas--;
                        }
                        else if (trilhasDominadas[Convert.ToInt32(combi04) - 2] == false)
                        {
                            Jogo.Mover(idPlayer, senhaPlayer, "2314", escolha10);
                            guardaPosicoes[1] = escolha10.Substring(0, 1);
                            posicaoJogador[Convert.ToInt32(combi04) - 2] += 1;
                            alpinistas--;
                        }
                        else if (trilhasDominadas[Convert.ToInt32(combi05) - 2] == false)
                        {
                            Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha11);
                            guardaPosicoes[1] = escolha11.Substring(0, 1);
                            posicaoJogador[Convert.ToInt32(combi05) - 2] += 1;
                            alpinistas--;
                        }
                        else if (trilhasDominadas[Convert.ToInt32(combi06) - 2] == false)
                        {
                            Jogo.Mover(idPlayer, senhaPlayer, "2413", escolha12);
                            guardaPosicoes[1] = escolha12.Substring(0, 1);
                            posicaoJogador[Convert.ToInt32(combi06) - 2] += 1;
                            alpinistas--;
                        }
                    }
                }
            }
            else if (alpinistas == 1)
            {
                if ((combinacao01 == true && posicaoJogador[Convert.ToInt32(combi01) - 2] == penultimaPosicao[Convert.ToInt32(combi01) - 2]) && trilhasDominadas[Convert.ToInt32(combi01) - 2] == false)
                {
                    if ((escolha01.Substring(1, 0) == guardaPosicoes[0] || escolha01.Substring(1, 0) == guardaPosicoes[1]))
                    {
                        Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha07);
                        posicaoJogador[Convert.ToInt32(combi01) - 2] += 1;
                        alpinistas--;
                    }
                    else
                    {
                        Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha07);
                        guardaPosicoes[2] = escolha07.Substring(0, 1);
                        posicaoJogador[Convert.ToInt32(combi01) - 2] += 1;
                        alpinistas--;
                    }
                }
                else if ((combinacao02 == true && posicaoJogador[Convert.ToInt32(combi03) - 2] == penultimaPosicao[Convert.ToInt32(combi03) - 2]) && trilhasDominadas[Convert.ToInt32(combi03) - 2] == false)
                {
                    if ((escolha02.Substring(1, 0) == guardaPosicoes[0] || escolha02.Substring(1, 0) == guardaPosicoes[1]))
                    {
                        Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha09);
                        posicaoJogador[Convert.ToInt32(combi03) - 2] += 1;
                        alpinistas--;
                    }
                    else
                    {
                        Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha09);
                        guardaPosicoes[2] = escolha09.Substring(0, 1);
                        posicaoJogador[Convert.ToInt32(combi03) - 2] += 1;
                        alpinistas--;
                    }
                }
                else if ((combinacao03 == true && posicaoJogador[Convert.ToInt32(combi05) - 2] == penultimaPosicao[Convert.ToInt32(combi05) - 2]) && trilhasDominadas[Convert.ToInt32(combi05) - 2] == false)
                {
                    if ((escolha03.Substring(1, 0) == guardaPosicoes[0] || escolha03.Substring(1, 0) == guardaPosicoes[1]))
                    {
                        Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha11);
                        posicaoJogador[Convert.ToInt32(combi05) - 2] += 1;
                        alpinistas--;
                    }
                    else
                    {
                        Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha11);
                        guardaPosicoes[2] = escolha11.Substring(0, 1);
                        posicaoJogador[Convert.ToInt32(combi05) - 2] += 1;
                        alpinistas--;
                    }
                }

                else if ((combinacao01 == true && (escolha01.Substring(0, 1) == guardaPosicoes[0] || escolha01.Substring(0, 1) == guardaPosicoes[1])) && trilhasDominadas[Convert.ToInt32(combi01) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha01);
                    guardaPosicoes[2] = escolha01.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi01) - 2] += 2;
                }
                else if ((combinacao02 == true && (escolha02.Substring(0, 1) == guardaPosicoes[0] || escolha02.Substring(0, 1) == guardaPosicoes[1])) && trilhasDominadas[Convert.ToInt32(combi03) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha02);
                    guardaPosicoes[2] = escolha02.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi03) - 2] += 2;
                }
                else if ((combinacao03 == true && (escolha03.Substring(0, 1) == guardaPosicoes[0] || escolha03.Substring(0, 1) == guardaPosicoes[1])) && trilhasDominadas[Convert.ToInt32(combi05) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha03);
                    guardaPosicoes[2] = escolha03.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi05) - 2] += 2;
                }
                else if (combinacao01 == true && trilhasDominadas[Convert.ToInt32(combi01) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha01);
                    guardaPosicoes[2] = escolha01.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi01) - 2] += 2;
                    alpinistas--;
                }
                else if (combinacao02 == true && trilhasDominadas[Convert.ToInt32(combi03) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha02);
                    guardaPosicoes[2] = escolha02.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi03) - 2] += 2;
                    alpinistas--;
                }
                else if (combinacao03 == true && trilhasDominadas[Convert.ToInt32(combi05) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha03);
                    guardaPosicoes[2] = escolha03.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi05) - 2] += 2;
                    alpinistas--;
                }


                else if (((escolha01.Substring(0, 1) == guardaPosicoes[0] && escolha01.Substring(1, 1) == guardaPosicoes[1]) ||
                    (escolha01.Substring(0, 1) == guardaPosicoes[1] && escolha01.Substring(1, 1) == guardaPosicoes[0])) && (trilhasDominadas[Convert.ToInt32(combi01) - 2] == false && trilhasDominadas[Convert.ToInt32(combi02) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha01);
                    posicaoJogador[Convert.ToInt32(combi01) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi02) - 2] += 1;
                }
                else if (((escolha02.Substring(0, 1) == guardaPosicoes[0] && escolha02.Substring(1, 1) == guardaPosicoes[1]) ||
                    (escolha02.Substring(0, 1) == guardaPosicoes[1] && escolha02.Substring(1, 1) == guardaPosicoes[0])) && (trilhasDominadas[Convert.ToInt32(combi03) - 2] == false && trilhasDominadas[Convert.ToInt32(combi04) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha02);
                    posicaoJogador[Convert.ToInt32(combi03) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi04) - 2] += 1;
                }
                else if (((escolha03.Substring(0, 1) == guardaPosicoes[0] && escolha03.Substring(1, 1) == guardaPosicoes[1]) ||
                    (escolha03.Substring(0, 1) == guardaPosicoes[1] && escolha03.Substring(1, 1) == guardaPosicoes[0])) && (trilhasDominadas[Convert.ToInt32(combi05) - 2] == false && trilhasDominadas[Convert.ToInt32(combi06) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha03);
                    posicaoJogador[Convert.ToInt32(combi05) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi06) - 2] += 1;
                }

                else if ((escolha01.Substring(0, 1) == guardaPosicoes[0] || escolha01.Substring(0, 1) == guardaPosicoes[1]) && (trilhasDominadas[Convert.ToInt32(combi01) - 2] == false && trilhasDominadas[Convert.ToInt32(combi02) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha01);
                    guardaPosicoes[2] = escolha01.Substring(1, 1);
                    posicaoJogador[Convert.ToInt32(combi01) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi02) - 2] += 1;
                    alpinistas--;
                }
                else if ((escolha01.Substring(1, 1) == guardaPosicoes[0] || escolha01.Substring(1, 1) == guardaPosicoes[1]) && (trilhasDominadas[Convert.ToInt32(combi01) - 2] == false && trilhasDominadas[Convert.ToInt32(combi02) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha01);
                    guardaPosicoes[2] = escolha01.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi01) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi02) - 2] += 1;
                    alpinistas--;
                }

                else if ((escolha02.Substring(0, 1) == guardaPosicoes[0] || escolha02.Substring(0, 1) == guardaPosicoes[1]) && (trilhasDominadas[Convert.ToInt32(combi03) - 2] == false && trilhasDominadas[Convert.ToInt32(combi04) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha02);
                    guardaPosicoes[2] = escolha02.Substring(1, 1);
                    posicaoJogador[Convert.ToInt32(combi03) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi04) - 2] += 1;
                    alpinistas--;
                }
                else if ((escolha02.Substring(1, 1) == guardaPosicoes[0] || escolha02.Substring(1, 1) == guardaPosicoes[1]) && (trilhasDominadas[Convert.ToInt32(combi03) - 2] == false && trilhasDominadas[Convert.ToInt32(combi04) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha02);
                    guardaPosicoes[2] = escolha02.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi03) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi04) - 2] += 1;
                    alpinistas--;
                }

                else if ((escolha03.Substring(0, 1) == guardaPosicoes[0] || escolha03.Substring(0, 1) == guardaPosicoes[1]) && (trilhasDominadas[Convert.ToInt32(combi05) - 2] == false && trilhasDominadas[Convert.ToInt32(combi06) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha03);
                    guardaPosicoes[2] = escolha03.Substring(1, 1);
                    posicaoJogador[Convert.ToInt32(combi05) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi06) - 2] += 1;
                    alpinistas--;
                }
                else if ((escolha03.Substring(1, 1) == guardaPosicoes[0] || escolha03.Substring(1, 1) == guardaPosicoes[1]) && (trilhasDominadas[Convert.ToInt32(combi05) - 2] == false && trilhasDominadas[Convert.ToInt32(combi06) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha03);
                    guardaPosicoes[2] = escolha03.Substring(0, 1);
                    posicaoJogador[Convert.ToInt32(combi05) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi06) - 2] += 1;
                    alpinistas--;
                }
                else
                {
                    if (trilhasDominadas[Convert.ToInt32(combi01) - 2] == false)
                    {
                        Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha07);
                        guardaPosicoes[2] = escolha07.Substring(0, 1);
                        posicaoJogador[Convert.ToInt32(combi01) - 2] += 1;
                        alpinistas--;
                    }
                    else if (trilhasDominadas[Convert.ToInt32(combi02) - 2] == false)
                    {
                        Jogo.Mover(idPlayer, senhaPlayer, "3412", escolha08);
                        guardaPosicoes[2] = escolha08.Substring(0, 1);
                        posicaoJogador[Convert.ToInt32(combi02) - 2] += 1;
                        alpinistas--;
                    }
                    else if (trilhasDominadas[Convert.ToInt32(combi03) - 2] == false)
                    {
                        Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha09);
                        guardaPosicoes[2] = escolha09.Substring(0, 1);
                        posicaoJogador[Convert.ToInt32(combi03) - 2] += 1;
                        alpinistas--;
                    }
                    else if (trilhasDominadas[Convert.ToInt32(combi04) - 2] == false)
                    {
                        Jogo.Mover(idPlayer, senhaPlayer, "2314", escolha10);
                        guardaPosicoes[2] = escolha10.Substring(0, 1);
                        posicaoJogador[Convert.ToInt32(combi04) - 2] += 1;
                        alpinistas--;
                    }
                    else if (trilhasDominadas[Convert.ToInt32(combi05) - 2] == false)
                    {
                        Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha11);
                        guardaPosicoes[2] = escolha11.Substring(0, 1);
                        posicaoJogador[Convert.ToInt32(combi05) - 2] += 1;
                        alpinistas--;
                    }
                    else if (trilhasDominadas[Convert.ToInt32(combi06) - 2] == false)
                    {
                        Jogo.Mover(idPlayer, senhaPlayer, "2413", escolha12);
                        guardaPosicoes[2] = escolha12.Substring(0, 1);
                        posicaoJogador[Convert.ToInt32(combi06) - 2] += 1;
                        alpinistas--;
                    }
                }
            }
            else
            {
                string posicao01 = guardaPosicoes[0] + guardaPosicoes[1];
                string posicao02 = guardaPosicoes[0] + guardaPosicoes[2];
                string posicao03 = guardaPosicoes[1] + guardaPosicoes[2];

                string posicao04 = guardaPosicoes[0] + "0";
                string posicao05 = guardaPosicoes[1] + "0";
                string posicao06 = guardaPosicoes[2] + "0";

                if ((combinacao01 == true && posicaoJogador[Convert.ToInt32(combi01) - 2] == penultimaPosicao[Convert.ToInt32(combi01) - 2]) && trilhasDominadas[Convert.ToInt32(combi01) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha07);
                    posicaoJogador[Convert.ToInt32(combi01) - 2] += 1;
                    alpinistas--;
                }
                else if ((combinacao02 == true && posicaoJogador[Convert.ToInt32(combi03) - 2] == penultimaPosicao[Convert.ToInt32(combi03) - 2]) && trilhasDominadas[Convert.ToInt32(combi03) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha09);
                    posicaoJogador[Convert.ToInt32(combi03) - 2] += 1;
                    alpinistas--;
                }
                else if ((combinacao03 == true && posicaoJogador[Convert.ToInt32(combi05) - 2] == penultimaPosicao[Convert.ToInt32(combi05) - 2]) && trilhasDominadas[Convert.ToInt32(combi05) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha11);
                    posicaoJogador[Convert.ToInt32(combi05) - 2] += 1;
                    alpinistas--;
                }


                else if ((combinacao01 == true && (escolha01.Substring(0, 1) == guardaPosicoes[0] || escolha01.Substring(0, 1) == guardaPosicoes[1] || escolha01.Substring(0, 1) == guardaPosicoes[2])) && trilhasDominadas[Convert.ToInt32(combi01) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha01);
                    posicaoJogador[Convert.ToInt32(combi01) - 2] += 2;
                }
                else if ((combinacao02 == true && (escolha02.Substring(0, 1) == guardaPosicoes[0] || escolha02.Substring(0, 1) == guardaPosicoes[1] || escolha02.Substring(0, 1) == guardaPosicoes[2])) && trilhasDominadas[Convert.ToInt32(combi03) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha02);
                    posicaoJogador[Convert.ToInt32(combi03) - 2] += 2;
                }
                else if ((combinacao03 == true && (escolha03.Substring(0, 1) == guardaPosicoes[0] || escolha03.Substring(0, 1) == guardaPosicoes[1] || escolha03.Substring(0, 1) == guardaPosicoes[2])) && trilhasDominadas[Convert.ToInt32(combi05) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha03);
                    posicaoJogador[Convert.ToInt32(combi05) - 2] += 2;
                }


                else if ((posicao01 == escolha01.ToString() || posicao02 == escolha01.ToString() || posicao03 == escolha01.ToString()) && (trilhasDominadas[Convert.ToInt32(combi01) - 2] == false && trilhasDominadas[Convert.ToInt32(combi02) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha01);
                    posicaoJogador[Convert.ToInt32(combi01) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi02) - 2] += 1;
                }
                else if ((posicao01 == escolha02.ToString() || posicao02 == escolha02.ToString() || posicao03 == escolha02.ToString()) && (trilhasDominadas[Convert.ToInt32(combi03) - 2] == false && trilhasDominadas[Convert.ToInt32(combi04) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha02);
                    posicaoJogador[Convert.ToInt32(combi03) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi04) - 2] += 1;
                }
                else if ((posicao01 == escolha03.ToString() || posicao02 == escolha03.ToString() || posicao03 == escolha03.ToString()) && (trilhasDominadas[Convert.ToInt32(combi05) - 2] == false && trilhasDominadas[Convert.ToInt32(combi06) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha03);
                    posicaoJogador[Convert.ToInt32(combi05) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi06) - 2] += 1;
                }
                else if ((posicao01 == escolha04.ToString() || posicao02 == escolha04.ToString() || posicao03 == escolha04.ToString()) && (trilhasDominadas[Convert.ToInt32(combi01) - 2] == false && trilhasDominadas[Convert.ToInt32(combi02) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "3412", escolha04);
                    posicaoJogador[Convert.ToInt32(combi01) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi02) - 2] += 1;
                }
                else if ((posicao01 == escolha05.ToString() || posicao02 == escolha05.ToString() || posicao03 == escolha05.ToString()) && (trilhasDominadas[Convert.ToInt32(combi03) - 2] == false && trilhasDominadas[Convert.ToInt32(combi04) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "2314", escolha05);
                    posicaoJogador[Convert.ToInt32(combi03) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi04) - 2] += 1;
                }
                else if ((posicao01 == escolha06.ToString() || posicao02 == escolha06.ToString() || posicao03 == escolha06.ToString()) && (trilhasDominadas[Convert.ToInt32(combi05) - 2] == false && trilhasDominadas[Convert.ToInt32(combi06) - 2] == false))
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "2413", escolha06);
                    posicaoJogador[Convert.ToInt32(combi05) - 2] += 1;
                    posicaoJogador[Convert.ToInt32(combi06) - 2] += 1;
                }

                //else if (trilhasDominadas[Convert.ToInt32(combi01) - 2] == false && (escolha07.ToString() == posicao04 || escolha07.ToString() == posicao05 || escolha07.ToString() == posicao06))
                //{
                //    Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha07);
                //    posicaoJogador[Convert.ToInt32(combi01) - 2] += 1;
                //}
                //else if (trilhasDominadas[Convert.ToInt32(combi02) - 2] == false && (escolha08.ToString() == posicao04 || escolha08.ToString() == posicao05 || escolha08.ToString() == posicao06))
                //{
                //    Jogo.Mover(idPlayer, senhaPlayer, "3412", escolha08);
                //    posicaoJogador[Convert.ToInt32(combi02) - 2] += 1;
                //}
                //else if (trilhasDominadas[Convert.ToInt32(combi03) - 2] == false && (escolha09.ToString() == posicao04 || escolha09.ToString() == posicao05 || escolha09.ToString() == posicao06))
                //{
                //    Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha09);
                //    posicaoJogador[Convert.ToInt32(combi03) - 2] += 1;
                //}
                //else if (trilhasDominadas[Convert.ToInt32(combi04) - 2] == false && (escolha10.ToString() == posicao04 || escolha10.ToString() == posicao05 || escolha10.ToString() == posicao06))
                //{
                //    Jogo.Mover(idPlayer, senhaPlayer, "2314", escolha10);
                //    posicaoJogador[Convert.ToInt32(combi04) - 2] += 1;
                //}
                //else if (trilhasDominadas[Convert.ToInt32(combi05) - 2] == false && (escolha11.ToString() == posicao04 || escolha11.ToString() == posicao05 || escolha11.ToString() == posicao06))
                //{
                //    Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha11);
                //    posicaoJogador[Convert.ToInt32(combi05) - 2] += 1;
                //}
                //else if (trilhasDominadas[Convert.ToInt32(combi06) - 2] == false && (escolha12.ToString() == posicao04 || escolha12.ToString() == posicao05 || escolha12.ToString() == posicao06))
                //{
                //    Jogo.Mover(idPlayer, senhaPlayer, "2413", escolha12);
                //    posicaoJogador[Convert.ToInt32(combi06) - 2] += 1;
                //}

                else if (((escolha07.ToString() == posicao04 || escolha07.ToString() == posicao05) || escolha07.ToString() == posicao06) && trilhasDominadas[Convert.ToInt32(combi01) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1234", escolha07);
                    posicaoJogador[Convert.ToInt32(combi01) - 2] += 1;
                }
                else if (((escolha08.ToString() == posicao04 || escolha08.ToString() == posicao05) || escolha08.ToString() == posicao06) && trilhasDominadas[Convert.ToInt32(combi02) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "3412", escolha08);
                    posicaoJogador[Convert.ToInt32(combi02) - 2] += 1;
                }
                else if (((escolha09.ToString() == posicao04 || escolha09.ToString() == posicao05) || escolha09.ToString() == posicao06) && trilhasDominadas[Convert.ToInt32(combi03) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1423", escolha09);
                    posicaoJogador[Convert.ToInt32(combi03) - 2] += 1;
                }
                else if (((escolha10.ToString() == posicao04 || escolha10.ToString() == posicao05) || escolha10.ToString() == posicao06) && trilhasDominadas[Convert.ToInt32(combi04) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "2314", escolha10);
                    posicaoJogador[Convert.ToInt32(combi04) - 2] += 1;
                }
                else if (((escolha11.ToString() == posicao04 || escolha11.ToString() == posicao05) || escolha11.ToString() == posicao06) && trilhasDominadas[Convert.ToInt32(combi05) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "1324", escolha11);
                    posicaoJogador[Convert.ToInt32(combi05) - 2] += 1;
                }
                else if (((escolha12.ToString() == posicao04 || escolha12.ToString() == posicao05 || escolha12.ToString() == posicao06)) && trilhasDominadas[Convert.ToInt32(combi06) - 2] == false)
                {
                    Jogo.Mover(idPlayer, senhaPlayer, "2413", escolha12);
                    posicaoJogador[Convert.ToInt32(combi06) - 2] += 1;
                }
            }

            qtdJogadas++;

            combinacao01 = false;
            combinacao02 = false;
            combinacao03 = false;
        }

        public void Parar()
        {
            lblErro.Text = Jogo.Parar(idPlayer, senhaPlayer);
            //lblCombinacoes.Text = "";
            qtdJogadas = 0;
            alpinistas = 3;

            guardaPosicoes[0] = null;
            guardaPosicoes[1] = null;
            guardaPosicoes[2] = null;

            lblCombinacoes.Text = "";

            picDado1.Image = null;
            picDado2.Image = null;
            picDado3.Image = null;
            picDado4.Image = null;

            for (int i = 0; i < 11; i++)
            {
                posicaoJogadorBackup[i] = posicaoJogador[i];
            }

        }

        private void Tabuleiro_Load(object sender, EventArgs e)
        {
            lblErro.Text = "";
            lblHistorico.Text = "";
            lblCombinacoes.Text = "";

            tmrAtualizaTabuleiro.Enabled = true;
            tmrAtualizaTabuleiro.Start();
            tmrAtualizaTabuleiro.Interval = 2500;
            tmrAtualizaTabuleiro.Tick += new EventHandler(tmrAtualizaTabuleiro_Tick);

            tmrAtualizacao.Enabled = true;
            tmrAtualizacao.Start();
            tmrAtualizacao.Interval = 4000;
            tmrAtualizacao.Tick += new EventHandler(tmrAtualizacao_Tick);
        }

        int erro = 0;

        public bool verificaMovimento(string ordem, string trilha)
        {
            string retorno = Jogo.Mover(idPlayer, senhaPlayer, ordem, trilha);

            if (retorno == "" || retorno.Substring(0, 4) != "ERRO")
            {
                return true;
            }
            else
            {
                erro++;
                lblErro.Text = retorno + " - ERRO: " + erro;
            }

            return false;
        }

        private void Verifica()
        {
            if (escolha01.Substring(0, 1) == "A")
            {
                teste01 = "10";
            }
            else if (escolha01.Substring(0, 1) == "B")
            {
                teste01 = "11";
            }
            else if (escolha01.Substring(0, 1) == "C")
            {
                teste01 = "12";
            }

            if (escolha01.Substring(1, 1) == "A")
            {
                teste02 = "10";
            }
            else if (escolha01.Substring(1, 1) == "B")
            {
                teste02 = "11";
            }
            else if (escolha01.Substring(1, 1) == "C")
            {
                teste02 = "12";
            }

            if (escolha02.Substring(0, 1) == "A")
            {
                teste03 = "10";
            }
            else if (escolha02.Substring(0, 1) == "B")
            {
                teste03 = "11";
            }
            else if (escolha02.Substring(0, 1) == "C")
            {
                teste03 = "12";
            }

            if (escolha02.Substring(1, 1) == "A")
            {
                teste04 = "10";
            }
            else if (escolha02.Substring(1, 1) == "B")
            {
                teste04 = "11";
            }
            else if (escolha02.Substring(1, 1) == "C")
            {
                teste04 = "12";
            }

            if (escolha03.Substring(0, 1) == "A")
            {
                teste05 = "10";
            }
            else if (escolha03.Substring(0, 1) == "B")
            {
                teste05 = "11";
            }
            else if (escolha03.Substring(0, 1) == "C")
            {
                teste05 = "12";
            }

            if (escolha03.Substring(1, 1) == "A")
            {
                teste06 = "10";
            }
            else if (escolha03.Substring(1, 1) == "B")
            {
                teste06 = "11";
            }
            else if (escolha03.Substring(1, 1) == "C")
            {
                teste06 = "12";
            }

            if (posicaoJogador[Convert.ToInt32(teste01) - 2] == ultimaPosicao[Convert.ToInt32(teste01) - 2])
            {
                Parar();
            }
            else if (posicaoJogador[Convert.ToInt32(teste02) - 2] == ultimaPosicao[Convert.ToInt32(teste02) - 2])
            {
                Parar();
            }
            else if (posicaoJogador[Convert.ToInt32(teste03) - 2] == ultimaPosicao[Convert.ToInt32(teste03) - 2])
            {
                Parar();
            }
            else if (posicaoJogador[Convert.ToInt32(teste04) - 2] == ultimaPosicao[Convert.ToInt32(teste04) - 2])
            {
                Parar();
            }
            else if (posicaoJogador[Convert.ToInt32(teste05) - 2] == ultimaPosicao[Convert.ToInt32(teste05) - 2])
            {
                Parar();
            }
            else if (posicaoJogador[Convert.ToInt32(teste06) - 2] == ultimaPosicao[Convert.ToInt32(teste06) - 2])
            {
                Parar();
            }
        }
        private void tmrAtualizacao_Tick(object sender, EventArgs e)
        {
            VerificarVez();

            if (vezJogador == false)
            {
                qtdJogadas = 0;
                alpinistas = 3;

                for (int i = 0; i < 11; i++)
                {
                    posicaoJogador[i] = posicaoJogadorBackup[i];
                }

                lblCombinacoes.Text = "";
                picDado1.Image = null;
                picDado2.Image = null;
                picDado3.Image = null;
                picDado4.Image = null;


                guardaPosicoes[0] = null;
                guardaPosicoes[1] = null;
                guardaPosicoes[2] = null;
            }


            if (qntRodadas < 10)
            {
                if (qtdJogadas < 4 && vezJogador == true)
                {
                    RolarDados();
                    MoverSecundario();

                    if (qtdJogadas >= 1)
                    {
                        Verifica();
                    }
                }
                else if (qtdJogadas == 4)
                {
                    Parar();
                    qntRodadas++;
                }
            }
            //else if (qntRodadas < 12)
            //{
            //    if (qtdJogadas < 3 && vezJogador == true)
            //    {
            //        RolarDados();
            //        //Mover();
            //        //MoverOficial();
            //        MoverSecundario();
            //    }
            //    else if (qtdJogadas == 3)
            //    {
            //        Parar();
            //        qntRodadas++;
            //    }
            //}
            else
            {
                if (qtdJogadas < 2 && vezJogador == true)
                {
                    RolarDados();
                    //Mover();
                    //MoverOficial();
                    MoverSecundario();
                }
                else if (qtdJogadas == 2)
                {
                    Parar();
                    qntRodadas++;
                }
            }

            //DadosOutroJogador();
        }

        private void tmrAtualizaTabuleiro_Tick(object sender, EventArgs e)
        {
            ExibirTabuleiro();
            ExibirHistorico();
            
            if(lblErro.Text != "")
            {
                lblErro.Text = "";
            }
            //lblVetor.Text = guardaPosicoes[0] + " | " + guardaPosicoes[1] + " | " + guardaPosicoes[2];

            //lblVetorPosicao.Text = posicaoJogador[0] + " | " + posicaoJogador[1] + " | " +
            //    posicaoJogador[2] + " | " + posicaoJogador[3] + " | " + posicaoJogador[4] + " | " +
            //    posicaoJogador[5] + " | " + posicaoJogador[6] + " | " + posicaoJogador[7] + " | " +
            //    posicaoJogador[8] + " | " + posicaoJogador[9] + " | " + posicaoJogador[10];

            //lblBackup.Text = posicaoJogadorBackup[0] + " | " + posicaoJogadorBackup[1] + " | " +
            //    posicaoJogadorBackup[2] + " | " + posicaoJogadorBackup[3] + " | " + posicaoJogadorBackup[4] + " | " +
            //    posicaoJogadorBackup[5] + " | " + posicaoJogadorBackup[6] + " | " + posicaoJogadorBackup[7] + " | " +
            //    posicaoJogadorBackup[8] + " | " + posicaoJogadorBackup[9] + " | " + posicaoJogadorBackup[10];
        }

        public void VotarLobby()
        {
            frmLobby form = new frmLobby();
            this.Close();
            form.Show();
        }
    }
}