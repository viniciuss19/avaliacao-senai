
namespace Avaliação
{
    partial class MenuPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNomePesquisar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCPFPesquisar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTelefonePesquisar = new System.Windows.Forms.TextBox();
            this.pbPesquisarNome = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbPesquisarCPF = new System.Windows.Forms.PictureBox();
            this.pbPesquisarTelefone = new System.Windows.Forms.PictureBox();
            this.lbltabela = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPesquisarNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPesquisarCPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPesquisarTelefone)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(36, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inserir Clientes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(383, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rouf Rouf Telemarketing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 3;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(539, 154);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(240, 141);
            this.dgvClientes.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Busca por nome:";
            // 
            // tbNomePesquisar
            // 
            this.tbNomePesquisar.Location = new System.Drawing.Point(361, 153);
            this.tbNomePesquisar.Name = "tbNomePesquisar";
            this.tbNomePesquisar.Size = new System.Drawing.Size(100, 20);
            this.tbNomePesquisar.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Busca por CPF:";
            // 
            // tbCPFPesquisar
            // 
            this.tbCPFPesquisar.Location = new System.Drawing.Point(361, 192);
            this.tbCPFPesquisar.Name = "tbCPFPesquisar";
            this.tbCPFPesquisar.Size = new System.Drawing.Size(100, 20);
            this.tbCPFPesquisar.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Busca por Telefone:";
            // 
            // tbTelefonePesquisar
            // 
            this.tbTelefonePesquisar.Location = new System.Drawing.Point(361, 234);
            this.tbTelefonePesquisar.Name = "tbTelefonePesquisar";
            this.tbTelefonePesquisar.Size = new System.Drawing.Size(100, 20);
            this.tbTelefonePesquisar.TabIndex = 10;
            // 
            // pbPesquisarNome
            // 
            this.pbPesquisarNome.Image = global::Avaliação.Properties.Resources.download1;
            this.pbPesquisarNome.Location = new System.Drawing.Point(468, 154);
            this.pbPesquisarNome.Name = "pbPesquisarNome";
            this.pbPesquisarNome.Size = new System.Drawing.Size(65, 20);
            this.pbPesquisarNome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPesquisarNome.TabIndex = 11;
            this.pbPesquisarNome.TabStop = false;
            this.pbPesquisarNome.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Avaliação.Properties.Resources.WhatsApp_Image_2021_05_24_at_21_39_49;
            this.pictureBox1.Location = new System.Drawing.Point(36, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pbPesquisarCPF
            // 
            this.pbPesquisarCPF.Image = global::Avaliação.Properties.Resources.download1;
            this.pbPesquisarCPF.Location = new System.Drawing.Point(468, 192);
            this.pbPesquisarCPF.Name = "pbPesquisarCPF";
            this.pbPesquisarCPF.Size = new System.Drawing.Size(65, 20);
            this.pbPesquisarCPF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPesquisarCPF.TabIndex = 12;
            this.pbPesquisarCPF.TabStop = false;
            // 
            // pbPesquisarTelefone
            // 
            this.pbPesquisarTelefone.Image = global::Avaliação.Properties.Resources.download1;
            this.pbPesquisarTelefone.Location = new System.Drawing.Point(468, 234);
            this.pbPesquisarTelefone.Name = "pbPesquisarTelefone";
            this.pbPesquisarTelefone.Size = new System.Drawing.Size(65, 20);
            this.pbPesquisarTelefone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPesquisarTelefone.TabIndex = 13;
            this.pbPesquisarTelefone.TabStop = false;
            // 
            // lbltabela
            // 
            this.lbltabela.AutoSize = true;
            this.lbltabela.Location = new System.Drawing.Point(612, 123);
            this.lbltabela.Name = "lbltabela";
            this.lbltabela.Size = new System.Drawing.Size(98, 13);
            this.lbltabela.TabIndex = 14;
            this.lbltabela.Text = "Tabela de Clientes:";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 469);
            this.Controls.Add(this.lbltabela);
            this.Controls.Add(this.pbPesquisarTelefone);
            this.Controls.Add(this.pbPesquisarCPF);
            this.Controls.Add(this.pbPesquisarNome);
            this.Controls.Add(this.tbTelefonePesquisar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCPFPesquisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNomePesquisar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPesquisarNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPesquisarCPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPesquisarTelefone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNomePesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCPFPesquisar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTelefonePesquisar;
        private System.Windows.Forms.PictureBox pbPesquisarNome;
        private System.Windows.Forms.PictureBox pbPesquisarCPF;
        private System.Windows.Forms.PictureBox pbPesquisarTelefone;
        private System.Windows.Forms.Label lbltabela;
    }
}

