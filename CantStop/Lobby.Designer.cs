
namespace CantStop
{
    partial class Lobby
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExibirPartidas = new System.Windows.Forms.Button();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.dgvPartidas = new System.Windows.Forms.DataGridView();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txtListaJogadores = new System.Windows.Forms.TextBox();
            this.lblListaDePartidas = new System.Windows.Forms.Label();
            this.lblListaDeJogadores = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblInfoJogador = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.txtCorJogador = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDadosDoJogador = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTabuleiro = new System.Windows.Forms.TextBox();
            this.btnExibirTabuleiro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExibirPartidas
            // 
            this.btnExibirPartidas.BackColor = System.Drawing.Color.Teal;
            this.btnExibirPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirPartidas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExibirPartidas.Location = new System.Drawing.Point(12, 108);
            this.btnExibirPartidas.Name = "btnExibirPartidas";
            this.btnExibirPartidas.Size = new System.Drawing.Size(203, 48);
            this.btnExibirPartidas.TabIndex = 1;
            this.btnExibirPartidas.Text = "Exibir Partidas";
            this.btnExibirPartidas.UseVisualStyleBackColor = false;
            this.btnExibirPartidas.Click += new System.EventHandler(this.btnExibirPartidas_Click);
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.BackColor = System.Drawing.Color.Teal;
            this.btnListarJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarJogadores.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListarJogadores.Location = new System.Drawing.Point(230, 187);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(139, 48);
            this.btnListarJogadores.TabIndex = 3;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = false;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // dgvPartidas
            // 
            this.dgvPartidas.BackgroundColor = System.Drawing.Color.White;
            this.dgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPartidas.Location = new System.Drawing.Point(230, 28);
            this.dgvPartidas.MultiSelect = false;
            this.dgvPartidas.Name = "dgvPartidas";
            this.dgvPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartidas.Size = new System.Drawing.Size(425, 128);
            this.dgvPartidas.TabIndex = 4;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackColor = System.Drawing.Color.Teal;
            this.btnCriarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPartida.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCriarPartida.Location = new System.Drawing.Point(12, 54);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(203, 48);
            this.btnCriarPartida.TabIndex = 5;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = false;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(12, 28);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(122, 20);
            this.txtNomePartida.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(140, 28);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(75, 20);
            this.txtSenha.TabIndex = 7;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartida.ForeColor = System.Drawing.Color.Teal;
            this.lblNomePartida.Location = new System.Drawing.Point(12, 9);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(125, 16);
            this.lblNomePartida.TabIndex = 8;
            this.lblNomePartida.Text = "Nome da Partida";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Teal;
            this.lblSenha.Location = new System.Drawing.Point(143, 9);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(52, 16);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.BackColor = System.Drawing.Color.Teal;
            this.btnEntrarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarPartida.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEntrarPartida.Location = new System.Drawing.Point(12, 213);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(203, 48);
            this.btnEntrarPartida.TabIndex = 10;
            this.btnEntrarPartida.Text = "Entrar na partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = false;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(12, 187);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(203, 20);
            this.txtNomeJogador.TabIndex = 11;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.ForeColor = System.Drawing.Color.Teal;
            this.lblNomeJogador.Location = new System.Drawing.Point(46, 168);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(133, 16);
            this.lblNomeJogador.TabIndex = 16;
            this.lblNomeJogador.Text = "Nome do Jogador";
            // 
            // txtListaJogadores
            // 
            this.txtListaJogadores.Location = new System.Drawing.Point(230, 241);
            this.txtListaJogadores.Multiline = true;
            this.txtListaJogadores.Name = "txtListaJogadores";
            this.txtListaJogadores.ReadOnly = true;
            this.txtListaJogadores.Size = new System.Drawing.Size(139, 111);
            this.txtListaJogadores.TabIndex = 18;
            // 
            // lblListaDePartidas
            // 
            this.lblListaDePartidas.AutoSize = true;
            this.lblListaDePartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDePartidas.ForeColor = System.Drawing.Color.Teal;
            this.lblListaDePartidas.Location = new System.Drawing.Point(388, 9);
            this.lblListaDePartidas.Name = "lblListaDePartidas";
            this.lblListaDePartidas.Size = new System.Drawing.Size(125, 16);
            this.lblListaDePartidas.TabIndex = 19;
            this.lblListaDePartidas.Text = "Lista de Partidas";
            // 
            // lblListaDeJogadores
            // 
            this.lblListaDeJogadores.AutoSize = true;
            this.lblListaDeJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDeJogadores.ForeColor = System.Drawing.Color.Teal;
            this.lblListaDeJogadores.Location = new System.Drawing.Point(227, 168);
            this.lblListaDeJogadores.Name = "lblListaDeJogadores";
            this.lblListaDeJogadores.Size = new System.Drawing.Size(142, 16);
            this.lblListaDeJogadores.TabIndex = 20;
            this.lblListaDeJogadores.Text = "Lista de Jogadores";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(571, 362);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(40, 13);
            this.lblVersao.TabIndex = 21;
            this.lblVersao.Text = "Versão";
            // 
            // lblInfoJogador
            // 
            this.lblInfoJogador.AutoSize = true;
            this.lblInfoJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoJogador.ForeColor = System.Drawing.Color.Black;
            this.lblInfoJogador.Location = new System.Drawing.Point(9, 362);
            this.lblInfoJogador.Name = "lblInfoJogador";
            this.lblInfoJogador.Size = new System.Drawing.Size(0, 13);
            this.lblInfoJogador.TabIndex = 22;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Teal;
            this.lblId.Location = new System.Drawing.Point(12, 307);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 15);
            this.lblId.TabIndex = 23;
            this.lblId.Text = "ID";
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaJogador.ForeColor = System.Drawing.Color.Teal;
            this.lblSenhaJogador.Location = new System.Drawing.Point(11, 334);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(48, 15);
            this.lblSenhaJogador.TabIndex = 24;
            this.lblSenhaJogador.Text = "Senha";
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.Location = new System.Drawing.Point(39, 306);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.ReadOnly = true;
            this.txtIdJogador.Size = new System.Drawing.Size(42, 20);
            this.txtIdJogador.TabIndex = 25;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(65, 332);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.ReadOnly = true;
            this.txtSenhaJogador.Size = new System.Drawing.Size(150, 20);
            this.txtSenhaJogador.TabIndex = 26;
            // 
            // txtCorJogador
            // 
            this.txtCorJogador.Location = new System.Drawing.Point(122, 306);
            this.txtCorJogador.Name = "txtCorJogador";
            this.txtCorJogador.ReadOnly = true;
            this.txtCorJogador.Size = new System.Drawing.Size(93, 20);
            this.txtCorJogador.TabIndex = 29;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.ForeColor = System.Drawing.Color.Teal;
            this.lblCor.Location = new System.Drawing.Point(87, 307);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(29, 15);
            this.lblCor.TabIndex = 28;
            this.lblCor.Text = "Cor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 27;
            // 
            // lblDadosDoJogador
            // 
            this.lblDadosDoJogador.AutoSize = true;
            this.lblDadosDoJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosDoJogador.ForeColor = System.Drawing.Color.Teal;
            this.lblDadosDoJogador.Location = new System.Drawing.Point(46, 277);
            this.lblDadosDoJogador.Name = "lblDadosDoJogador";
            this.lblDadosDoJogador.Size = new System.Drawing.Size(138, 16);
            this.lblDadosDoJogador.TabIndex = 30;
            this.lblDadosDoJogador.Text = "Dados do Jogador";
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.Color.Teal;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIniciarPartida.Location = new System.Drawing.Point(375, 187);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(136, 48);
            this.btnIniciarPartida.TabIndex = 31;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(526, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Exibir Tabuleiro";
            // 
            // txtTabuleiro
            // 
            this.txtTabuleiro.Location = new System.Drawing.Point(516, 190);
            this.txtTabuleiro.Multiline = true;
            this.txtTabuleiro.Name = "txtTabuleiro";
            this.txtTabuleiro.ReadOnly = true;
            this.txtTabuleiro.Size = new System.Drawing.Size(139, 99);
            this.txtTabuleiro.TabIndex = 50;
            // 
            // btnExibirTabuleiro
            // 
            this.btnExibirTabuleiro.BackColor = System.Drawing.Color.Teal;
            this.btnExibirTabuleiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirTabuleiro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExibirTabuleiro.Location = new System.Drawing.Point(377, 241);
            this.btnExibirTabuleiro.Name = "btnExibirTabuleiro";
            this.btnExibirTabuleiro.Size = new System.Drawing.Size(136, 48);
            this.btnExibirTabuleiro.TabIndex = 51;
            this.btnExibirTabuleiro.Text = "Exibir Tabuleiro";
            this.btnExibirTabuleiro.UseVisualStyleBackColor = false;
            this.btnExibirTabuleiro.Click += new System.EventHandler(this.btnExibirTabuleiro_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 386);
            this.Controls.Add(this.btnExibirTabuleiro);
            this.Controls.Add(this.txtTabuleiro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lblDadosDoJogador);
            this.Controls.Add(this.txtCorJogador);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.txtIdJogador);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblInfoJogador);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblListaDeJogadores);
            this.Controls.Add(this.lblListaDePartidas);
            this.Controls.Add(this.txtListaJogadores);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.dgvPartidas);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.btnExibirPartidas);
            this.Name = "Lobby";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExibirPartidas;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.DataGridView dgvPartidas;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.TextBox txtListaJogadores;
        private System.Windows.Forms.Label lblListaDePartidas;
        private System.Windows.Forms.Label lblListaDeJogadores;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblInfoJogador;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.TextBox txtCorJogador;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDadosDoJogador;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTabuleiro;
        private System.Windows.Forms.Button btnExibirTabuleiro;
    }
}

