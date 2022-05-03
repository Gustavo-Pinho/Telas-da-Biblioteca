namespace Telas
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.txtAnoLivro = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblNomeLivro = new System.Windows.Forms.Label();
            this.lblAnoLivro = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.lblEditora = new System.Windows.Forms.Label();
            this.btnCadastrarLivro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Location = new System.Drawing.Point(170, 64);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(121, 20);
            this.txtNomeLivro.TabIndex = 6;
            // 
            // txtAnoLivro
            // 
            this.txtAnoLivro.Location = new System.Drawing.Point(170, 90);
            this.txtAnoLivro.Name = "txtAnoLivro";
            this.txtAnoLivro.Size = new System.Drawing.Size(121, 20);
            this.txtAnoLivro.TabIndex = 7;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(170, 116);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(121, 20);
            this.txtGenero.TabIndex = 8;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(170, 142);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(121, 20);
            this.txtAutor.TabIndex = 9;
            // 
            // lblNomeLivro
            // 
            this.lblNomeLivro.AutoSize = true;
            this.lblNomeLivro.Location = new System.Drawing.Point(119, 71);
            this.lblNomeLivro.Name = "lblNomeLivro";
            this.lblNomeLivro.Size = new System.Drawing.Size(35, 13);
            this.lblNomeLivro.TabIndex = 10;
            this.lblNomeLivro.Text = "Nome";
            // 
            // lblAnoLivro
            // 
            this.lblAnoLivro.AutoSize = true;
            this.lblAnoLivro.Location = new System.Drawing.Point(128, 97);
            this.lblAnoLivro.Name = "lblAnoLivro";
            this.lblAnoLivro.Size = new System.Drawing.Size(26, 13);
            this.lblAnoLivro.TabIndex = 11;
            this.lblAnoLivro.Text = "Ano";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(112, 123);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 12;
            this.lblGenero.Text = "Gênero";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(119, 149);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 13;
            this.lblAutor.Text = "Autor";
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(170, 171);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(121, 20);
            this.txtEditora.TabIndex = 14;
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(114, 178);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(40, 13);
            this.lblEditora.TabIndex = 15;
            this.lblEditora.Text = "Editora";
            // 
            // btnCadastrarLivro
            // 
            this.btnCadastrarLivro.Location = new System.Drawing.Point(191, 211);
            this.btnCadastrarLivro.Name = "btnCadastrarLivro";
            this.btnCadastrarLivro.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarLivro.TabIndex = 16;
            this.btnCadastrarLivro.Text = "Cadastrar";
            this.btnCadastrarLivro.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(446, 295);
            this.Controls.Add(this.btnCadastrarLivro);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblAnoLivro);
            this.Controls.Add(this.lblNomeLivro);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtAnoLivro);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Cadastro do livro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.TextBox txtAnoLivro;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblNomeLivro;
        private System.Windows.Forms.Label lblAnoLivro;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Button btnCadastrarLivro;
    }
}