﻿
namespace CantStop
{
    partial class Tabuleiro
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
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.lblTrilha = new System.Windows.Forms.Label();
            this.lblOrdem = new System.Windows.Forms.Label();
            this.txtTrilha = new System.Windows.Forms.TextBox();
            this.txtOrdem = new System.Windows.Forms.TextBox();
            this.btnExibirTabuleiro = new System.Windows.Forms.Button();
            this.txtTabuleiro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRolarDados = new System.Windows.Forms.Button();
            this.btnVerificarVez = new System.Windows.Forms.Button();
            this.picDado4 = new System.Windows.Forms.PictureBox();
            this.picDado3 = new System.Windows.Forms.PictureBox();
            this.picDado2 = new System.Windows.Forms.PictureBox();
            this.picDado1 = new System.Windows.Forms.PictureBox();
            this.picTabuleiro = new System.Windows.Forms.PictureBox();
            this.lblInfoJogador = new System.Windows.Forms.Label();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.lblHistórico = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblCombinacoes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDado4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTabuleiro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(12, 26);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(138, 80);
            this.txtConsole.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Console da Partida";
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.Teal;
            this.btnParar.Enabled = false;
            this.btnParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnParar.Location = new System.Drawing.Point(13, 321);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(139, 48);
            this.btnParar.TabIndex = 58;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnMover
            // 
            this.btnMover.BackColor = System.Drawing.Color.Teal;
            this.btnMover.Enabled = false;
            this.btnMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMover.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMover.Location = new System.Drawing.Point(13, 267);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(139, 48);
            this.btnMover.TabIndex = 57;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = false;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // lblTrilha
            // 
            this.lblTrilha.AutoSize = true;
            this.lblTrilha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrilha.ForeColor = System.Drawing.Color.Teal;
            this.lblTrilha.Location = new System.Drawing.Point(91, 222);
            this.lblTrilha.Name = "lblTrilha";
            this.lblTrilha.Size = new System.Drawing.Size(48, 16);
            this.lblTrilha.TabIndex = 56;
            this.lblTrilha.Text = "Trilha";
            // 
            // lblOrdem
            // 
            this.lblOrdem.AutoSize = true;
            this.lblOrdem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdem.ForeColor = System.Drawing.Color.Teal;
            this.lblOrdem.Location = new System.Drawing.Point(10, 222);
            this.lblOrdem.Name = "lblOrdem";
            this.lblOrdem.Size = new System.Drawing.Size(54, 16);
            this.lblOrdem.TabIndex = 55;
            this.lblOrdem.Text = "Ordem";
            // 
            // txtTrilha
            // 
            this.txtTrilha.Location = new System.Drawing.Point(89, 241);
            this.txtTrilha.Name = "txtTrilha";
            this.txtTrilha.Size = new System.Drawing.Size(63, 20);
            this.txtTrilha.TabIndex = 54;
            // 
            // txtOrdem
            // 
            this.txtOrdem.Location = new System.Drawing.Point(13, 241);
            this.txtOrdem.Name = "txtOrdem";
            this.txtOrdem.Size = new System.Drawing.Size(63, 20);
            this.txtOrdem.TabIndex = 53;
            // 
            // btnExibirTabuleiro
            // 
            this.btnExibirTabuleiro.BackColor = System.Drawing.Color.Teal;
            this.btnExibirTabuleiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirTabuleiro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExibirTabuleiro.Location = new System.Drawing.Point(158, 381);
            this.btnExibirTabuleiro.Name = "btnExibirTabuleiro";
            this.btnExibirTabuleiro.Size = new System.Drawing.Size(139, 48);
            this.btnExibirTabuleiro.TabIndex = 62;
            this.btnExibirTabuleiro.Text = "Exibir Tabuleiro";
            this.btnExibirTabuleiro.UseVisualStyleBackColor = false;
            this.btnExibirTabuleiro.Click += new System.EventHandler(this.btnExibirTabuleiro_Click);
            // 
            // txtTabuleiro
            // 
            this.txtTabuleiro.Location = new System.Drawing.Point(158, 241);
            this.txtTabuleiro.Multiline = true;
            this.txtTabuleiro.Name = "txtTabuleiro";
            this.txtTabuleiro.ReadOnly = true;
            this.txtTabuleiro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTabuleiro.Size = new System.Drawing.Size(139, 134);
            this.txtTabuleiro.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(166, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Exibir Tabuleiro";
            // 
            // btnRolarDados
            // 
            this.btnRolarDados.BackColor = System.Drawing.Color.Teal;
            this.btnRolarDados.Enabled = false;
            this.btnRolarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRolarDados.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRolarDados.Location = new System.Drawing.Point(13, 166);
            this.btnRolarDados.Name = "btnRolarDados";
            this.btnRolarDados.Size = new System.Drawing.Size(139, 48);
            this.btnRolarDados.TabIndex = 63;
            this.btnRolarDados.Text = "Rolar os Dados";
            this.btnRolarDados.UseVisualStyleBackColor = false;
            this.btnRolarDados.Click += new System.EventHandler(this.btnRolarDados_Click_1);
            // 
            // btnVerificarVez
            // 
            this.btnVerificarVez.BackColor = System.Drawing.Color.Teal;
            this.btnVerificarVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarVez.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVerificarVez.Location = new System.Drawing.Point(13, 112);
            this.btnVerificarVez.Name = "btnVerificarVez";
            this.btnVerificarVez.Size = new System.Drawing.Size(139, 48);
            this.btnVerificarVez.TabIndex = 64;
            this.btnVerificarVez.Text = "Verificar Vez";
            this.btnVerificarVez.UseVisualStyleBackColor = false;
            this.btnVerificarVez.Click += new System.EventHandler(this.btnVerificarVez_Click);
            // 
            // picDado4
            // 
            this.picDado4.Location = new System.Drawing.Point(214, 476);
            this.picDado4.Name = "picDado4";
            this.picDado4.Size = new System.Drawing.Size(50, 50);
            this.picDado4.TabIndex = 69;
            this.picDado4.TabStop = false;
            // 
            // picDado3
            // 
            this.picDado3.Location = new System.Drawing.Point(158, 476);
            this.picDado3.Name = "picDado3";
            this.picDado3.Size = new System.Drawing.Size(50, 50);
            this.picDado3.TabIndex = 68;
            this.picDado3.TabStop = false;
            // 
            // picDado2
            // 
            this.picDado2.Location = new System.Drawing.Point(102, 476);
            this.picDado2.Name = "picDado2";
            this.picDado2.Size = new System.Drawing.Size(50, 50);
            this.picDado2.TabIndex = 67;
            this.picDado2.TabStop = false;
            // 
            // picDado1
            // 
            this.picDado1.Location = new System.Drawing.Point(46, 476);
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
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.Teal;
            this.btnHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHistorico.Location = new System.Drawing.Point(158, 166);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(139, 48);
            this.btnHistorico.TabIndex = 73;
            this.btnHistorico.Text = "Exibir Histórico";
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // txtHistorico
            // 
            this.txtHistorico.Location = new System.Drawing.Point(158, 26);
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
            this.lblHistórico.ForeColor = System.Drawing.Color.Teal;
            this.lblHistórico.Location = new System.Drawing.Point(166, 7);
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
            this.lblCombinacoes.Location = new System.Drawing.Point(5, 381);
            this.lblCombinacoes.Name = "lblCombinacoes";
            this.lblCombinacoes.Size = new System.Drawing.Size(71, 13);
            this.lblCombinacoes.TabIndex = 75;
            this.lblCombinacoes.Text = "Combinações";
            // 
            // Tabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(814, 564);
            this.Controls.Add(this.lblCombinacoes);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.txtHistorico);
            this.Controls.Add(this.lblHistórico);
            this.Controls.Add(this.lblInfoJogador);
            this.Controls.Add(this.picDado4);
            this.Controls.Add(this.picDado3);
            this.Controls.Add(this.picDado2);
            this.Controls.Add(this.picDado1);
            this.Controls.Add(this.picTabuleiro);
            this.Controls.Add(this.btnVerificarVez);
            this.Controls.Add(this.btnRolarDados);
            this.Controls.Add(this.btnExibirTabuleiro);
            this.Controls.Add(this.txtTabuleiro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.lblTrilha);
            this.Controls.Add(this.lblOrdem);
            this.Controls.Add(this.txtTrilha);
            this.Controls.Add(this.txtOrdem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConsole);
            this.DoubleBuffered = true;
            this.Name = "Tabuleiro";
            ((System.ComponentModel.ISupportInitialize)(this.picDado4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTabuleiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Label lblTrilha;
        private System.Windows.Forms.Label lblOrdem;
        private System.Windows.Forms.TextBox txtTrilha;
        private System.Windows.Forms.TextBox txtOrdem;
        private System.Windows.Forms.Button btnExibirTabuleiro;
        private System.Windows.Forms.TextBox txtTabuleiro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRolarDados;
        private System.Windows.Forms.Button btnVerificarVez;
        private System.Windows.Forms.PictureBox picTabuleiro;
        private System.Windows.Forms.PictureBox picDado1;
        private System.Windows.Forms.PictureBox picDado2;
        private System.Windows.Forms.PictureBox picDado3;
        private System.Windows.Forms.PictureBox picDado4;
        private System.Windows.Forms.Label lblInfoJogador;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.Label lblHistórico;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblCombinacoes;
    }
}