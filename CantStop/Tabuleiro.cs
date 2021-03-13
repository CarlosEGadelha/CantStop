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
        public Tabuleiro()
        {
            //Chama o Lobby
            Lobby lobby = new Lobby();
            lobby.ShowDialog();

            InitializeComponent();

            //Exibe os jogadores da partida que foi selecionada lá no lobby
            //textBox1.Text = Jogo.ListarJogadores(lobby.idPartida);
        }
    }
}
