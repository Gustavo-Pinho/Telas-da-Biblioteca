namespace Telas
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNomeGenero = new System.Windows.Forms.Label();
            this.btnCadstrarGenero = new System.Windows.Forms.Button();
            this.txtNomeGenero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblNomeGenero
            // 
            this.lblNomeGenero.AutoSize = true;
            this.lblNomeGenero.Location = new System.Drawing.Point(73, 81);
            this.lblNomeGenero.Name = "lblNomeGenero";
            this.lblNomeGenero.Size = new System.Drawing.Size(35, 13);
            this.lblNomeGenero.TabIndex = 10;
            this.lblNomeGenero.Text = "Nome";
            // 
            // btnCadstrarGenero
            // 
            this.btnCadstrarGenero.Location = new System.Drawing.Point(146, 132);
            this.btnCadstrarGenero.Name = "btnCadstrarGenero";
            this.btnCadstrarGenero.Size = new System.Drawing.Size(75, 23);
            this.btnCadstrarGenero.TabIndex = 12;
            this.btnCadstrarGenero.Text = "Cadastrar";
            this.btnCadstrarGenero.UseVisualStyleBackColor = true;
            // 
            // txtNomeGenero
            // 
            this.txtNomeGenero.Location = new System.Drawing.Point(125, 74);
            this.txtNomeGenero.Name = "txtNomeGenero";
            this.txtNomeGenero.Size = new System.Drawing.Size(121, 20);
            this.txtNomeGenero.TabIndex = 14;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(380, 173);
            this.Controls.Add(this.txtNomeGenero);
            this.Controls.Add(this.btnCadstrarGenero);
            this.Controls.Add(this.lblNomeGenero);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form6";
            this.Text = "Cadstro de gênero";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNomeGenero;
        private System.Windows.Forms.Button btnCadstrarGenero;
        private System.Windows.Forms.TextBox txtNomeGenero;
    }
}