using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CantStopServer;

namespace CantStop
{
    public partial class frmLobby : Form
    {
        public static int idPartida { get; set; }
        public static int idJogador { get; set; }
        public static string senhaJogador { get; set; }
        public static string corJogador { get; set; }

        public frmLobby()
        {
            InitializeComponent();
            lblVersao.Text = "Versão " + Jogo.Versao;
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            Partida partida = (Partida)dgvPartidas.SelectedRows[0].DataBoundItem;
            idPartida = partida.idPartida;
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
                txtNomePartida.Clear();
                txtSenha.Clear();
            }
            else
            {
                lblInfoJogador.Text = retorno.Substring(5);
            }
        }
        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            Partida partida = (Partida)dgvPartidas.SelectedRows[0].DataBoundItem;
            idPartida = partida.idPartida;
            string nome = txtNomeJogador.Text;
            string senha = txtSenha.Text;
            string retorno = Jogo.EntrarPartida(idPartida, nome, senha);

            txtNomeJogador.Text = "";
            txtSenha.Text = "";

            retorno = retorno.Replace("\r", "");
            string[] linha = retorno.Split('\n');

            if (retorno.Substring(0, 4) != "ERRO")
            {
                using (StreamWriter usuario = new StreamWriter("backupUser.txt"))
                {
                    usuario.WriteLine(linha[0]);
                }

                if (File.Exists("backupUser.txt"))
                {
                    using (StreamReader SR = new StreamReader("backupUser.txt"))
                    {
                        string retornoUser = SR.ReadLine();

                        if (retornoUser != null)
                        {
                            lblInfoJogador.Text = retornoUser;

                            retornoUser = retornoUser.Replace("\r", "");

                            string[] x = retornoUser.Split(',');
                            txtIdJogador.Text = x[0];
                            txtSenhaJogador.Text = x[1];
                            txtCorJogador.Text = x[2];
                        }
                        else
                        {
                            lblInfoJogador.Text = "";
                        }
                    }
                }
            }
            else
            {
                lblInfoJogador.Text = retorno.Substring(5);
            }
        }
        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            Partida partida = (Partida)dgvPartidas.SelectedRows[0].DataBoundItem;
            idPartida = partida.idPartida;
            idJogador = Convert.ToInt32(txtIdJogador.Text);
            senhaJogador = txtSenhaJogador.Text;
            corJogador = txtCorJogador.Text;

            frmTabuleiro tabuleiro = new frmTabuleiro(idJogador, senhaJogador, idPartida, corJogador);
            this.Hide();
            tabuleiro.ShowDialog();
            this.Show();
        }

        private void frmLobby_Load(object sender, EventArgs e)
        {
            if (File.Exists("backupUser.txt"))
            {
                using (StreamReader SR = new StreamReader("backupUser.txt"))
                {
                    string retorno = SR.ReadLine();

                    if (retorno != null)
                    {
                        lblInfoJogador.Text = retorno;

                        retorno = retorno.Replace("\r", "");

                        string[] x = retorno.Split(',');
                        txtIdJogador.Text = x[0];
                        txtSenhaJogador.Text = x[1];
                        txtCorJogador.Text = x[2];
                    }
                    else
                    {
                        lblInfoJogador.Text = "";
                    }
                }
            }
        }
    }
}
