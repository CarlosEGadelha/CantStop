
namespace CantStop
{
    partial class frmTabuleiro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picDado4 = new System.Windows.Forms.PictureBox();
            this.picDado3 = new System.Windows.Forms.PictureBox();
            this.picDado2 = new System.Windows.Forms.PictureBox();
            this.picDado1 = new System.Windows.Forms.PictureBox();
            this.picTabuleiro = new System.Windows.Forms.PictureBox();
            this.lblInfoJogador = new System.Windows.Forms.Label();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.lblHistórico = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblCombinacoes = new System.Windows.Forms.Label();
            this.tmrAtualizacao = new System.Windows.Forms.Timer(this.components);
            this.tmrAtualizaTabuleiro = new System.Windows.Forms.Timer(this.components);
            this.lblSorteioDados = new System.Windows.Forms.Label();
            this.picSuaCor = new System.Windows.Forms.PictureBox();
            this.picJogadorVez = new System.Windows.Forms.PictureBox();
            this.lblSuaCor = new System.Windows.Forms.Label();
            this.lblJogadorVez = new System.Windows.Forms.Label();
            this.picDadoPlayer4 = new System.Windows.Forms.PictureBox();
            this.picDadoPlayer3 = new System.Windows.Forms.PictureBox();
            this.picDadoPlayer2 = new System.Windows.Forms.PictureBox();
            this.picDadoPlayer1 = new System.Windows.Forms.PictureBox();
            this.lblDadosPartida = new System.Windows.Forms.Label();
            this.lblVetor = new System.Windows.Forms.Label();
            this.lblAlpinistas = new System.Windows.Forms.Label();
            this.lblPosicao01 = new System.Windows.Forms.Label();
            this.lblPosicao02 = new System.Windows.Forms.Label();
            this.lblPosicao03 = new System.Windows.Forms.Label();
            this.lblVetorPosicao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBackup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDado4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTabuleiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSuaCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJogadorVez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDadoPlayer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDadoPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDadoPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDadoPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(14, 42);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(138, 134);
            this.txtConsole.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Console da Partida";
            // 
            // picDado4
            // 
            this.picDado4.Location = new System.Drawing.Point(78, 269);
            this.picDado4.Name = "picDado4";
            this.picDado4.Size = new System.Drawing.Size(50, 50);
            this.picDado4.TabIndex = 69;
            this.picDado4.TabStop = false;
            // 
            // picDado3
            // 
            this.picDado3.Location = new System.Drawing.Point(22, 269);
            this.picDado3.Name = "picDado3";
            this.picDado3.Size = new System.Drawing.Size(50, 50);
            this.picDado3.TabIndex = 68;
            this.picDado3.TabStop = false;
            // 
            // picDado2
            // 
            this.picDado2.Location = new System.Drawing.Point(78, 213);
            this.picDado2.Name = "picDado2";
            this.picDado2.Size = new System.Drawing.Size(50, 50);
            this.picDado2.TabIndex = 67;
            this.picDado2.TabStop = false;
            // 
            // picDado1
            // 
            this.picDado1.Location = new System.Drawing.Point(22, 213);
            this.picDado1.Name = "picDado1";
            this.picDado1.Size = new System.Drawing.Size(50, 50);
            this.picDado1.TabIndex = 66;
            this.picDado1.TabStop = false;
            // 
            // picTabuleiro
            // 
            this.picTabuleiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picTabuleiro.Enabled = false;
            this.picTabuleiro.Image = global::CantStop.Properties.Resources.tabuleiroOficial;
            this.picTabuleiro.Location = new System.Drawing.Point(345, 21);
            this.picTabuleiro.Name = "picTabuleiro";
            this.picTabuleiro.Size = new System.Drawing.Size(454, 471);
            this.picTabuleiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTabuleiro.TabIndex = 65;
            this.picTabuleiro.TabStop = false;
            // 
            // lblInfoJogador
            // 
            this.lblInfoJogador.AutoSize = true;
            this.lblInfoJogador.Location = new System.Drawing.Point(9, 542);
            this.lblInfoJogador.Name = "lblInfoJogador";
            this.lblInfoJogador.Size = new System.Drawing.Size(45, 13);
            this.lblInfoJogador.TabIndex = 70;
            this.lblInfoJogador.Text = "Jogador";
            // 
            // txtHistorico
            // 
            this.txtHistorico.Location = new System.Drawing.Point(160, 42);
            this.txtHistorico.Multiline = true;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.ReadOnly = true;
            this.txtHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistorico.Size = new System.Drawing.Size(171, 134);
            this.txtHistorico.TabIndex = 72;
            // 
            // lblHistórico
            // 
            this.lblHistórico.AutoSize = true;
            this.lblHistórico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistórico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblHistórico.Location = new System.Drawing.Point(191, 21);
            this.lblHistórico.Name = "lblHistórico";
            this.lblHistórico.Size = new System.Drawing.Size(113, 16);
            this.lblHistórico.TabIndex = 71;
            this.lblHistórico.Text = "Exibir Histórico";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(740, 542);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(40, 13);
            this.lblVersao.TabIndex = 74;
            this.lblVersao.Text = "Versão";
            // 
            // lblCombinacoes
            // 
            this.lblCombinacoes.AutoSize = true;
            this.lblCombinacoes.Location = new System.Drawing.Point(22, 341);
            this.lblCombinacoes.Name = "lblCombinacoes";
            this.lblCombinacoes.Size = new System.Drawing.Size(71, 13);
            this.lblCombinacoes.TabIndex = 75;
            this.lblCombinacoes.Text = "Combinações";
            // 
            // tmrAtualizacao
            // 
            this.tmrAtualizacao.Interval = 3000;
            // 
            // tmrAtualizaTabuleiro
            // 
            this.tmrAtualizaTabuleiro.Interval = 3000;
            this.tmrAtualizaTabuleiro.Tick += new System.EventHandler(this.tmrAtualizaTabuleiro_Tick);
            // 
            // lblSorteioDados
            // 
            this.lblSorteioDados.AutoSize = true;
            this.lblSorteioDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSorteioDados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSorteioDados.Location = new System.Drawing.Point(12, 194);
            this.lblSorteioDados.Name = "lblSorteioDados";
            this.lblSorteioDados.Size = new System.Drawing.Size(130, 16);
            this.lblSorteioDados.TabIndex = 78;
            this.lblSorteioDados.Text = "Dados Sorteados";
            // 
            // picSuaCor
            // 
            this.picSuaCor.Location = new System.Drawing.Point(98, 462);
            this.picSuaCor.Name = "picSuaCor";
            this.picSuaCor.Size = new System.Drawing.Size(30, 30);
            this.picSuaCor.TabIndex = 80;
            this.picSuaCor.TabStop = false;
            // 
            // picJogadorVez
            // 
            this.picJogadorVez.Location = new System.Drawing.Point(248, 462);
            this.picJogadorVez.Name = "picJogadorVez";
            this.picJogadorVez.Size = new System.Drawing.Size(30, 30);
            this.picJogadorVez.TabIndex = 81;
            this.picJogadorVez.TabStop = false;
            // 
            // lblSuaCor
            // 
            this.lblSuaCor.AutoSize = true;
            this.lblSuaCor.Location = new System.Drawing.Point(48, 470);
            this.lblSuaCor.Name = "lblSuaCor";
            this.lblSuaCor.Size = new System.Drawing.Size(44, 13);
            this.lblSuaCor.TabIndex = 82;
            this.lblSuaCor.Text = "Sua cor";
            // 
            // lblJogadorVez
            // 
            this.lblJogadorVez.AutoSize = true;
            this.lblJogadorVez.Location = new System.Drawing.Point(165, 470);
            this.lblJogadorVez.Name = "lblJogadorVez";
            this.lblJogadorVez.Size = new System.Drawing.Size(78, 13);
            this.lblJogadorVez.TabIndex = 83;
            this.lblJogadorVez.Text = "Vez do jogador";
            // 
            // picDadoPlayer4
            // 
            this.picDadoPlayer4.Location = new System.Drawing.Point(248, 269);
            this.picDadoPlayer4.Name = "picDadoPlayer4";
            this.picDadoPlayer4.Size = new System.Drawing.Size(50, 50);
            this.picDadoPlayer4.TabIndex = 91;
            this.picDadoPlayer4.TabStop = false;
            // 
            // picDadoPlayer3
            // 
            this.picDadoPlayer3.Location = new System.Drawing.Point(192, 269);
            this.picDadoPlayer3.Name = "picDadoPlayer3";
            this.picDadoPlayer3.Size = new System.Drawing.Size(50, 50);
            this.picDadoPlayer3.TabIndex = 90;
            this.picDadoPlayer3.TabStop = false;
            // 
            // picDadoPlayer2
            // 
            this.picDadoPlayer2.Location = new System.Drawing.Point(248, 213);
            this.picDadoPlayer2.Name = "picDadoPlayer2";
            this.picDadoPlayer2.Size = new System.Drawing.Size(50, 50);
            this.picDadoPlayer2.TabIndex = 89;
            this.picDadoPlayer2.TabStop = false;
            // 
            // picDadoPlayer1
            // 
            this.picDadoPlayer1.Location = new System.Drawing.Point(192, 213);
            this.picDadoPlayer1.Name = "picDadoPlayer1";
            this.picDadoPlayer1.Size = new System.Drawing.Size(50, 50);
            this.picDadoPlayer1.TabIndex = 88;
            this.picDadoPlayer1.TabStop = false;
            // 
            // lblDadosPartida
            // 
            this.lblDadosPartida.AutoSize = true;
            this.lblDadosPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosPartida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblDadosPartida.Location = new System.Drawing.Point(189, 194);
            this.lblDadosPartida.Name = "lblDadosPartida";
            this.lblDadosPartida.Size = new System.Drawing.Size(108, 16);
            this.lblDadosPartida.TabIndex = 92;
            this.lblDadosPartida.Text = "Dados Partida";
            // 
            // lblVetor
            // 
            this.lblVetor.AutoSize = true;
            this.lblVetor.Location = new System.Drawing.Point(436, 542);
            this.lblVetor.Name = "lblVetor";
            this.lblVetor.Size = new System.Drawing.Size(32, 13);
            this.lblVetor.TabIndex = 93;
            this.lblVetor.Text = "Vetor";
            // 
            // lblAlpinistas
            // 
            this.lblAlpinistas.AutoSize = true;
            this.lblAlpinistas.Location = new System.Drawing.Point(342, 542);
            this.lblAlpinistas.Name = "lblAlpinistas";
            this.lblAlpinistas.Size = new System.Drawing.Size(51, 13);
            this.lblAlpinistas.TabIndex = 94;
            this.lblAlpinistas.Text = "Alpinistas";
            // 
            // lblPosicao01
            // 
            this.lblPosicao01.AutoSize = true;
            this.lblPosicao01.Location = new System.Drawing.Point(557, 542);
            this.lblPosicao01.Name = "lblPosicao01";
            this.lblPosicao01.Size = new System.Drawing.Size(32, 13);
            this.lblPosicao01.TabIndex = 95;
            this.lblPosicao01.Text = "Vetor";
            // 
            // lblPosicao02
            // 
            this.lblPosicao02.AutoSize = true;
            this.lblPosicao02.Location = new System.Drawing.Point(617, 542);
            this.lblPosicao02.Name = "lblPosicao02";
            this.lblPosicao02.Size = new System.Drawing.Size(32, 13);
            this.lblPosicao02.TabIndex = 96;
            this.lblPosicao02.Text = "Vetor";
            // 
            // lblPosicao03
            // 
            this.lblPosicao03.AutoSize = true;
            this.lblPosicao03.Location = new System.Drawing.Point(674, 542);
            this.lblPosicao03.Name = "lblPosicao03";
            this.lblPosicao03.Size = new System.Drawing.Size(32, 13);
            this.lblPosicao03.TabIndex = 97;
            this.lblPosicao03.Text = "Vetor";
            // 
            // lblVetorPosicao
            // 
            this.lblVetorPosicao.AutoSize = true;
            this.lblVetorPosicao.Location = new System.Drawing.Point(433, 505);
            this.lblVetorPosicao.Name = "lblVetorPosicao";
            this.lblVetorPosicao.Size = new System.Drawing.Size(153, 13);
            this.lblVetorPosicao.TabIndex = 98;
            this.lblVetorPosicao.Text = "0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | A | B | C";
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.Location = new System.Drawing.Point(617, 505);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(153, 13);
            this.lblBackup.TabIndex = 100;
            this.lblBackup.Text = "0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0";
            // 
            // frmTabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(814, 564);
            this.Controls.Add(this.lblBackup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVetorPosicao);
            this.Controls.Add(this.lblPosicao03);
            this.Controls.Add(this.lblPosicao02);
            this.Controls.Add(this.lblPosicao01);
            this.Controls.Add(this.lblAlpinistas);
            this.Controls.Add(this.lblVetor);
            this.Controls.Add(this.lblDadosPartida);
            this.Controls.Add(this.picDadoPlayer4);
            this.Controls.Add(this.picDadoPlayer3);
            this.Controls.Add(this.picDadoPlayer2);
            this.Controls.Add(this.picDadoPlayer1);
            this.Controls.Add(this.lblJogadorVez);
            this.Controls.Add(this.lblSuaCor);
            this.Controls.Add(this.picJogadorVez);
            this.Controls.Add(this.picSuaCor);
            this.Controls.Add(this.lblSorteioDados);
            this.Controls.Add(this.lblCombinacoes);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.txtHistorico);
            this.Controls.Add(this.lblHistórico);
            this.Controls.Add(this.lblInfoJogador);
            this.Controls.Add(this.picDado4);
            this.Controls.Add(this.picDado3);
            this.Controls.Add(this.picDado2);
            this.Controls.Add(this.picDado1);
            this.Controls.Add(this.picTabuleiro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConsole);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTabuleiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuleiro";
            this.Load += new System.EventHandler(this.Tabuleiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDado4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTabuleiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSuaCor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJogadorVez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDadoPlayer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDadoPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDadoPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDadoPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picTabuleiro;
        private System.Windows.Forms.PictureBox picDado1;
        private System.Windows.Forms.PictureBox picDado2;
        private System.Windows.Forms.PictureBox picDado3;
        private System.Windows.Forms.PictureBox picDado4;
        private System.Windows.Forms.Label lblInfoJogador;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.Label lblHistórico;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblCombinacoes;
        private System.Windows.Forms.Timer tmrAtualizacao;
        private System.Windows.Forms.Timer tmrAtualizaTabuleiro;
        private System.Windows.Forms.Label lblSorteioDados;
        private System.Windows.Forms.PictureBox picSuaCor;
        private System.Windows.Forms.PictureBox picJogadorVez;
        private System.Windows.Forms.Label lblSuaCor;
        private System.Windows.Forms.Label lblJogadorVez;
        private System.Windows.Forms.PictureBox picDadoPlayer4;
        private System.Windows.Forms.PictureBox picDadoPlayer3;
        private System.Windows.Forms.PictureBox picDadoPlayer2;
        private System.Windows.Forms.PictureBox picDadoPlayer1;
        private System.Windows.Forms.Label lblDadosPartida;
        private System.Windows.Forms.Label lblVetor;
        private System.Windows.Forms.Label lblAlpinistas;
        private System.Windows.Forms.Label lblPosicao01;
        private System.Windows.Forms.Label lblPosicao02;
        private System.Windows.Forms.Label lblPosicao03;
        private System.Windows.Forms.Label lblVetorPosicao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBackup;
    }
}