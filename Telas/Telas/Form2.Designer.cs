namespace Telas
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEmailFunc = new System.Windows.Forms.Label();
            this.lblSenhaFunc = new System.Windows.Forms.Label();
            this.txtEmailFunc = new System.Windows.Forms.TextBox();
            this.txtSenhaFunc = new System.Windows.Forms.TextBox();
            this.btnCadastrarFunc = new System.Windows.Forms.Button();
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
            // lblEmailFunc
            // 
            this.lblEmailFunc.AutoSize = true;
            this.lblEmailFunc.Location = new System.Drawing.Point(79, 107);
            this.lblEmailFunc.Name = "lblEmailFunc";
            this.lblEmailFunc.Size = new System.Drawing.Size(32, 13);
            this.lblEmailFunc.TabIndex = 1;
            this.lblEmailFunc.Text = "Email";
            // 
            // lblSenhaFunc
            // 
            this.lblSenhaFunc.AutoSize = true;
            this.lblSenhaFunc.Location = new System.Drawing.Point(79, 144);
            this.lblSenhaFunc.Name = "lblSenhaFunc";
            this.lblSenhaFunc.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaFunc.TabIndex = 2;
            this.lblSenhaFunc.Text = "Senha";
            // 
            // txtEmailFunc
            // 
            this.txtEmailFunc.Location = new System.Drawing.Point(131, 100);
            this.txtEmailFunc.Name = "txtEmailFunc";
            this.txtEmailFunc.Size = new System.Drawing.Size(121, 20);
            this.txtEmailFunc.TabIndex = 5;
            // 
            // txtSenhaFunc
            // 
            this.txtSenhaFunc.Location = new System.Drawing.Point(131, 137);
            this.txtSenhaFunc.Name = "txtSenhaFunc";
            this.txtSenhaFunc.Size = new System.Drawing.Size(121, 20);
            this.txtSenhaFunc.TabIndex = 6;
            // 
            // btnCadastrarFunc
            // 
            this.btnCadastrarFunc.Location = new System.Drawing.Point(131, 214);
            this.btnCadastrarFunc.Name = "btnCadastrarFunc";
            this.btnCadastrarFunc.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarFunc.TabIndex = 7;
            this.btnCadastrarFunc.Text = "Cadastrar";
            this.btnCadastrarFunc.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(333, 262);
            this.Controls.Add(this.btnCadastrarFunc);
            this.Controls.Add(this.txtSenhaFunc);
            this.Controls.Add(this.txtEmailFunc);
            this.Controls.Add(this.lblSenhaFunc);
            this.Controls.Add(this.lblEmailFunc);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Cadstro de Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEmailFunc;
        private System.Windows.Forms.Label lblSenhaFunc;
        private System.Windows.Forms.TextBox txtEmailFunc;
        private System.Windows.Forms.TextBox txtSenhaFunc;
        private System.Windows.Forms.Button btnCadastrarFunc;
    }
}