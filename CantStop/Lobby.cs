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
    public partial class Lobby : Form
    {
        public int idPartida { get; set; }
        public int idJogador { get; set; }
        public string senhaJogador { get; set; }
        //public int idJogador { get; set; }

        public Lobby()
        {
            InitializeComponent();
            lblVersao.Text = "Versão " + Jogo.Versao;
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            Partida partida = (Partida)dgvPartidas.SelectedRows[0].DataBoundItem;
            this.idPartida = partida.idPartida;
            txtListaJogadores.Text = Jogo.ListarJogadores(idPartida);

            //string retorno = Jogo.ListarJogadores(idPartida);
            //retorno = retorno.Replace("\r", "");
            //string[] linha = retorno.Split('\n');
            //List<Jogador> jogadores = new List<Jogador>();

            //for (int i = 0; i < linha.Length - 1; i++)
            //{
            //    Jogador p = new Jogador();
            //    string[] items = linha[i].Split(',');
            //    p.id = Convert.ToInt32(items[0]);
            //    p.nome = items[1];
            //    p.cor = items[2];
            //    //p.senha = items[3];
            //    jogadores.Add(p);
            //}

            //dgvJogadores.DataSource = jogadores;
        }

        private void btnExibirPartidas_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");

            retorno = retorno.Replace("\r", "");
            string[] linha = retorno.Split('\n');
            List<Partida> partidas = new List<Partida>();

            for (int i = 0; i < linha.Length - 1; i++)
            {
                Partida p = new Partida();
                string[] items = linha[i].Split(',');
                p.idPartida = Convert.ToInt32(items[0]);
                p.nome = items[1];
                p.data = items[2];
                p.status = items[3];
                partidas.Add(p);
            }

            dgvPartidas.DataSource = partidas;
            dgvPartidas.Columns[4].Visible = false;
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            Partida partida = new Partida();
            string nome = txtNomePartida.Text;
            string senha = txtSenha.Text;
            partida.idPartida = Convert.ToInt32(Jogo.CriarPartida(nome, senha));
            txtNomePartida.Text = "";
            txtSenha.Text = "";
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            Partida partida = (Partida)dgvPartidas.SelectedRows[0].DataBoundItem;
            this.idPartida = partida.idPartida;
            string nome = txtNomeJogador.Text;
            string senha = txtSenha.Text;
            string jogador = Jogo.EntrarPartida(idPartida, nome, senha);

            txtNomeJogador.Text = "";
            txtSenha.Text = "";

            if (jogador.Substring(0, 4) != "ERRO")
            {
                string[] x = jogador.Split(',');

                lblInfoJogador.Text = x[0] + ". " + x[1] + ". " + x[2];
                txtIdJogador.Text = x[0];
                txtSenhaJogador.Text = x[1];
                txtCorJogador.Text = x[2];
            }
            else
            {
                lblInfoJogador.Text = jogador.Substring(5);
            }            
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            Partida partida = (Partida)dgvPartidas.SelectedRows[0].DataBoundItem;
            this.idPartida = partida.idPartida;
            this.idJogador = Convert.ToInt32(txtIdJogador.Text);
            this.senhaJogador = txtSenhaJogador.Text;
            txtConsole.Text = Jogo.IniciarPartida(idJogador, senhaJogador);
            //txtConsole.Text = retorno.Substring(5);
            //Tabuleiro tabuleiro = new Tabuleiro(idJogador, senhaJogador);
            //tabuleiro.Show();
            //this.Close();

            //txtConsole.Text = Jogo.IniciarPartida(idJogador, senhaJogador);
        }

        private void btnRolarDados_Click(object sender, EventArgs e)
        {
            Lobby lobby = new Lobby();

            string retorno = Jogo.RolarDados(idJogador, senhaJogador);

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

        private void btnMover_Click(object sender, EventArgs e)
        {
            int idJogador = Convert.ToInt32(txtIdJogador.Text);
            string senha = txtSenhaJogador.Text;
            string ordem = txtOrdem.Text;
            string trilha = txtTrilha.Text;
            txtConsole.Text = Jogo.Mover(idJogador, senha, ordem, trilha);
        }

        private void btnParar_Click(object sender, EventArgs e)
        {

        }

        private void btnExibirTabuleiro_Click(object sender, EventArgs e)
        {
            Partida partida = (Partida)dgvPartidas.SelectedRows[0].DataBoundItem;
            this.idPartida = partida.idPartida;
            txtTabuleiro.Text = Jogo.ExibirTabuleiro(idPartida); 
        }

        //private void btnInfoJogador_Click(object sender, EventArgs e)
        //{
        //    Jogador jogador = (Jogador)dgvJogadores.SelectedRows[0].DataBoundItem;
        //    this.idJogador = jogador.id;
        //    txtId.Text = jogador.id.ToString();
        //    txtNomeJogador.Text = jogador.nome;
        //    txtCorJogador.Text = jogador.cor;
        //}
    }
}
