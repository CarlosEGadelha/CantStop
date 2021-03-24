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
        public int idJogador { get; set; }
        public string senhaJogador { get; set; }

        public Tabuleiro()
        {
            //Chama o Lobby
            Lobby lobby = new Lobby();
            lobby.ShowDialog();

            InitializeComponent();

            //string retorno = Jogo.IniciarPartida(idJogador, senhaJogador);
            //txtConsole.Text = retorno.Substring(5);

            //Exibe os jogadores da partida que foi selecionada lá no lobby
            //textBox1.Text = Jogo.ListarJogadores(lobby.idPartida);
        }

        private void btnRolarDados_Click(object sender, EventArgs e)
        {
            //Lobby lobby = new Lobby();

            //string retorno = Jogo.RolarDados(idJogador, senhaJogador);

            //if (retorno.Substring(0, 4) != "ERRO")
            //{
            //    txtConsole.Text = retorno;
            //}
            //else
            //{
            //    txtConsole.Text = retorno.Substring(5);
            //}
        }
    }
}
