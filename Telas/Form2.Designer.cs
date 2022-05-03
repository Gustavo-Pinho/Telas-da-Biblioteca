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
            this.lblEmailFunc = new System.Windows.Forms.Label();
            this.lblSenhaFunc = new System.Windows.Forms.Label();
            this.txtEmailFunc = new System.Windows.Forms.TextBox();
            this.txtSenhaFunc = new System.Windows.Forms.TextBox();
            this.btnCadastrarFunc = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(333, 262);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCadastrarFunc);
            this.Controls.Add(this.txtSenhaFunc);
            this.Controls.Add(this.txtEmailFunc);
            this.Controls.Add(this.lblSenhaFunc);
            this.Controls.Add(this.lblEmailFunc);
            this.Name = "Form2";
            this.Text = "Cadstro de Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmailFunc;
        private System.Windows.Forms.Label lblSenhaFunc;
        private System.Windows.Forms.TextBox txtEmailFunc;
        private System.Windows.Forms.TextBox txtSenhaFunc;
        private System.Windows.Forms.Button btnCadastrarFunc;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}