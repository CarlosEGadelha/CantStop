
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
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(24, 126);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(138, 180);
            this.txtConsole.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(21, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Console da Partida";
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.Teal;
            this.btnParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnParar.Location = new System.Drawing.Point(336, 205);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(136, 48);
            this.btnParar.TabIndex = 58;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnMover
            // 
            this.btnMover.BackColor = System.Drawing.Color.Teal;
            this.btnMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMover.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMover.Location = new System.Drawing.Point(335, 259);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(136, 48);
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
            this.lblTrilha.Location = new System.Drawing.Point(333, 160);
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
            this.lblOrdem.Location = new System.Drawing.Point(333, 118);
            this.lblOrdem.Name = "lblOrdem";
            this.lblOrdem.Size = new System.Drawing.Size(54, 16);
            this.lblOrdem.TabIndex = 55;
            this.lblOrdem.Text = "Ordem";
            // 
            // txtTrilha
            // 
            this.txtTrilha.Location = new System.Drawing.Point(336, 179);
            this.txtTrilha.Name = "txtTrilha";
            this.txtTrilha.Size = new System.Drawing.Size(63, 20);
            this.txtTrilha.TabIndex = 54;
            // 
            // txtOrdem
            // 
            this.txtOrdem.Location = new System.Drawing.Point(336, 137);
            this.txtOrdem.Name = "txtOrdem";
            this.txtOrdem.Size = new System.Drawing.Size(67, 20);
            this.txtOrdem.TabIndex = 53;
            // 
            // btnExibirTabuleiro
            // 
            this.btnExibirTabuleiro.BackColor = System.Drawing.Color.Teal;
            this.btnExibirTabuleiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirTabuleiro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExibirTabuleiro.Location = new System.Drawing.Point(188, 40);
            this.btnExibirTabuleiro.Name = "btnExibirTabuleiro";
            this.btnExibirTabuleiro.Size = new System.Drawing.Size(136, 48);
            this.btnExibirTabuleiro.TabIndex = 62;
            this.btnExibirTabuleiro.Text = "Exibir Tabuleiro";
            this.btnExibirTabuleiro.UseVisualStyleBackColor = false;
            this.btnExibirTabuleiro.Click += new System.EventHandler(this.btnExibirTabuleiro_Click);
            // 
            // txtTabuleiro
            // 
            this.txtTabuleiro.Location = new System.Drawing.Point(188, 126);
            this.txtTabuleiro.Multiline = true;
            this.txtTabuleiro.Name = "txtTabuleiro";
            this.txtTabuleiro.ReadOnly = true;
            this.txtTabuleiro.Size = new System.Drawing.Size(139, 180);
            this.txtTabuleiro.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(199, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Exibir Tabuleiro";
            // 
            // btnRolarDados
            // 
            this.btnRolarDados.BackColor = System.Drawing.Color.Teal;
            this.btnRolarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRolarDados.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRolarDados.Location = new System.Drawing.Point(24, 40);
            this.btnRolarDados.Name = "btnRolarDados";
            this.btnRolarDados.Size = new System.Drawing.Size(136, 48);
            this.btnRolarDados.TabIndex = 63;
            this.btnRolarDados.Text = "Rolar os Dados";
            this.btnRolarDados.UseVisualStyleBackColor = false;
            this.btnRolarDados.Click += new System.EventHandler(this.btnRolarDados_Click_1);
            // 
            // Tabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 333);
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
            this.Name = "Tabuleiro";
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
    }
}