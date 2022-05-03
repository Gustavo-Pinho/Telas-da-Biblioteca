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
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.txtAnoLivro = new System.Windows.Forms.TextBox();
            this.lblNomeLivro = new System.Windows.Forms.Label();
            this.lblAnoLivro = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.btnCadastrarLivro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTombo = new System.Windows.Forms.TextBox();
            this.lblTombo = new System.Windows.Forms.Label();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.comboBoxAutor = new System.Windows.Forms.ComboBox();
            this.comboBoxEditora = new System.Windows.Forms.ComboBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(112, 175);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(40, 13);
            this.lblEditora.TabIndex = 15;
            this.lblEditora.Text = "Editora";
            // 
            // btnCadastrarLivro
            // 
            this.btnCadastrarLivro.Location = new System.Drawing.Point(188, 251);
            this.btnCadastrarLivro.Name = "btnCadastrarLivro";
            this.btnCadastrarLivro.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarLivro.TabIndex = 16;
            this.btnCadastrarLivro.Text = "Cadastrar";
            this.btnCadastrarLivro.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // txtTombo
            // 
            this.txtTombo.Location = new System.Drawing.Point(170, 194);
            this.txtTombo.Name = "txtTombo";
            this.txtTombo.Size = new System.Drawing.Size(121, 20);
            this.txtTombo.TabIndex = 18;
            // 
            // lblTombo
            // 
            this.lblTombo.AutoSize = true;
            this.lblTombo.Location = new System.Drawing.Point(111, 201);
            this.lblTombo.Name = "lblTombo";
            this.lblTombo.Size = new System.Drawing.Size(40, 13);
            this.lblTombo.TabIndex = 19;
            this.lblTombo.Text = "Tombo";
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Location = new System.Drawing.Point(170, 115);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGenero.TabIndex = 20;
            // 
            // comboBoxAutor
            // 
            this.comboBoxAutor.FormattingEnabled = true;
            this.comboBoxAutor.Location = new System.Drawing.Point(170, 142);
            this.comboBoxAutor.Name = "comboBoxAutor";
            this.comboBoxAutor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAutor.TabIndex = 21;
            // 
            // comboBoxEditora
            // 
            this.comboBoxEditora.FormattingEnabled = true;
            this.comboBoxEditora.Location = new System.Drawing.Point(170, 167);
            this.comboBoxEditora.Name = "comboBoxEditora";
            this.comboBoxEditora.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEditora.TabIndex = 22;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(170, 220);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(121, 20);
            this.txtIsbn.TabIndex = 23;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(112, 227);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(32, 13);
            this.lblIsbn.TabIndex = 24;
            this.lblIsbn.Text = "ISBN";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(446, 295);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.comboBoxEditora);
            this.Controls.Add(this.comboBoxAutor);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.lblTombo);
            this.Controls.Add(this.txtTombo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCadastrarLivro);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblAnoLivro);
            this.Controls.Add(this.lblNomeLivro);
            this.Controls.Add(this.txtAnoLivro);
            this.Controls.Add(this.txtNomeLivro);
            this.Name = "Form3";
            this.Text = "Cadastro do livro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.TextBox txtAnoLivro;
        private System.Windows.Forms.Label lblNomeLivro;
        private System.Windows.Forms.Label lblAnoLivro;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Button btnCadastrarLivro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTombo;
        private System.Windows.Forms.Label lblTombo;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.ComboBox comboBoxAutor;
        private System.Windows.Forms.ComboBox comboBoxEditora;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label lblIsbn;
    }
}