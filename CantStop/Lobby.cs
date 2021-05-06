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
    public partial class frmLobby : Form
    {
        public int idPartida { get; set; }
        public int idJogador { get; set; }
        public string senhaJogador { get; set; }
        public string corJogador { get; set; }

        public frmLobby()
        {
            InitializeComponent();
            lblVersao.Text = "Versão " + Jogo.Versao;
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            Partida partida = (Partida)dgvPartidas.SelectedRows[0].DataBoundItem;
            this.idPartida = partida.idPartida;
            txtListaJogadores.Text = Jogo.ListarJogadores(idPartida);
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
            string retorno = Jogo.CriarPartida(nome, senha);
            if (retorno.Substring(0, 1) != "E")
            {
                partida.idPartida = Convert.ToInt32(retorno);
                txtNomePartida.Text = "";
                txtSenha.Text = "";
            }
            else
            {
                lblInfoJogador.Text = retorno.Substring(5);
            }
            
        }
        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            Partida partida = (Partida)dgvPartidas.SelectedRows[0].DataBoundItem;
            this.idPartida = partida.idPartida;
            string nome = txtNomeJogador.Text;
            string senha = txtSenha.Text;
            string retorno = Jogo.EntrarPartida(idPartida, nome, senha);

            txtNomeJogador.Text = "";
            txtSenha.Text = "";

            retorno = retorno.Replace("\r", "");
            string[] linha = retorno.Split('\n');

            if (retorno.Substring(0, 4) != "ERRO")
            {
                string[] x = retorno.Split(',');

                lblInfoJogador.Text = x[0] + ". " + x[1] + ". " + x[2];
                txtIdJogador.Text = x[0];
                txtSenhaJogador.Text = x[1];
                txtCorJogador.Text = x[2];
            }
            else
            {
                lblInfoJogador.Text = retorno.Substring(5);
            }            
        }
        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            Partida partida = (Partida)dgvPartidas.SelectedRows[0].DataBoundItem;
            this.idPartida = partida.idPartida;
            this.idJogador = Convert.ToInt32(txtIdJogador.Text);
            this.senhaJogador = txtSenhaJogador.Text;
            this.corJogador = txtCorJogador.Text;

            frmTabuleiro tabuleiro = new frmTabuleiro(idJogador, senhaJogador, idPartida, corJogador);
            this.Hide();
            tabuleiro.Show();
        }
    }
}
