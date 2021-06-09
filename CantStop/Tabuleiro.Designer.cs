
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTabuleiro));
            this.picDado4 = new System.Windows.Forms.PictureBox();
            this.picDado3 = new System.Windows.Forms.PictureBox();
            this.picDado2 = new System.Windows.Forms.PictureBox();
            this.picDado1 = new System.Windows.Forms.PictureBox();
            this.picTabuleiro = new System.Windows.Forms.PictureBox();
            this.lblInfoJogador = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblCombinacoes = new System.Windows.Forms.Label();
            this.tmrAtualizacao = new System.Windows.Forms.Timer(this.components);
            this.picSuaCor = new System.Windows.Forms.PictureBox();
            this.picJogadorVez = new System.Windows.Forms.PictureBox();
            this.lblSuaCor = new System.Windows.Forms.Label();
            this.lblJogadorVez = new System.Windows.Forms.Label();
            this.lblPiracicaba = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.lblErroTeste = new System.Windows.Forms.Label();
            this.lblVetor = new System.Windows.Forms.Label();
            this.lblErroVerificar = new System.Windows.Forms.Label();
            this.lblVetorPosicao = new System.Windows.Forms.Label();
            this.lblBackup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDado4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTabuleiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSuaCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJogadorVez)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picDado4
            // 
            this.picDado4.Location = new System.Drawing.Point(270, 39);
            this.picDado4.Name = "picDado4";
            this.picDado4.Size = new System.Drawing.Size(50, 50);
            this.picDado4.TabIndex = 69;
            this.picDado4.TabStop = false;
            // 
            // picDado3
            // 
            this.picDado3.Location = new System.Drawing.Point(214, 39);
            this.picDado3.Name = "picDado3";
            this.picDado3.Size = new System.Drawing.Size(50, 50);
            this.picDado3.TabIndex = 68;
            this.picDado3.TabStop = false;
            // 
            // picDado2
            // 
            this.picDado2.Location = new System.Drawing.Point(158, 39);
            this.picDado2.Name = "picDado2";
            this.picDado2.Size = new System.Drawing.Size(50, 50);
            this.picDado2.TabIndex = 67;
            this.picDado2.TabStop = false;
            // 
            // picDado1
            // 
            this.picDado1.Location = new System.Drawing.Point(102, 39);
            this.picDado1.Name = "picDado1";
            this.picDado1.Size = new System.Drawing.Size(50, 50);
            this.picDado1.TabIndex = 66;
            this.picDado1.TabStop = false;
            // 
            // picTabuleiro
            // 
            this.picTabuleiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picTabuleiro.Enabled = false;
            this.picTabuleiro.Image = ((System.Drawing.Image)(resources.GetObject("picTabuleiro.Image")));
            this.picTabuleiro.Location = new System.Drawing.Point(450, 70);
            this.picTabuleiro.Name = "picTabuleiro";
            this.picTabuleiro.Size = new System.Drawing.Size(500, 550);
            this.picTabuleiro.TabIndex = 65;
            this.picTabuleiro.TabStop = false;
            // 
            // lblInfoJogador
            // 
            this.lblInfoJogador.AutoSize = true;
            this.lblInfoJogador.Location = new System.Drawing.Point(12, 650);
            this.lblInfoJogador.Name = "lblInfoJogador";
            this.lblInfoJogador.Size = new System.Drawing.Size(45, 13);
            this.lblInfoJogador.TabIndex = 70;
            this.lblInfoJogador.Text = "Jogador";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(887, 650);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(40, 13);
            this.lblVersao.TabIndex = 74;
            this.lblVersao.Text = "Versão";
            // 
            // lblCombinacoes
            // 
            this.lblCombinacoes.AutoSize = true;
            this.lblCombinacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombinacoes.Location = new System.Drawing.Point(99, 108);
            this.lblCombinacoes.Name = "lblCombinacoes";
            this.lblCombinacoes.Size = new System.Drawing.Size(83, 15);
            this.lblCombinacoes.TabIndex = 75;
            this.lblCombinacoes.Text = "Combinações";
            // 
            // tmrAtualizacao
            // 
            this.tmrAtualizacao.Interval = 2500;
            // 
            // picSuaCor
            // 
            this.picSuaCor.Location = new System.Drawing.Point(148, 89);
            this.picSuaCor.Name = "picSuaCor";
            this.picSuaCor.Size = new System.Drawing.Size(30, 30);
            this.picSuaCor.TabIndex = 80;
            this.picSuaCor.TabStop = false;
            // 
            // picJogadorVez
            // 
            this.picJogadorVez.Location = new System.Drawing.Point(338, 89);
            this.picJogadorVez.Name = "picJogadorVez";
            this.picJogadorVez.Size = new System.Drawing.Size(30, 30);
            this.picJogadorVez.TabIndex = 81;
            this.picJogadorVez.TabStop = false;
            // 
            // lblSuaCor
            // 
            this.lblSuaCor.AutoSize = true;
            this.lblSuaCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuaCor.Location = new System.Drawing.Point(71, 93);
            this.lblSuaCor.Name = "lblSuaCor";
            this.lblSuaCor.Size = new System.Drawing.Size(71, 20);
            this.lblSuaCor.TabIndex = 82;
            this.lblSuaCor.Text = "Sua cor";
            // 
            // lblJogadorVez
            // 
            this.lblJogadorVez.AutoSize = true;
            this.lblJogadorVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadorVez.Location = new System.Drawing.Point(202, 93);
            this.lblJogadorVez.Name = "lblJogadorVez";
            this.lblJogadorVez.Size = new System.Drawing.Size(130, 20);
            this.lblJogadorVez.TabIndex = 83;
            this.lblJogadorVez.Text = "Vez do jogador";
            // 
            // lblPiracicaba
            // 
            this.lblPiracicaba.AutoSize = true;
            this.lblPiracicaba.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiracicaba.ForeColor = System.Drawing.Color.White;
            this.lblPiracicaba.Location = new System.Drawing.Point(400, 15);
            this.lblPiracicaba.Name = "lblPiracicaba";
            this.lblPiracicaba.Size = new System.Drawing.Size(167, 37);
            this.lblPiracicaba.TabIndex = 0;
            this.lblPiracicaba.Text = "Piracicaba";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.lblPiracicaba);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 64);
            this.panel1.TabIndex = 101;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHistorico);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 260);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Histórico ";
            // 
            // txtHistorico
            // 
            this.txtHistorico.BackColor = System.Drawing.Color.White;
            this.txtHistorico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistorico.Location = new System.Drawing.Point(17, 25);
            this.txtHistorico.Multiline = true;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.ReadOnly = true;
            this.txtHistorico.Size = new System.Drawing.Size(400, 222);
            this.txtHistorico.TabIndex = 105;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picDado1);
            this.groupBox2.Controls.Add(this.picDado2);
            this.groupBox2.Controls.Add(this.picDado3);
            this.groupBox2.Controls.Add(this.picDado4);
            this.groupBox2.Controls.Add(this.lblCombinacoes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 426);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 194);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meus Dados";
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(342, 650);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(26, 13);
            this.lblErro.TabIndex = 102;
            this.lblErro.Text = "Erro";
            // 
            // lblErroTeste
            // 
            this.lblErroTeste.AutoSize = true;
            this.lblErroTeste.Location = new System.Drawing.Point(624, 650);
            this.lblErroTeste.Name = "lblErroTeste";
            this.lblErroTeste.Size = new System.Drawing.Size(0, 13);
            this.lblErroTeste.TabIndex = 108;
            // 
            // lblVetor
            // 
            this.lblVetor.AutoSize = true;
            this.lblVetor.Location = new System.Drawing.Point(203, 650);
            this.lblVetor.Name = "lblVetor";
            this.lblVetor.Size = new System.Drawing.Size(35, 13);
            this.lblVetor.TabIndex = 109;
            this.lblVetor.Text = "label1";
            this.lblVetor.Visible = false;
            // 
            // lblErroVerificar
            // 
            this.lblErroVerificar.AutoSize = true;
            this.lblErroVerificar.Location = new System.Drawing.Point(203, 623);
            this.lblErroVerificar.Name = "lblErroVerificar";
            this.lblErroVerificar.Size = new System.Drawing.Size(35, 13);
            this.lblErroVerificar.TabIndex = 110;
            this.lblErroVerificar.Text = "label1";
            this.lblErroVerificar.Visible = false;
            // 
            // lblVetorPosicao
            // 
            this.lblVetorPosicao.AutoSize = true;
            this.lblVetorPosicao.Location = new System.Drawing.Point(463, 623);
            this.lblVetorPosicao.Name = "lblVetorPosicao";
            this.lblVetorPosicao.Size = new System.Drawing.Size(35, 13);
            this.lblVetorPosicao.TabIndex = 111;
            this.lblVetorPosicao.Text = "label1";
            this.lblVetorPosicao.Visible = false;
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.Location = new System.Drawing.Point(715, 623);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(35, 13);
            this.lblBackup.TabIndex = 112;
            this.lblBackup.Text = "label2";
            this.lblBackup.Visible = false;
            // 
            // frmTabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(964, 672);
            this.Controls.Add(this.lblBackup);
            this.Controls.Add(this.lblVetorPosicao);
            this.Controls.Add(this.lblErroVerificar);
            this.Controls.Add(this.lblVetor);
            this.Controls.Add(this.lblErroTeste);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblJogadorVez);
            this.Controls.Add(this.lblSuaCor);
            this.Controls.Add(this.picJogadorVez);
            this.Controls.Add(this.picSuaCor);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblInfoJogador);
            this.Controls.Add(this.picTabuleiro);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picTabuleiro;
        private System.Windows.Forms.PictureBox picDado1;
        private System.Windows.Forms.PictureBox picDado2;
        private System.Windows.Forms.PictureBox picDado3;
        private System.Windows.Forms.PictureBox picDado4;
        private System.Windows.Forms.Label lblInfoJogador;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblCombinacoes;
        private System.Windows.Forms.Timer tmrAtualizacao;
        private System.Windows.Forms.PictureBox picSuaCor;
        private System.Windows.Forms.PictureBox picJogadorVez;
        private System.Windows.Forms.Label lblSuaCor;
        private System.Windows.Forms.Label lblJogadorVez;
        private System.Windows.Forms.Label lblPiracicaba;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label lblErroTeste;
        private System.Windows.Forms.Label lblVetor;
        private System.Windows.Forms.Label lblErroVerificar;
        private System.Windows.Forms.Label lblVetorPosicao;
        private System.Windows.Forms.Label lblBackup;
    }
}