
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
            this.btnRolarDados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(184, 28);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(138, 180);
            this.txtConsole.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Console da Partida";
            // 
            // btnRolarDados
            // 
            this.btnRolarDados.BackColor = System.Drawing.Color.Teal;
            this.btnRolarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRolarDados.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRolarDados.Location = new System.Drawing.Point(12, 28);
            this.btnRolarDados.Name = "btnRolarDados";
            this.btnRolarDados.Size = new System.Drawing.Size(150, 48);
            this.btnRolarDados.TabIndex = 37;
            this.btnRolarDados.Text = "Rolar os Dados";
            this.btnRolarDados.UseVisualStyleBackColor = false;
            this.btnRolarDados.Click += new System.EventHandler(this.btnRolarDados_Click);
            // 
            // Tabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 232);
            this.Controls.Add(this.btnRolarDados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConsole);
            this.Name = "Tabuleiro";
            this.Text = "Tabuleiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRolarDados;
    }
}