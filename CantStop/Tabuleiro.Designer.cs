
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
            this.lblTeste1 = new System.Windows.Forms.Label();
            this.lblTeste2 = new System.Windows.Forms.Label();
            this.lblTeste3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDado4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTabuleiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSuaCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJogadorVez)).BeginInit();
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
            this.txtHistorico.Size = new System.Drawing.Size(139, 134);
            this.txtHistorico.TabIndex = 72;
            // 
            // lblHistórico
            // 
            this.lblHistórico.AutoSize = true;
            this.lblHistórico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistórico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblHistórico.Location = new System.Drawing.Point(168, 23);
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
            this.tmrAtualizacao.Interval = 2600;
            // 
            // tmrAtualizaTabuleiro
            // 
            this.tmrAtualizaTabuleiro.Interval = 2600;
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
            // lblTeste1
            // 
            this.lblTeste1.AutoSize = true;
            this.lblTeste1.Location = new System.Drawing.Point(132, 542);
            this.lblTeste1.Name = "lblTeste1";
            this.lblTeste1.Size = new System.Drawing.Size(43, 13);
            this.lblTeste1.TabIndex = 84;
            this.lblTeste1.Text = "Teste 1";
            // 
            // lblTeste2
            // 
            this.lblTeste2.AutoSize = true;
            this.lblTeste2.Location = new System.Drawing.Point(181, 542);
            this.lblTeste2.Name = "lblTeste2";
            this.lblTeste2.Size = new System.Drawing.Size(43, 13);
            this.lblTeste2.TabIndex = 85;
            this.lblTeste2.Text = "Teste 2";
            // 
            // lblTeste3
            // 
            this.lblTeste3.AutoSize = true;
            this.lblTeste3.Location = new System.Drawing.Point(230, 542);
            this.lblTeste3.Name = "lblTeste3";
            this.lblTeste3.Size = new System.Drawing.Size(43, 13);
            this.lblTeste3.TabIndex = 87;
            this.lblTeste3.Text = "Teste 3";
            // 
            // frmTabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(814, 564);
            this.Controls.Add(this.lblTeste3);
            this.Controls.Add(this.lblTeste2);
            this.Controls.Add(this.lblTeste1);
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
        private System.Windows.Forms.Label lblTeste1;
        private System.Windows.Forms.Label lblTeste2;
        private System.Windows.Forms.Label lblTeste3;
    }
}