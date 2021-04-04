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
    public partial class Tabuleiro : Form
    {
        public static int idPlayer { get; set; }
        public static int idPartidaAtt { get; set; }
        public static string senhaPlayer { get; set; }

        public Tabuleiro(int idJogador, string senhaJogador, int idPartida)
        {
            //Chama o Lobby
            //Lobby lobby = new Lobby();
            //lobby.ShowDialog();

            InitializeComponent();

            idPlayer = idJogador;
            senhaPlayer = senhaJogador;
            idPartidaAtt = idPartida;
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
            txtTabuleiro.Text = Jogo.ExibirTabuleiro(idPartidaAtt);
        }

        private void btnParar_Click(object sender, EventArgs e)
        {

        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            string ordem = txtOrdem.Text;
            string trilha = txtTrilha.Text;
            txtConsole.Text = Jogo.Mover(idPlayer, senhaPlayer, ordem, trilha);
        }
    }
}
