
namespace Avaliação
{
    partial class GerenciarLinhas
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
            this.dgvLinhasGerenciar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIDLinha = new System.Windows.Forms.TextBox();
            this.tbNumeroLinha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAtivoLinha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinhasGerenciar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLinhasGerenciar
            // 
            this.dgvLinhasGerenciar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinhasGerenciar.Location = new System.Drawing.Point(124, 94);
            this.dgvLinhasGerenciar.Name = "dgvLinhasGerenciar";
            this.dgvLinhasGerenciar.Size = new System.Drawing.Size(582, 201);
            this.dgvLinhasGerenciar.TabIndex = 0;
            this.dgvLinhasGerenciar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinhasGerenciar_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabela de Linhas:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ativar Linha";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 66);
            this.button2.TabIndex = 3;
            this.button2.Text = "Desativar Linha";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "IDLinha:";
            // 
            // tbIDLinha
            // 
            this.tbIDLinha.Location = new System.Drawing.Point(213, 314);
            this.tbIDLinha.Name = "tbIDLinha";
            this.tbIDLinha.Size = new System.Drawing.Size(100, 20);
            this.tbIDLinha.TabIndex = 5;
            // 
            // tbNumeroLinha
            // 
            this.tbNumeroLinha.Location = new System.Drawing.Point(382, 317);
            this.tbNumeroLinha.Name = "tbNumeroLinha";
            this.tbNumeroLinha.Size = new System.Drawing.Size(100, 20);
            this.tbNumeroLinha.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Número:";
            // 
            // tbAtivoLinha
            // 
            this.tbAtivoLinha.Location = new System.Drawing.Point(540, 317);
            this.tbAtivoLinha.Name = "tbAtivoLinha";
            this.tbAtivoLinha.Size = new System.Drawing.Size(100, 20);
            this.tbAtivoLinha.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ativo:";
            // 
            // GerenciarLinhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAtivoLinha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNumeroLinha);
            this.Controls.Add(this.tbIDLinha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLinhasGerenciar);
            this.Name = "GerenciarLinhas";
            this.Text = "GerenciarLinhas";
            this.Load += new System.EventHandler(this.GerenciarLinhas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinhasGerenciar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLinhasGerenciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIDLinha;
        private System.Windows.Forms.TextBox tbNumeroLinha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAtivoLinha;
        private System.Windows.Forms.Label label5;
    }
}