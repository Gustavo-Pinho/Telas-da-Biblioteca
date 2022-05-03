namespace Telas
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNomeEditora = new System.Windows.Forms.Label();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.btnCadstrarEditora = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblNomeEditora
            // 
            this.lblNomeEditora.AutoSize = true;
            this.lblNomeEditora.Location = new System.Drawing.Point(116, 98);
            this.lblNomeEditora.Name = "lblNomeEditora";
            this.lblNomeEditora.Size = new System.Drawing.Size(35, 13);
            this.lblNomeEditora.TabIndex = 8;
            this.lblNomeEditora.Text = "Nome";
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Location = new System.Drawing.Point(188, 91);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.Size = new System.Drawing.Size(121, 20);
            this.txtNomeEditora.TabIndex = 12;
            // 
            // btnCadstrarEditora
            // 
            this.btnCadstrarEditora.Location = new System.Drawing.Point(206, 152);
            this.btnCadstrarEditora.Name = "btnCadstrarEditora";
            this.btnCadstrarEditora.Size = new System.Drawing.Size(75, 23);
            this.btnCadstrarEditora.TabIndex = 14;
            this.btnCadstrarEditora.Text = "Cadastrar";
            this.btnCadstrarEditora.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(499, 217);
            this.Controls.Add(this.btnCadstrarEditora);
            this.Controls.Add(this.txtNomeEditora);
            this.Controls.Add(this.lblNomeEditora);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Cadastro da editora";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNomeEditora;
        private System.Windows.Forms.TextBox txtNomeEditora;
        private System.Windows.Forms.Button btnCadstrarEditora;
    }
}