namespace Telas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblRm = new System.Windows.Forms.Label();
            this.lblEmailAluno = new System.Windows.Forms.Label();
            this.lblSenhaAluno = new System.Windows.Forms.Label();
            this.txtRm = new System.Windows.Forms.TextBox();
            this.txtSenhaAluno = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmailAluno = new System.Windows.Forms.TextBox();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRm
            // 
            this.lblRm.AutoSize = true;
            this.lblRm.Location = new System.Drawing.Point(92, 75);
            this.lblRm.Name = "lblRm";
            this.lblRm.Size = new System.Drawing.Size(24, 13);
            this.lblRm.TabIndex = 0;
            this.lblRm.Text = "RM";
            // 
            // lblEmailAluno
            // 
            this.lblEmailAluno.AutoSize = true;
            this.lblEmailAluno.Location = new System.Drawing.Point(92, 125);
            this.lblEmailAluno.Name = "lblEmailAluno";
            this.lblEmailAluno.Size = new System.Drawing.Size(35, 13);
            this.lblEmailAluno.TabIndex = 1;
            this.lblEmailAluno.Text = "E-mail";
            // 
            // lblSenhaAluno
            // 
            this.lblSenhaAluno.AutoSize = true;
            this.lblSenhaAluno.Location = new System.Drawing.Point(92, 168);
            this.lblSenhaAluno.Name = "lblSenhaAluno";
            this.lblSenhaAluno.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaAluno.TabIndex = 2;
            this.lblSenhaAluno.Text = "Senha";
            // 
            // txtRm
            // 
            this.txtRm.Location = new System.Drawing.Point(144, 75);
            this.txtRm.Name = "txtRm";
            this.txtRm.Size = new System.Drawing.Size(121, 20);
            this.txtRm.TabIndex = 4;
            // 
            // txtSenhaAluno
            // 
            this.txtSenhaAluno.Location = new System.Drawing.Point(144, 161);
            this.txtSenhaAluno.Name = "txtSenhaAluno";
            this.txtSenhaAluno.Size = new System.Drawing.Size(121, 20);
            this.txtSenhaAluno.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmailAluno
            // 
            this.txtEmailAluno.Location = new System.Drawing.Point(144, 118);
            this.txtEmailAluno.Name = "txtEmailAluno";
            this.txtEmailAluno.Size = new System.Drawing.Size(121, 20);
            this.txtEmailAluno.TabIndex = 7;
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Location = new System.Drawing.Point(144, 211);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarAluno.TabIndex = 8;
            this.btnCadastrarAluno.Text = "Cadastrar";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(358, 262);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Controls.Add(this.txtEmailAluno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSenhaAluno);
            this.Controls.Add(this.txtRm);
            this.Controls.Add(this.lblSenhaAluno);
            this.Controls.Add(this.lblEmailAluno);
            this.Controls.Add(this.lblRm);
            this.Name = "Form1";
            this.Text = "Cadastro de Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRm;
        private System.Windows.Forms.Label lblEmailAluno;
        private System.Windows.Forms.Label lblSenhaAluno;
        private System.Windows.Forms.TextBox txtRm;
        private System.Windows.Forms.TextBox txtSenhaAluno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmailAluno;
        private System.Windows.Forms.Button btnCadastrarAluno;
    }
}

